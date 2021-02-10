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

        private static string LoadConnectionString()
        {
            throw new NotImplementedException();
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
        ///// <summary>
        ///// UpdateClient - update client record
        ///// </summary>
        ///// <param name="updatedClient">Updated ClientModel object</param>
        ///// <param name="oldClient">Old ClientModel object</param>
        ///// <returns>num of rows affected</returns>
        //public static bool UpdateTrack(TrackModel updatedTrack, ClientModel oldClient)
        //{

        //    using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var ReturnVal = 0;
        //        cnn.Open();

        //        string sqlStatement = "UPDATE Clients SET [name] = @updatedName, [primaryContactName] = @updatedPrimaryContactName, "
        //                            + "[primaryContactCell] = @updatedPrimaryContactCell, [primaryContactEmail] = @updatedPrimaryContactEmail, [isDeleted] = @updatedIsDeleted "
        //                            + "WHERE [id] = @id, [name] = @oldName, [primaryContactName] = @oldPrimaryContactName "
        //                            + "[primaryContactCell] = @oldPrimaryContactCell, [primaryContactEmail] = @oldPrimaryContactEmail";

        //        var cmd = new SQLiteCommand(sqlStatement, cnn);
        //        cmd.Parameters.AddWithValue("@updatedName", updatedClient.Name);
        //        cmd.Parameters.AddWithValue("@updatedPrimaryContactName", updatedClient.PrimaryContactName);
        //        cmd.Parameters.AddWithValue("@updatedPrimaryContactCell", updatedClient.PrimaryContactCell);
        //        cmd.Parameters.AddWithValue("@updatedPrimaryContactEmail", updatedClient.PrimaryContactEmail);
        //        cmd.Parameters.AddWithValue("@updatedIsDeleted", updatedClient.IsDeleted);

        //        cmd.Parameters.AddWithValue("@id", oldClient.Id);
        //        cmd.Parameters.AddWithValue("@oldName", oldClient.Name);
        //        cmd.Parameters.AddWithValue("@oldPrimaryContactName", oldClient.PrimaryContactName);
        //        cmd.Parameters.AddWithValue("@oldPrimaryContactCell", oldClient.PrimaryContactCell);
        //        cmd.Parameters.AddWithValue("@oldPrimaryContactEmail", oldClient.PrimaryContactEmail);

        //        try
        //        {
        //            cmd.Prepare();
        //            ReturnVal = cmd.ExecuteNonQuery();
        //        }
        //        catch (SQLiteException ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            cnn.Close();
        //        }
        //        return ReturnVal == 1;
        //    }

        //}

        /// <summary>
        /// UpdateClient - update client record
        /// </summary>
        /// <param name="updatedClient">updated client information</param>
        /// <param name="id">client id</param>
        /// <returns>bool true or false</returns>
        public static bool UpdateClient(TrackModel updatedTrack, int id)
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
