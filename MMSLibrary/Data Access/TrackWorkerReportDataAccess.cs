using Dapper;
using MMSLibrary.Class_Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MMSLibrary.Data_Access
{
    public class TrackWorkerReportDataAccess : SqliteDataAccess
    {
        /// <summary>
        /// LoadTrackWorkerReport - load the report query to the model
        /// </summary>
        /// <returns></returns>
        public static List<TrackWorkerReportModel> LoadTrackWorkerReport()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackWorkerReportModel>("SELECT t.FirstName || \" \" || t.LastName AS \"TrackWorkerFullName\", SUM(IsApplied) AS \"TotalDaysApplied\", " +
                    "SUM(IsSelected) AS \"TotalDaysSelected\", SUM(IsPresent) AS \"TotalDaysPresent\" " +
                    "FROM  ClientEvents_TrackWorkers as j, TrackWorkers as t " +
                    "WHERE j.TrackWorkerId = t.TrackWorkerId " +
                    // For future development, just date format in yyyymmdd
                    //"AND substr(Date, 7) || substr(Date, 4, 2) || substr(Date, 1, 2) between '20101101' and '29991130' " +
                    "GROUP BY j.TrackWorkerId; ", new DynamicParameters());
                return output.ToList();
            }
        }

    }
}
