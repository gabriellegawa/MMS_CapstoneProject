using Dapper;
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
        /// LoadDeletedClientEvent - load a record of client event from database that are deleted
        /// </summary>
        /// <returns>list of client event</returns>
        public static List<int> LoadClientEventTrackWorker(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<int>("SELECT trackWorkersId FROM ClientsEvents_TrackWorkers WHERE clientsEventsId = " + id, new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveClientEventTrackWorker(List<int> trackWorkerIdList, int clientEventId)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                try
                {
                    foreach (int trackWorkerId in trackWorkerIdList)
                    {
                        string sqlStatement = "INSERT INTO ClientsEvents_TrackWorkers(clientsEventsId, trackWorkersId, isAssigned) VALUES (@clientsEventsId, @trackWorkersId, @isAssigned) ";

                        var cmd = new SQLiteCommand(sqlStatement, cnn);
                        cmd.Parameters.AddWithValue("@clientsEventsId", clientEventId);
                        cmd.Parameters.AddWithValue("@trackWorkersId", trackWorkerId);
                        cmd.Parameters.AddWithValue("@isAssigned", true);

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                    }
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

        public static bool RemoveAllClientEventTrackWorker(int clientEventId)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "DELETE FROM ClientsEvents_TrackWorkers WHERE clientsEventsId = @clientsEventsId ";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@clientsEventsId", clientEventId);

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

                string sqlStatement = "UPDATE ClientEvents SET [clientId] = @updatedClientId, [trackId] = @updatedTrackId, [date] = @updatedDate, "
                                    + "[workersRequested] = @updatedWorkersRequested, [isLunchProvided] = @updatedIsLunchProvided, "
                                    + "[isUsingUpperPaddock] = @updatedisUsingUpperPaddock, [isUsingMiddlePaddock] = @updatedisUsingMiddlePaddock, "
                                    + "[isUsingLowerPaddock] = @updatedisUsingLowerPaddock, [workerCalloutSent] = @updatedWorkerCalloutSent, "
                                    + "[requireSafetyDemo] = @updatedRequireSafetyDemo, [isDeleted] = @updatedIsDeleted "
                                    + "WHERE [id] = @id";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@updatedClientId", updatedClientEvent.ClientId);
                cmd.Parameters.AddWithValue("@updatedTrackId", updatedClientEvent.TrackId);
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
                cmd.Parameters.AddWithValue("@trackId", clientEvent.TrackId);
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
                    AddClientEvent_TrackWorker(clientEvent.TrackWorkersId, cnn);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public static void AddClientEvent_TrackWorker(List<int> trackWorkerIdlist, SQLiteConnection cnn)
        {
            var output = cnn.Query<int>("SELECT last_insert_rowid()", new DynamicParameters());
            int lastID = output.ElementAt(0);

            foreach (int trackWorkerId in trackWorkerIdlist)
            {
                string sqlStatement = "INSERT INTO ClientsEvents_TrackWorkers(clientsEventsId, trackWorkersId, isAssigned) VALUES( @clientsEventsId, @trackWorkersId, @isAssigned)";
                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@clientsEventsId", lastID);
                cmd.Parameters.AddWithValue("@trackWorkersId", trackWorkerId);
                cmd.Parameters.AddWithValue("@isAssigned", true);

                try
                {
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    throw ex;
                }
            }



        }
    }
}
