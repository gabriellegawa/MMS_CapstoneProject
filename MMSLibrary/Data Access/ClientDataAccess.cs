using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MMSLibrary.DataAccess
{
    public class ClientDataAccess : SqliteDataAccess
    {
        // TODO: USE CONSTANT
        private const string TABLE_NAME = "Clients";

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
                var output = cnn.Query<ClientModel>("SELECT * FROM Clients WHERE IsDeleted = 0", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// LoadClient - Retrieve client excluding the deleted 
        /// </summary>
        /// <param name="id">client id</param>
        /// <returns>List of Client Model</returns>
        public static ClientModel LoadClient(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.QuerySingle<ClientModel>("SELECT * FROM Clients WHERE IsDeleted = 0 AND ClientID = " + id, new DynamicParameters());
                return output;
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
                var output = cnn.Query<ClientModel>("SELECT * FROM Clients WHERE IsDeleted = 1", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// DeactivateClient - deactivate client by setting isDeleted field to true
        /// </summary>
        /// <param name="id">client id</param>
        /// <returns>bool true or false</returns>
        public static bool DeactivateClient(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE Clients SET IsDeleted = 1 WHERE ClientID = @id ";

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
        /// ActivateClient - activate client by setting isDeleted field to false
        /// </summary>
        /// <param name="id">client id</param>
        /// <returns>bool true or false</returns>
        public static bool ActivateClient(int id)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();
                string sqlStatement = "UPDATE Clients SET IsDeleted = 0 WHERE ClientID = @id ";

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
        /// UpdateClient - update client record
        /// </summary>
        /// <param name="updatedClient">Updated ClientModel object</param>
        /// <param name="oldClient">Old ClientModel object</param>
        /// <returns>num of rows affected</returns>
        public static bool UpdateClient(ClientModel updatedClient, ClientModel oldClient)
        {

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();

                string sqlStatement = "UPDATE Clients SET [Name] = @updatedName, [PrimaryContactName] = @updatedPrimaryContactName, "
                                    + "[PrimaryContactCell] = @updatedPrimaryContactCell, [PrimaryContactEmail] = @updatedPrimaryContactEmail, [IsDeleted] = @updatedIsDeleted "
                                    + "WHERE [ClientID] = @id, [Name] = @oldName, [PrimaryContactName] = @oldPrimaryContactName "
                                    + "[PrimaryContactCell] = @oldPrimaryContactCell, [PrimaryContactEmail] = @oldPrimaryContactEmail";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@updatedName", updatedClient.Name);
                cmd.Parameters.AddWithValue("@updatedPrimaryContactName", updatedClient.PrimaryContactName);
                cmd.Parameters.AddWithValue("@updatedPrimaryContactCell", updatedClient.PrimaryContactCell);
                cmd.Parameters.AddWithValue("@updatedPrimaryContactEmail", updatedClient.PrimaryContactEmail);
                cmd.Parameters.AddWithValue("@updatedIsDeleted", updatedClient.IsDeleted);

                cmd.Parameters.AddWithValue("@id", oldClient.ClientID);
                cmd.Parameters.AddWithValue("@oldName", oldClient.Name);
                cmd.Parameters.AddWithValue("@oldPrimaryContactName", oldClient.PrimaryContactName);
                cmd.Parameters.AddWithValue("@oldPrimaryContactCell", oldClient.PrimaryContactCell);
                cmd.Parameters.AddWithValue("@oldPrimaryContactEmail", oldClient.PrimaryContactEmail);

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
        /// UpdateClient - update client record
        /// </summary>
        /// <param name="updatedClient">updated client information</param>
        /// <param name="id">client id</param>
        /// <returns>bool true or false</returns>
        public static bool UpdateClient(ClientModel updatedClient, int id)
        {

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var ReturnVal = 0;
                cnn.Open();

                string sqlStatement = "UPDATE Clients SET [Name] = @updatedName, [PrimaryContactName] = @updatedPrimaryContactName, "
                                    + "[PrimaryContactCell] = @updatedPrimaryContactCell, [PrimaryContactEmail] = @updatedPrimaryContactEmail, [IsDeleted] = @updatedIsDeleted "
                                    + "WHERE [ClientID] = @id";

                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@updatedName", updatedClient.Name);
                cmd.Parameters.AddWithValue("@updatedPrimaryContactName", updatedClient.PrimaryContactName);
                cmd.Parameters.AddWithValue("@updatedPrimaryContactCell", updatedClient.PrimaryContactCell);
                cmd.Parameters.AddWithValue("@updatedPrimaryContactEmail", updatedClient.PrimaryContactEmail);
                cmd.Parameters.AddWithValue("@updatedIsDeleted", updatedClient.IsDeleted);

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
        /// SaveClient - save a new client
        /// </summary>
        /// <param name="client">new client</param>
        public static void SaveClient(ClientModel client)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                string sqlStatement = "INSERT INTO Clients(Name, PrimaryContactName, PrimaryContactCell, PrimaryContactEmail, IsDeleted) VALUES(@name, @primaryContactName, @primaryContactCell, @primaryContactEmail, @isDeleted)";

                // Prepared statement
                var cmd = new SQLiteCommand(sqlStatement, cnn);
                cmd.Parameters.AddWithValue("@name", client.Name);
                cmd.Parameters.AddWithValue("@primaryContactName", client.PrimaryContactName);
                cmd.Parameters.AddWithValue("@primaryContactCell", client.PrimaryContactCell);
                cmd.Parameters.AddWithValue("@primaryContactEmail", client.PrimaryContactEmail);
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
