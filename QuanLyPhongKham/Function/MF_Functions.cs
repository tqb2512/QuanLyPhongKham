using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Classes;
using System.Data.SqlClient;

namespace QuanLyPhongKham.Function
{
    internal class MF_Functions
    {
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        public void resizeAllTabPages(Size size)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Name != "MF_MainForm")
                {
                    form.Size = size;
                }
            }
        }

        public static Employee getUserInfo(int userId)
        {
            Employee employee = new Employee();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT EMPLOYEE_NAME, EMPLOYEE_POSITION FROM EMPLOYEE WHERE EMPLOYEE_ID = " + userId;
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                employee.Name = reader.GetString(0);
                employee.Position = reader.GetString(1);
            }
            employee.ID = userId;
            connection.Close();
            return employee;
        }

        public static bool checkPermission(int ID, string permission)
        {

            string query = "SELECT " + permission + " FROM PERMISSION WHERE EMPLOYEE_ID = " + ID;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToBoolean(reader.GetByte(0)) == true)
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }
    }
}
