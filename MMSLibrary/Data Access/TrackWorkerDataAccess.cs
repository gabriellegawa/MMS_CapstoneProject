using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSLibrary.DataAccess
{
    class TrackWorkerDataAccess : SqliteDataAccess
    {
        /// <summary>
        /// LoadAllClient - Retrieve every client record from database
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
        public static List<TrackWorkerModel> LoadTrackWorker()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackWorkerModel>("SELECT * FROM TrackWorkers WHERE isDeleted = 0", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<TrackWorkerModel> LoadTrackWorker(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackWorkerModel>("SELECT * FROM TrackWorkers WHERE isDeleted = 0 AND id = " + id, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<TrackWorkerModel> LoadDeletedTrackWorker()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackWorkerModel>("SELECT * FROM TrackWorkers WHERE isDeleted = 1 ", new DynamicParameters());
                return output.ToList();
            }
        }

        public static bool DeactivateTrackWorker(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE TrackWorkers SET isDeleted = 1 WHERE id = @id ";

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
        public static bool ActivateTrackWorker(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE TrackWorkers SET isDeleted = 0 WHERE id = @id ";

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
        public static bool UpdateTrackWorker(TrackWorkerModel updatedTrackWorker, int id)
        {

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();

                string sqlStatement = "UPDATE TrackWorkers SET [firstName] = @updatedFirstName, [lastName] = @updatedLastName, "
                                    + "[cell] = @updatedCell, [email] = @updatedEmail, [isCapableCaptain] = @updatedIsCapableCaptain, [isDeleted] = @updatedIsDeleted "
                                    + "WHERE [id] = @id";

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
        public static void SaveTrackWorker(TrackWorkerModel trackWorker)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                string sqlStatement = "INSERT INTO TrackWorkers(firstName, lastName, cell, email, isCapableCaptain, isDeleted) VALUES(@firstName, @lastName, @cell, @email, isCapableCaptain, @isDeleted)";

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
