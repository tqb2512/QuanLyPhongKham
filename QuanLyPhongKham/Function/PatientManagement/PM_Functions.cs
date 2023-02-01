using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyPhongKham.Classes;

namespace QuanLyPhongKham.Function.PatientManagement
{
    internal class PM_Functions
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
            catch(Exception ex)
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

        public static Patient getDetailPatient(int PatientID)
        {
            Patient patient = new Patient();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT Patient_ID, Patient_NAME, Patient_SEX, Patient_ADDRESS, Patient_PHONENUMBER, PATIENT_DATEOFBIRTH FROM Patient WHERE Patient_ID = '" + PatientID + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patient.ID = reader.GetInt32(0);
                    patient.Name = reader.GetString(1);
                    patient.Sex = reader.GetString(2);
                    patient.Address = reader.GetString(3);
                    patient.PhoneNumber = reader.GetString(4);
                    patient.DateOfBirth = reader.GetDateTime(5);
                }
                connection.Close();
                return patient;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static bool deletePatient(int patientID)
        {
            try
            {
                //delete patient
                string query = "DELETE FROM PATIENT WHERE PATIENT_ID = '" + patientID + "'";
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

        public static bool addPatient(Patient patient)
        {
            try
            {
                string query = "INSERT INTO PATIENT VALUES ('" + patient.ID + "', '" + patient.Name + "', '" +patient.Sex + "', '" + patient.Address + "', '" + patient.PhoneNumber + "', '" + patient.DateOfBirth + "')";
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

        public static bool updatePatient(Patient patient)
        {
            try
            {
                string query = "UPDATE patient SET patient_NAME = '" + patient.Name + "', patient_SEX = '" + patient.Sex + "', patient_ADDRESS = '" + patient.Address + "', patient_PHONENUMBER = '" + patient.PhoneNumber + "', patient_DATEOFBIRTH = '" + patient.DateOfBirth + "' WHERE patient_ID = '" + patient.ID + "'";
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
