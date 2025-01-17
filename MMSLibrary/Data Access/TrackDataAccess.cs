﻿using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MMSLibrary
{
    public class TrackDataAccess : SqliteDataAccess
    {
        /// <summary>
        /// LoadAllTrack - Retrieve every track record from database
        /// </summary>
        /// <returns>List of Track Model</returns>
        public static List<TrackModel> LoadAllTrack()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM Tracks", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// LoadTrack - Retrieve every track excluding the deleted 
        /// </summary>
        /// <returns>List of Track Model</returns>
        public static List<TrackModel> LoadTrack()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM Tracks WHERE IsDeleted = 0", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// LoadClient - Retrieve a specific Track from database
        /// </summary>
        /// <param name="id">track id</param>
        /// <returns>List of Track Model</returns>
        public static TrackModel LoadTrack(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.QuerySingle<TrackModel>("SELECT * FROM Tracks WHERE IsDeleted = 0 AND TrackID = " + id, new DynamicParameters());
                return output;
            }
        }

        /// <summary>
        /// LoadDeletedTrack - Retrieve deleted track from database
        /// </summary>
        /// <returns>List of Client Model</returns>
        public static List<TrackModel> LoadDeletedTrack()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM Tracks WHERE IsDeleted = 1", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// DeactivateTrack - deactivate track by setting isDeleted field to true
        /// </summary>
        /// <param name="id">track id</param>
        /// <returns>bool true or false</returns>
        public static bool DeactivateTrack(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE Tracks SET IsDeleted = 1 WHERE TrackID = @id ";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.Prepare();
                    ReturnVal = cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    throw ex;
                }
                finally
                {
                    cnn.Close();
                }
                return ReturnVal == 1;
            }
        }

        /// <summary>
        /// ActivateTrack - activate track by setting isDeleted field to false
        /// </summary>
        /// <param name="id">track id</param>
        /// <returns>bool true or false</returns>
        public static bool ActivateTrack(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE Tracks SET IsDeleted = 0 WHERE TrackID = @id ";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.Prepare();
                    ReturnVal = cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    throw ex;
                }
                finally
                {
                    cnn.Close();
                }
                return ReturnVal == 1;
            }
        }

        /// <summary>
        /// UpdateTrack - update track record
        /// </summary>
        /// <param name="updatedClient">updated track information</param>
        /// <param name="id">track id</param>
        /// <returns>bool true or false</returns>
        public static bool UpdateTrack(TrackModel updatedTrack, int id)
        {

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();

                string sqlStatement = "UPDATE Tracks SET [Name] = @updatedName, [IsDeleted] = @updatedIsDeleted "
                                    + "WHERE [TrackID] = @id";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@updatedName", updatedTrack.Name);
                cmd.Parameters.AddWithValue("@updatedIsDeleted", updatedTrack.IsDeleted);

                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.Prepare();
                    ReturnVal = cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    throw ex;
                }
                finally
                {
                    cnn.Close();
                }
                return ReturnVal == 1;
            }

        }

        /// <summary>
        /// SaveTrack - save a new track
        /// </summary>
        /// <param name="client">new track</param>
        public static void SaveTrack(TrackModel track)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                string sqlStatement = "INSERT INTO Tracks(Name, IsDeleted) VALUES(@name, @isDeleted)";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@name", track.Name);
                // HARD CODED FALSE
                cmd.Parameters.AddWithValue("@isDeleted", false);

                try
                {
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    throw ex;
                }
                finally
                {
                    cnn.Close();
                }
            }
        }
    }
}
