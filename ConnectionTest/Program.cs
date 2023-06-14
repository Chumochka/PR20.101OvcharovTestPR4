using System;
using System.Data.SqlClient;

namespace ConnectionTest
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public string Connect()
        {
            string result;
            string connectionString = "Server=DESKTOP-8HTSRKG\\SQLEXPRESS;Database=login;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                result = con.State.ToString();
            }
            return result;
        }
        public string SelectFunc()
        {
            string connectionString = "Server=DESKTOP-8HTSRKG\\SQLEXPRESS;Database=login;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT Surname FROM Users WHERE ID=4";
                command.Connection = con;
                string result = command.ExecuteScalar().ToString();
                return result;
            }
        }
    }
}
