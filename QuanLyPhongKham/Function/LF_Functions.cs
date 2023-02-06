using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace QuanLyPhongKham.Function
{
    internal class LF_Functions
    {
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        public static int loginAndGetID(string username, string password)
        {
            try
            {
                int userId;
                SqlConnection connection = new SqlConnection(connectionString);
                bool result = login(username, password);
                if (result == true)
                {
                    string query = "SELECT EMPLOYEE_ID FROM EMPLOYEE WHERE USERNAME = '" + username + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    userId = (int)command.ExecuteScalar();
                    connection.Close();
                    return userId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public static bool login(string userName, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = string.Format("SELECT COUNT(EMPLOYEE_ID) FROM EMPLOYEE WHERE USERNAME = '{0}' AND PASSWORD = '{1}'", userName, hasPass);
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int result = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (result == 1)
            {
                return true;
            }
            return false;
        }
    }
}