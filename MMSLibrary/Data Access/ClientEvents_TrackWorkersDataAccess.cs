using Dapper;
using MMSLibrary.Class_Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MMSLibrary.Data_Access
{
    public class ClientEvents_TrackWorkersDataAccess : SqliteDataAccess
    {
        /// <summary>
        /// LoadClientEventTrackWorker - load records from the join table
        /// </summary>
        /// <param name="id">client event</param>
        /// <returns></returns>
        public static List<ClientEvents_TrackWorkersModel> LoadClientEventTrackWorker(int clientEventId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientEvents_TrackWorkersModel>("SELECT TrackWorkerID, IsApplied, IsSelected, IsPresent FROM ClientEvents_TrackWorkers WHERE ClientEventID = " + clientEventId, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<int> LoadClientEventTrackWorkerIDList(int clientEventId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<int>("SELECT TrackWorkerID FROM ClientEvents_TrackWorkers WHERE isSelected = 1 AND ClientEventID = " + clientEventId, new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// SaveClientEventTrackWorker - insert record to the join table
        /// </summary>
        /// <param name="trackWorkerIdList"> track worker id list</param>
        /// <param name="clientEventId">client event id</param>
        public static void SaveClientEventTrackWorker(List<ClientEvents_TrackWorkersModel> clientsEvents_TrackWorkersList, int clientEventId)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                try
                {
                    foreach (ClientEvents_TrackWorkersModel clientsEvents_TrackWorkers in clientsEvents_TrackWorkersList)
                    {
                        string sqlStatement = "INSERT INTO ClientEvents_TrackWorkers(ClientEventID, TrackWorkerID, IsApplied, IsSelected, IsPresent) " +
                            "VALUES (@clientEventsId, @trackWorkersId, @isApplied, @isSelected, @isPresent) ";

                        var cmd = new SQLiteCommand(sqlStatement, cnn);
                        cmd.Parameters.AddWithValue("@clientEventsId", clientEventId);
                        cmd.Parameters.AddWithValue("@trackWorkersId", clientsEvents_TrackWorkers.TrackWorkerID);
                        cmd.Parameters.AddWithValue("@isApplied", clientsEvents_TrackWorkers.IsApplied);
                        cmd.Parameters.AddWithValue("@IsSelected", clientsEvents_TrackWorkers.IsSelected);
                        cmd.Parameters.AddWithValue("@IsPresent", clientsEvents_TrackWorkers.IsPresent);

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

        /// <summary>
        /// SaveClientEventTrackWorker - insert record to the join table after inserting client event
        /// </summary>
        /// <param name="trackWorkerIdlist">track worker id list</param>
        /// <param name="cnn">database connection</param>
        public static void SaveClientEventTrackWorker(List<ClientEvents_TrackWorkersModel> clientsEvents_TrackWorkersList, SQLiteConnection cnn)
        {
            var output = cnn.Query<int>("SELECT last_insert_rowid()", new DynamicParameters());
            int lastID = output.ElementAt(0);

            try
            {
                foreach (ClientEvents_TrackWorkersModel clientsEvents_TrackWorkers in clientsEvents_TrackWorkersList)
                {
                    string sqlStatement = "INSERT INTO ClientEvents_TrackWorkers(ClientEventID, TrackWorkerID, IsApplied, IsSelected, IsPresent) " +
                        "VALUES (@clientEventsId, @trackWorkersId, @isApplied, @isSelected, @isPresent) ";

                    var cmd = new SQLiteCommand(sqlStatement, cnn);
                    cmd.Parameters.AddWithValue("@clientEventsId", lastID);
                    cmd.Parameters.AddWithValue("@trackWorkersId", clientsEvents_TrackWorkers.TrackWorkerID);
                    cmd.Parameters.AddWithValue("@isApplied", clientsEvents_TrackWorkers.IsApplied);
                    cmd.Parameters.AddWithValue("@IsSelected", clientsEvents_TrackWorkers.IsSelected);
                    cmd.Parameters.AddWithValue("@IsPresent", clientsEvents_TrackWorkers.IsPresent);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                }
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// RemoveAllClientEventTrackWorker - remove every client event record from the join table for fresh data insert
        /// </summary>
        /// <param name="clientEventId">client event id</param>
        /// <returns>bool true or false</returns>
        public static bool RemoveAllClientEventTrackWorker(int clientEventId)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "DELETE FROM ClientEvents_TrackWorkers WHERE clientEventId = @clientEventsId ";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@clientEventsId", clientEventId);

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
    }
}
