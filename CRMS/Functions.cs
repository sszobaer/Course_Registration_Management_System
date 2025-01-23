using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace CRMS
{
    class Functions
    {
        private OracleConnection con;
        private OracleCommand cmd;
        private OracleDataAdapter sda;
        private DataTable dt;
        private string conStr;

        public Functions()
        {
            conStr = @"Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))
    (CONNECT_DATA = (SERVICE_NAME = xe))); User Id = CRMS; Password = 1234; ";
            con = new OracleConnection(conStr);
            cmd = new OracleCommand();
            cmd.Connection = con;
        }

        // Method to get data from the database
        public DataTable GetData(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (OracleConnection con = new OracleConnection(conStr))
                {
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.Add(new OracleParameter(param.Key, param.Value));
                            }
                        }

                        using (OracleDataAdapter sda = new OracleDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception message for debugging
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return dt; // Always return a DataTable (empty if an error occurred)
        }

        // Execute a non-query (insert, update, delete) command
        public int setData(string query, Dictionary<string, object> parameters = null)
        {
            int cnt = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    // Clear previous parameters
                    cmd.Parameters.Clear();

                    // Add new parameters
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.Add(new OracleParameter(param.Key, param.Value));
                        }
                    }

                    cnt = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return cnt;
        }

        // Method to update the password
        public int UpdatePassword(string username, string newPassword)
        {
            try
            {
                string query = "UPDATE Users SET Password = :newPassword WHERE Username = :username";

                // Using dictionary to pass parameters
                var parameters = new Dictionary<string, object>
                {
                    { ":newPassword", newPassword },
                    { ":username", username }
                };

                return setData(query, parameters); // Executes the update query
            }
            catch (Exception ex)
            {
                // Log the exception message for debugging
                Console.WriteLine($"An error occurred while updating password: {ex.Message}");
                return 0; // Return 0 if there was an error
            }
        }
    }
}
