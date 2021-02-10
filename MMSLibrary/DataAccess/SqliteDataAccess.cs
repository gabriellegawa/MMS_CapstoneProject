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
        /// LoadConnectionString - setting up connection to sqlite database file
        /// </summary>
        /// <param name="id">default - check app config to modify</param>
        /// <returns>cpnnection string</returns>
        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
