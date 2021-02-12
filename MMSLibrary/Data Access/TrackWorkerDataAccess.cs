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
        public static List<TrackModel> LoadAllTrack()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM TrackWorkers", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<TrackModel> LoadTrack()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM TrackWorkers WHERE isDeleted = 0", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<TrackModel> LoadTrack(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM TrackWorkers WHERE isDeleted = 0 AND id = " + id, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<TrackModel> LoadDeletedTrack()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TrackModel>("SELECT * FROM TrackWorkers WHERE isDeleted = 1 ", new DynamicParameters());
                return output.ToList();
            }
        }
    }
}
