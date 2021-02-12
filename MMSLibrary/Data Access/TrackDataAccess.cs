using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSLibrary
{
    class TrackDataAccess : SqliteDataAccess
    {
        /// <summary>
        /// LoadAllClient - Retrieve every client record from database
        /// </summary>
        /// <returns>List of Client Model</returns>
        public static List<TrackModel> LoadAllTrack()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM Tracks", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// LoadClient - Retrieve client excluding the deleted 
        /// </summary>
        /// <returns>List of Client Model</returns>
        public static List<TrackModel> LoadTrack()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM Tracks WHERE isDeleted = 0", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// LoadClient - Retrieve client excluding the deleted 
        /// </summary>
        /// <returns>List of Client Model</returns>
        public static List<TrackModel> LoadTrack(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM Tracks WHERE isDeleted = 0 AND id = " + id, new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// LoadDeletedClient - Retrieve deleted client from database
        /// </summary>
        /// <returns>List of Client Model</returns>
        public static List<TrackModel> LoadDeletedTrack()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM Tracks WHERE isDeleted = 1", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// DeactivateClient - deactivate client by setting isDeleted field to true
        /// </summary>
        /// <param name="id">client id</param>
        /// <returns>bool true or false</returns>
        public static bool DeactivateTrack(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE Tracks SET isDeleted = 1 WHERE id = @id ";

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
        /// ActivateClient - activate client by setting isDeleted field to false
        /// </summary>
        /// <param name="id">client id</param>
        /// <returns>bool true or false</returns>
        public static bool ActivateTrack(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE Tracks SET isDeleted = 0 WHERE id = @id ";

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
        /// UpdateClient - update client record
        /// </summary>
        /// <param name="updatedClient">updated client information</param>
        /// <param name="id">client id</param>
        /// <returns>bool true or false</returns>
        public static bool UpdateTrack(TrackModel updatedTrack, int id)
        {

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();

                string sqlStatement = "UPDATE Tracks SET [name] = @updatedName, [configuration] = @updatedConfiguration"
                                    + "WHERE [id] = @id";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@updatedName", updatedTrack.Name);
                cmd.Parameters.AddWithValue("@updatedConfiguration", updatedTrack.TrackConfiguration);

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
        /// SaveClient - save a new client
        /// </summary>
        /// <param name="client">new client</param>
        public static void SaveTrack(TrackModel track)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                string sqlStatement = "INSERT INTO Tracks(name, configuration, isDeleted) VALUES(@name, @configuration, @isDeleted)";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@name", track.Name);
                cmd.Parameters.AddWithValue("@configuration", track.TrackConfiguration);
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
