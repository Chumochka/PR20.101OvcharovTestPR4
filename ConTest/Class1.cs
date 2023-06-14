using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTest
{
    public class Class1
    {
        public string Connect()
        {
            string result;
            string connectionString = @"Data Source=DESKTOP-8HTSRKG\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                result = con.State.ToString();
                con.Close();
            }
            return result;
        }
        public string SelectFunc()
        {
            string connectionString = @"Data Source=DESKTOP-8HTSRKG\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT Surname FROM Users WHERE ID=4";
                command.Connection = con;
                string result = command.ExecuteScalar().ToString();
                return result;
                con.Close();
            }
        }
    }
}
