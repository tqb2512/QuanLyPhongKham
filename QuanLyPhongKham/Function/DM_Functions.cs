using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Classes;

namespace QuanLyPhongKham.Function
{
    internal class DM_Functions
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

        public static int getMaxID()
        {
            try
            {
                int max = 0;
                string query = "SELECT MAX(DRUG_ID) AS MAX FROM DRUG";
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

        public static Drug getDetailDrug(int drugID)
        {
            Drug drug = new Drug();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT DRUG_ID, DRUG_NAME, DRUG_TYPE.DRUG_TYPE_ID, DRUG_TYPE_NAME, DRUG_UNIT, DRUG_MANUFACTURER, DRUG_PRICE, DRUG_DESCRIPTION FROM DRUG FULL OUTER JOIN DRUG_TYPE ON DRUG_TYPE.DRUG_TYPE_ID = DRUG.DRUG_TYPE_ID WHERE DRUG_ID = '" + drugID + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    drug.ID = reader.GetInt32(0);
                    drug.Name = reader.GetString(1);
                    drug.TypeID = reader.GetInt32(2);
                    drug.TypeName = reader.GetString(3);
                    drug.Unit = reader.GetString(4);
                    drug.Manufacturer = reader.GetString(5);
                    drug.Price = reader.GetDecimal(6);
                    drug.Description = reader.GetString(7);
                }
                connection.Close();
                return drug;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
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

        public static bool deleteDrug(int drugID)
        {
            try
            {
                string query = "DELETE FROM DRUG WHERE DRUG_ID = '" + drugID + "'";
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

        public static bool addDrug(Drug drug)
        {
            try
            {
                string query = "INSERT INTO DRUG VALUES ('" + drug.ID + "', N'" + drug.TypeID + "', N'" + drug.Name + "', N'" + drug.Unit + "', N'" + drug.Manufacturer + "', N'" + drug.Description + "', " + drug.Price + ")";
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

        public static bool updateDrug(Drug drug)
        {
            try
            {
                string query = "UPDATE DRUG SET DRUG_NAME = N'" + drug.Name + "', DRUG_TYPE_ID = " + drug.TypeID + ", DRUG_UNIT = N'" + drug.Unit + "', DRUG_MANUFACTURER = N'" + drug.Manufacturer + "', DRUG_DESCRIPTION = N'" + drug.Description + "', DRUG_PRICE = " + drug.Price + " WHERE DRUG_ID = '" + drug.ID + "'";
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
    }
}
