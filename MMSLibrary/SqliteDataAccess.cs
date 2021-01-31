using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace MMSLibrary
{
    public class SqliteDataAccess
    {
        /// <summary>
        /// LoadAllClient - Retrieve every client record from database
        /// </summary>
        /// <returns>List of Client Model</returns>
        public static List<ClientModel> LoadAllClient()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientModel>("SELECT * FROM Clients", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// LoadClient - Retrieve client excluding the deleted 
        /// </summary>
        /// <returns>List of Client Model</returns>
        public static List<ClientModel> LoadClient()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientModel>("SELECT * FROM Clients WHERE isDeleted = 0", new DynamicParameters());
                return output.ToList();
            }
        }
        /// <summary>
        /// LoadClient - Retrieve client excluding the deleted 
        /// </summary>
        /// <returns>List of Client Model</returns>
        public static List<ClientModel> LoadClient(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientModel>("SELECT * FROM Clients WHERE isDeleted = 0 AND id = " + id, new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// LoadDeletedClient - Retrieve deleted client from database
        /// </summary>
        /// <returns>List of Client Model</returns>
        public static List<ClientModel> LoadDeletedClient()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientModel>("SELECT * FROM Clients WHERE isDeleted = 0", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveClient(ClientModel client)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT into Clients values (@)", client);
            }
        }
        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
