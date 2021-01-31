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
        #region LOAD METHOD FOR CLIENT
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
        #endregion

        public static int UpdateClient(ClientModel updatedClient, ClientModel oldClient)
        {
            int result;

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlStatement = "UPDATE Clients SET [name] = @updatedName, [primaryContactName] = @updatedPrimaryContactName, "
                                    + "[primaryContactCell] = @updatedPrimaryContactCell, [primaryContactEmail] = @updatedPrimaryContactEmail, [isDeleted] = @updatedIsDeleted "
                                    + "WHERE [id] = @id, [name] = @oldName, [primaryContactName] = @oldPrimaryContactName "
                                    + "[primaryContactCell] = @oldPrimaryContactCell, [primaryContactEmail] = @oldPrimaryContactEmail";

                SQLiteCommand command = new SQLiteCommand(sqlStatement, cnn);
                command.Parameters.Add(new SQLiteParameter("@updatedName"));
                command.Parameters.Add(new SQLiteParameter("@updatedPrimaryContactName"));
                command.Parameters.Add(new SQLiteParameter("@updatedPrimaryContactCell"));
                command.Parameters.Add(new SQLiteParameter("@updatedPrimaryContactEmail"));
                command.Parameters.Add(new SQLiteParameter("@updatedIsDeleted"));

                command.Parameters.Add(new SQLiteParameter("@id"));
                command.Parameters.Add(new SQLiteParameter("@idoldName"));
                command.Parameters.Add(new SQLiteParameter("@oldPrimaryContactName"));
                command.Parameters.Add(new SQLiteParameter("@oldPrimaryContactCell"));
                command.Parameters.Add(new SQLiteParameter("@oldPrimaryContactEmail"));

                command.Parameters["@updatedName"].Value = updatedClient.Name;
                command.Parameters["@updatedPrimaryContactName"].Value = updatedClient.PrimaryContactName;
                command.Parameters["@primaryContactCell"].Value = updatedClient.PrimaryContactCell;
                command.Parameters["@primaryContactEmail"].Value = updatedClient.PrimaryContactEmail;
                command.Parameters["@isDeleted"].Value = updatedClient.IsDeleted;

                command.Parameters["@id"].Value = oldClient.Id;
                command.Parameters["@oldName"].Value = oldClient.Name;
                command.Parameters["@oldPrimaryContactName"].Value = oldClient.PrimaryContactName;
                command.Parameters["@oldPrimaryContactCell"].Value = oldClient.PrimaryContactCell;
                command.Parameters["@oldPrimaryContactEmail"].Value = oldClient.PrimaryContactEmail;

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    throw ex;
                }

            }

            return result;

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
