using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Classes;

namespace QuanLyPhongKham.Function.CreateMedicalRecord
{
    internal class CMR_Functions
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

        public static int getMaxID(string query)
        {
            try
            {
                int max = 0;
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
        
        public static bool insertPatient(Patient patient)
        {
            try
            {
                string query = "INSERT INTO PATIENT VALUES (@id, @name, @sex, @address, @phoneNumber, @dateOfBirth)";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", patient.ID);
                command.Parameters.AddWithValue("@name", patient.Name);
                command.Parameters.AddWithValue("@sex", patient.Sex);
                command.Parameters.AddWithValue("@address", patient.Address);
                command.Parameters.AddWithValue("@phoneNumber", patient.PhoneNumber);
                command.Parameters.AddWithValue("@dateOfBirth", patient.DateOfBirth);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thêm bệnh nhân");
            }
            return false;
        }

        public static bool insertExamine(Patient patient, Employee employee)
        {
            try
            {
                string query = "INSERT INTO EXAMINE VALUES (@id, @eID, @pID)";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", getMaxID("SELECT MAX(EXAMINE_ID) AS MAX FROM EXAMINE") + 1);
                command.Parameters.AddWithValue("@pID", patient.ID);
                command.Parameters.AddWithValue("@eID", employee.ID);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Examine Error");
            }
            return false;
        }
        
        public static bool insertToPrescription(int ID, Drug drug)
        {
            try
            {
                string query = "INSERT INTO PRESCRIPTION VALUES (@id, @dID, @q)";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", ID);
                command.Parameters.AddWithValue("@dID", drug.ID);
                command.Parameters.AddWithValue("@q", drug.Quantity);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Prescription Error");
            }
            return false;
        }

        public static bool insertToServiceBill(int ID, Service service)
        {
            try
            {
                string query = "INSERT INTO SERVICEBILL VALUES (@id, @sID, @q)";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", ID);
                command.Parameters.AddWithValue("@sID", service.ID);
                command.Parameters.AddWithValue("@q", service.Quantity);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("ServiceBill Error");
            }
            return false;
        }

        public static bool existPatient(Patient patient)
        {
            string query = "SELECT COUNT(PATIENT_ID) FROM PATIENT WHERE PATIENT_ID = " + patient.ID;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int result = (int)command.ExecuteScalar();
            connection.Close();
            if (result == 1)
                return true;
            return false;
        }

        public static bool createMedicalRecord(MedicalRecord medicalRecord)
        {
            try
            {
                if (existPatient(medicalRecord.Patient) == false)
                    insertPatient(medicalRecord.Patient);
                insertExamine(medicalRecord.Patient, medicalRecord.Employee);
                string query = "INSERT INTO MEDICALRECORD VALUES (@id, @eID, @date, @pTemp, @pWeight, @diagnosis, @note)";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", medicalRecord.ID);
                command.Parameters.AddWithValue("@eID", getMaxID("SELECT MAX(EXAMINE_ID) AS MAX FROM EXAMINE"));
                command.Parameters.AddWithValue("@date", medicalRecord.Date);
                command.Parameters.AddWithValue("@pTemp", medicalRecord.Patient_Temp);
                command.Parameters.AddWithValue("@pWeight", medicalRecord.Patient_Weight);
                command.Parameters.AddWithValue("@diagnosis", medicalRecord.Diagnosis);
                command.Parameters.AddWithValue("@note", medicalRecord.Note);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (medicalRecord.Drugs != null)
                {
                    foreach (Drug drug in medicalRecord.Drugs)
                    {
                        insertToPrescription(medicalRecord.ID, drug);
                    }
                }
                if (medicalRecord.Services != null)
                {
                    foreach (Service service in medicalRecord.Services)
                    {
                        insertToServiceBill(medicalRecord.ID, service);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
