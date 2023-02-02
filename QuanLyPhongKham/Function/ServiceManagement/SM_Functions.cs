using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Classes;

namespace QuanLyPhongKham.Function.ServiceManagement
{
    internal class SM_Functions
    {
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        public static int sqlQueryExcute(string query)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
        public static DataTable getSqlData(string query)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static Service getDetailService(int serviceID)
        {
            Service service = new Service();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT SERVICE_ID, SERVICE_NAME, SERVICE_PRICE, SERVICE_UNIT, SERVICE_DESCRIPTION FROM SERVICE WHERE SERVICE_ID = '" + serviceID + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    service.ID = reader.GetInt32(0);
                    service.Name = reader.GetString(1);
                    service.Price = reader.GetDecimal(2);
                    service.Unit = reader.GetString(3);
                    service.Description = reader.GetString(4);
                }
                connection.Close();
                return service;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static bool deleteService(int serviceID)
        {
            try
            {
                string query = "DELETE FROM SERVICE WHERE SERVICE_ID = '" + serviceID + "'";
                if (sqlQueryExcute(query) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static bool updateService(Service service)
        {
            try
            {
                string query = "UPDATE SERVICE SET SERVICE_NAME = N'" + service.Name + "', SERVICE_PRICE = '" + service.Price + "', SERVICE_UNIT = N'" + service.Unit + "', SERVICE_DESCRIPTION = N'" + service.Description + "' WHERE SERVICE_ID = '" + service.ID + "'";
                if (sqlQueryExcute(query) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static bool addService(Service service)
        {
            try
            {
                string query = "INSERT INTO SERVICE VALUES ('" + service.ID + "', N'" + service.Name + "', N'" +service.Unit + "', CONVERT(MONEY, " + service.Price + "), N'" + service.Description + "')";
                if (sqlQueryExcute(query) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static int getMaxID()
        {
            try
            {
                int max = 0;
                string query = "SELECT MAX(SERVICE_ID) AS MAX FROM SERVICE";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    max = reader.GetInt32(0);
                }
                connection.Close();
                return max;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
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
