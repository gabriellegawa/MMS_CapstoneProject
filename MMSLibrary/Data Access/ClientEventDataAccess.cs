using Dapper;
using MMSLibrary.Class_Model;
using MMSLibrary.Data_Access;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MMSLibrary.DataAccess
{
    public class ClientEventDataAccess : SqliteDataAccess
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
                var output = cnn.Query<ClientEventModel>("SELECT * FROM ClientEvents WHERE IsDeleted = 0", new DynamicParameters());
                return output.ToList();
            }
        }
        /// <summary>
        /// LoadClientEvent - load a specific record of client event from database that are not deleted
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>list of client event</returns>
        public static ClientEventModel LoadClientEvent(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.QuerySingle<ClientEventModel>("SELECT * FROM ClientEvents WHERE IsDeleted = 0 AND ClientEventID = " + id, new DynamicParameters());
                return output;
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
                var output = cnn.Query<ClientEventModel>("SELECT * FROM ClientEvents WHERE IsDeleted = 1 ", new DynamicParameters());
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
                string sqlStatement = "UPDATE ClientEvents SET IsDeleted = 1 WHERE ClientEventID = @id ";

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
                string sqlStatement = "UPDATE ClientEvents SET IsDeleted = 0 WHERE ClientEventID = @id ";

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

                string sqlStatement = "UPDATE ClientEvents SET [ClientID] = @updatedClientId, [TrackID] = @updatedTrackId, [Date] = @updatedDate, "
                                    + "[WorkersRequested] = @updatedWorkersRequested, [IsLunchProvided] = @updatedIsLunchProvided, "
                                    + "[IsUsingUpperPaddock] = @updatedisUsingUpperPaddock, [IsUsingMiddlePaddock] = @updatedisUsingMiddlePaddock, "
                                    + "[IsUsingLowerPaddock] = @updatedisUsingLowerPaddock, [WorkerCalloutSent] = @updatedWorkerCalloutSent, "
                                    + "[RequireSafetyDemo] = @updatedRequireSafetyDemo, [IsDeleted] = @updatedIsDeleted "
                                    + "WHERE [ClientEventID] = @id";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@updatedClientId", updatedClientEvent.ClientID);
                cmd.Parameters.AddWithValue("@updatedTrackId", updatedClientEvent.TrackID);
                cmd.Parameters.AddWithValue("@updatedDate", updatedClientEvent.Date);
                cmd.Parameters.AddWithValue("@updatedWorkersRequested", updatedClientEvent.WorkersRequested);
                cmd.Parameters.AddWithValue("@updatedIsLunchProvided", updatedClientEvent.IsLunchProvided);
                cmd.Parameters.AddWithValue("@updatedisUsingUpperPaddock", updatedClientEvent.IsUsingUpperPaddock);
                cmd.Parameters.AddWithValue("@updatedisUsingMiddlePaddock", updatedClientEvent.IsUsingMiddlePaddock);
                cmd.Parameters.AddWithValue("@updatedisUsingLowerPaddock", updatedClientEvent.IsUsingLowerPaddock);
                cmd.Parameters.AddWithValue("@updatedWorkerCalloutSent", updatedClientEvent.WorkerCalloutSent);
                cmd.Parameters.AddWithValue("@updatedRequireSafetyDemo", updatedClientEvent.RequireSafetyDemo);
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
        public static void SaveClientEvent(ClientEventModel clientEvent, List<ClientEvents_TrackWorkersModel> clientsEvents_TrackWorkersList)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                string sqlStatement = "INSERT INTO ClientEvents(ClientID, TrackID, Date, WorkersRequested, IsLunchProvided, "
                    + "IsUsingUpperPaddock, IsUsingMiddlePaddock, IsUsingLowerPaddock, WorkerCalloutSent, RequireSafetyDemo, "
                    + "IsDeleted) VALUES( @clientId, @trackId, @date, @workerRequested, @isLunchProvided, @isUsingUpperPaddock, "
                    + "@isUsingMiddlePaddock, @isUsingLowerPaddock, @workerCalloutSent, @requireSafetyDemo, @isDeleted )";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@clientId", clientEvent.ClientID);
                cmd.Parameters.AddWithValue("@trackId", clientEvent.TrackID);
                cmd.Parameters.AddWithValue("@date", clientEvent.Date);
                cmd.Parameters.AddWithValue("@workerRequested", clientEvent.WorkersRequested);
                cmd.Parameters.AddWithValue("@isLunchProvided", clientEvent.IsLunchProvided);
                cmd.Parameters.AddWithValue("@isUsingUpperPaddock", clientEvent.IsUsingUpperPaddock);
                cmd.Parameters.AddWithValue("@isUsingMiddlePaddock", clientEvent.IsUsingMiddlePaddock);
                cmd.Parameters.AddWithValue("@isUsingLowerPaddock", clientEvent.IsUsingLowerPaddock);
                cmd.Parameters.AddWithValue("@workerCalloutSent", clientEvent.WorkerCalloutSent);
                cmd.Parameters.AddWithValue("@requireSafetyDemo", clientEvent.RequireSafetyDemo);
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
                try
                {
                    ClientEvents_TrackWorkersDataAccess.SaveClientEventTrackWorker(clientsEvents_TrackWorkersList, cnn);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }


    }
}
