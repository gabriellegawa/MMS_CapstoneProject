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
    class ClientEventDataAccess : SqliteDataAccess
    {
        /// <summary>
        /// LoadAllClientEvent - load every record of client event from database
        /// </summary>
        /// <returns>list of client event</returns>
        public static List<ClientEventModel> LoadAllClientEvent()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientEventModel>("SELECT * FROM ClientEvents", new DynamicParameters());
                return output.ToList();
            }
        }
        /// <summary>
        /// LoadClientEvent - load record of client event from database that are not deleted
        /// </summary>
        /// <returns>list of client event</returns>
        public static List<ClientEventModel> LoadClientEvent()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientEventModel>("SELECT * FROM ClientEvents WHERE isDeleted = 0", new DynamicParameters());
                return output.ToList();
            }
        }
        /// <summary>
        /// LoadClientEvent - load a specific record of client event from database that are not deleted
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>list of client event</returns>
        public static List<ClientEventModel> LoadClientEvent(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientEventModel>("SELECT * FROM ClientEvents WHERE isDeleted = 0 AND id = " + id, new DynamicParameters());
                return output.ToList();
            }
        }
        /// <summary>
        /// LoadDeletedClientEvent - load a record of client event from database that are deleted
        /// </summary>
        /// <returns>list of client event</returns>
        public static List<ClientEventModel> LoadDeletedClientEvent()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientEventModel>("SELECT * FROM ClientEvents WHERE isDeleted = 1 ", new DynamicParameters());
                return output.ToList();
            }
        }
        /// <summary>
        /// DeactivateClientEvent - deactivate record of client event by setting isDeleted field to 1
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>bool true or false</returns>
        public static bool DeactivateClientEvent(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE ClientEvents SET isDeleted = 1 WHERE id = @id ";

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
        /// ActivateClientEvent - activate record of client event by setting isDeleted field to 0
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>bool true or false</returns>
        public static bool ActivateClientEvent(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE ClientEvents SET isDeleted = 0 WHERE id = @id ";

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
        /// UpdateClientEvent - update record of client event
        /// </summary>
        /// <param name="updatedClientEvent">updated client event</param>
        /// <param name="id">client event id</param>
        /// <returns>bool true or false</returns>
        public static bool UpdateClientEvent(ClientEventModel updatedClientEvent, int id)
        {

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();

                string sqlStatement = "UPDATE ClientEvent SET [clientId] = @updatedClientId, [trackId] = @updatedTrackId, [date] = @updatedDate, "
                                    + "[workersRequested] = @updatedWorkersRequested, [isLunchProvided] = @updatedIsLunchProvided, " 
                                    + "[isUsingUpperPaddock] = @updatedisUsingUpperPaddock, [isUsingMiddlePaddock] = @updatedisUsingMiddlePaddock, " 
                                    + "[isUsingLowerPaddock] = @updatedisUsingLowerPaddock, [workerCalloutSent] = @updatedWorkerCalloutSent, " 
                                    + "[requiredSafetyDemo] = @updatedRequiredSafetyDemo, [isDeleted] = @updatedIsDeleted "
                                    + "WHERE [id] = @id";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@updatedClientId", updatedClientEvent.ClientId);
                cmd.Parameters.AddWithValue("@updatedTrackId", updatedClientEvent.ClientEventTrack);
                cmd.Parameters.AddWithValue("@updatedDate", updatedClientEvent.ClientEventDate);
                cmd.Parameters.AddWithValue("@updatedWorkersRequested", updatedClientEvent.ClientEventWorkerRequested);
                cmd.Parameters.AddWithValue("@updatedIsLunchProvided", updatedClientEvent.IsLunchProvided);
                cmd.Parameters.AddWithValue("@updatedisUsingUpperPaddock", updatedClientEvent.IsUsingUpperPaddock);
                cmd.Parameters.AddWithValue("@updatedisUsingMiddlePaddock", updatedClientEvent.IsUsingMiddlePaddock);
                cmd.Parameters.AddWithValue("@updatedisUsingLowerPaddock", updatedClientEvent.IsUsingLowerPaddock);
                cmd.Parameters.AddWithValue("@updatedWorkerCalloutSent", updatedClientEvent.WorkerCalloutSent);
                cmd.Parameters.AddWithValue("@updatedRequiredSafetyDemo", updatedClientEvent.RequiresSafetyDemo);
                cmd.Parameters.AddWithValue("@updatedIsDeleted", updatedClientEvent.IsDeleted);

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
        /// SaveClientEvent -  save a new record of client event
        /// </summary>
        /// <param name="clientEvent">new client event</param>
        public static void SaveClientEvent(ClientEventModel clientEvent)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                string sqlStatement = "INSERT INTO ClientEvents(clientId, trackId, date, workersRequested, isLunchProvided, " 
                    + "isUsingUpperPaddock, isUsingMiddlePaddock, isUsingLowerPaddock, workerCalloutSent, requireSafetyDemo, " 
                    + "isDeleted) VALUES( @clientId, @trackId, @date, @workerRequested, @isLunchProvided, @isUsingUpperPaddock, " 
                    + "@isUsingMiddlePaddock, @isUsingLowerPaddock, @workerCalloutSent, @requireSafetyDemo, @isDeleted )";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@clientId", clientEvent.ClientId);
                cmd.Parameters.AddWithValue("@trackId", clientEvent.ClientEventTrack);
                cmd.Parameters.AddWithValue("@date", clientEvent.ClientEventDate);
                cmd.Parameters.AddWithValue("@workerRequested", clientEvent.ClientEventWorkerRequested);
                cmd.Parameters.AddWithValue("@isLunchProvided", clientEvent.IsLunchProvided);
                cmd.Parameters.AddWithValue("@isUsingUpperPaddock", clientEvent.IsUsingUpperPaddock);
                cmd.Parameters.AddWithValue("@isUsingMiddlePaddock", clientEvent.IsUsingMiddlePaddock);
                cmd.Parameters.AddWithValue("@isUsingLowerPaddock", clientEvent.IsUsingLowerPaddock);
                cmd.Parameters.AddWithValue("@workerCalloutSent", clientEvent.WorkerCalloutSent);
                cmd.Parameters.AddWithValue("@requireSafetyDemo", clientEvent.RequiresSafetyDemo );
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
