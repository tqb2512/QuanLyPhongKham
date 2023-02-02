using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyPhongKham.Function.LoginForm
{
    internal class LF_Functions
    {
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        public static int checkLogin(string username, string password)
        {
            try
            {
                int userId;
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT COUNT(*) FROM EMPLOYEE WHERE USERNAME = '" + username + "' AND PASSWORD = '" + password + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int result = (int)command.ExecuteScalar();
                connection.Close();
                if (result == 1)
                {
                    query = "SELECT EMPLOYEE_ID FROM EMPLOYEE WHERE USERNAME = '" + username + "'";
                    command = new SqlCommand(query, connection);
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
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}