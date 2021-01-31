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
        public static List<ClientModel> LoadClient()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ClientModel>("SELECT * FROM Clients", new DynamicParameters());
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
