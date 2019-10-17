using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Demo.Utilities;
using Dapper;
using System.Linq;

namespace Demo.Test_Data
{
    class DataBase
    {
        private static string connectionString;

        public static string sqlConnection()
        {
            return connectionString = ConfigurationHelper.ConnectionStringSettings();
        }

        public static UserField GetInfo(int Key)
        {
            UserField userField = new UserField();
            using (var connection = new SqlConnection(sqlConnection()))
            {
                String query = "SELECT Username,Password FROM LocalDB.dbo.UserField WHERE coloumn = 10";
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                var value = command.ExecuteReader();
                if (value.HasRows)
                {
                    while (value.Read())
                    {
                        UserField.Username = value["Username"].ToString();
                        UserField.Password = value["Password"].ToString();
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }

            return userField;
        }

    }
}
