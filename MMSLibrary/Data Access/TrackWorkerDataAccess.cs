﻿using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MMSLibrary.DataAccess
{
    public class TrackWorkerDataAccess : SqliteDataAccess
    {
        /// <summary>
        /// LoadAllTrackWorker - Retrieve every track worker record from database
        /// </summary>
        /// <returns>List of Client Model</returns>
        public static List<TrackWorkerModel> LoadAllTrackWorker()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackWorkerModel>("SELECT * FROM TrackWorkers", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// LoadTrackWorker - Retrieve track worker excluding the deleted 
        /// </summary>
        /// <returns>List of track worker Model</returns>
        public static List<TrackWorkerModel> LoadTrackWorker()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackWorkerModel>("SELECT * FROM TrackWorkers WHERE IsDeleted = 0", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// LoadTrackWorker - Retrieve a specific track worker
        /// </summary>
        /// <param name="id">track worker id</param>
        /// <returns>List of track worker Model</returns>
        public static TrackWorkerModel LoadTrackWorker(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.QuerySingle<TrackWorkerModel>("SELECT * FROM TrackWorkers WHERE IsDeleted = 0 AND TrackWorkerID = " + id, new DynamicParameters());
                return output;
            }
        }

        /// <summary>
        /// LoadDeletedTrackWorker - Retrieve deleted track worker from database
        /// </summary>
        /// <returns>List of track worker Model</returns>
        public static List<TrackWorkerModel> LoadDeletedTrackWorker()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackWorkerModel>("SELECT * FROM TrackWorkers WHERE IsDeleted = 1 ", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// DeactivateTrackWorker - deactivate track worker by setting isDeleted field to true
        /// </summary>
        /// <param name="id">track worker id</param>
        /// <returns>bool true or false</returns>
        public static bool DeactivateTrackWorker(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE TrackWorkers SET IsDeleted = 1 WHERE TrackWorkerID = @id ";

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
        /// ActivateTrackWorker - activate track worker by setting isDeleted field to false
        /// </summary>
        /// <param name="id">track worker id</param>
        /// <returns>bool true or false</returns>
        public static bool ActivateTrackWorker(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE TrackWorkers SET IsDeleted = 0 WHERE TrackWorkerID = @id ";

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
        /// UpdateTrackWorker - update track worker record
        /// </summary>
        /// <param name="updatedClient">Updated track worker object</param>
        /// <param name="id">track worker id</param>
        /// <returns>bool true or false</returns>
        public static bool UpdateTrackWorker(TrackWorkerModel updatedTrackWorker, int id)
        {

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();

                string sqlStatement = "UPDATE TrackWorkers SET [FirstName] = @updatedFirstName, [LastName] = @updatedLastName, "
                                    + "[Cell] = @updatedCell, [Email] = @updatedEmail, [IsCapableCaptain] = @updatedIsCapableCaptain, [IsDeleted] = @updatedIsDeleted "
                                    + "WHERE [TrackWorkerID] = @id";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@updatedFirstName", updatedTrackWorker.FirstName);
                cmd.Parameters.AddWithValue("@updatedLastName", updatedTrackWorker.LastName);
                cmd.Parameters.AddWithValue("@updatedCell", updatedTrackWorker.Cell);
                cmd.Parameters.AddWithValue("@updatedEmail", updatedTrackWorker.Email);
                cmd.Parameters.AddWithValue("@updatedIsCapableCaptain", updatedTrackWorker.IsCapableCaptain);
                cmd.Parameters.AddWithValue("@updatedIsDeleted", updatedTrackWorker.IsDeleted);

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
        /// SaveTrackWorker -  save a new track worker record
        /// </summary>
        /// <param name="trackWorker">new track worker</param>
        public static void SaveTrackWorker(TrackWorkerModel trackWorker)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                string sqlStatement = "INSERT INTO TrackWorkers(FirstName, LastName, Cell, Email, IsCapableCaptain, IsDeleted) VALUES(@firstName, @lastName, @cell, @email, @isCapableCaptain, @isDeleted)";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@firstName", trackWorker.FirstName);
                cmd.Parameters.AddWithValue("@lastName", trackWorker.LastName);
                cmd.Parameters.AddWithValue("@cell", trackWorker.Cell);
                cmd.Parameters.AddWithValue("@email", trackWorker.Email);
                cmd.Parameters.AddWithValue("@isCapableCaptain", trackWorker.IsCapableCaptain);
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
