using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Classes;
using System.Data;
using System.Data.SqlClient;
using QuanLyPhongKham.GUI.MedicalRecordManagement;

namespace QuanLyPhongKham.Function.MedicalRecordManagement
{
    internal class MRM_Functions
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

        public static MedicalRecord getDetailMedicalRecord(int medicalRecordId)
        {
            MedicalRecord medicalRecord = new MedicalRecord();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT MEDICALRECORD_ID, DATE, PATIENT_TEMP, PATIENT_WEIGHT, PATIENT.PATIENT_ID, PATIENT.PATIENT_NAME, PATIENT.PATIENT_SEX, EMPLOYEE.EMPLOYEE_ID, EMPLOYEE.EMPLOYEE_NAME, DIAGNOSIS, NOTE FROM MEDICALRECORD INNER JOIN EXAMINE ON MEDICALRECORD.EXAMINE_ID = EXAMINE.EXAMINE_ID INNER JOIN PATIENT ON EXAMINE.PATIENT_ID = PATIENT.PATIENT_ID INNER JOIN EMPLOYEE ON EXAMINE.EMPLOYEE_ID = EMPLOYEE.EMPLOYEE_ID WHERE MEDICALRECORD_ID = '" + medicalRecordId + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    medicalRecord.ID = reader.GetInt32(0);
                    medicalRecord.Date = reader.GetDateTime(1);
                    medicalRecord.Patient_Temp = float.Parse(reader.GetDouble(2).ToString());
                    medicalRecord.Patient_Weight = float.Parse(reader.GetDouble(3).ToString());
                    medicalRecord.Patient = new Patient();
                    medicalRecord.Patient.ID = reader.GetInt32(4);
                    medicalRecord.Patient.Name = reader.GetString(5);
                    medicalRecord.Patient.Sex = reader.GetString(6);
                    medicalRecord.Employee = new Employee();
                    medicalRecord.Employee.ID = reader.GetInt32(7);
                    medicalRecord.Employee.Name = reader.GetString(8);
                    medicalRecord.Diagnosis = reader.GetString(9);
                    medicalRecord.Note = reader.GetString(10);
                }
                connection.Close();
                query = "SELECT DRUG.DRUG_ID, DRUG_NAME, DRUG_UNIT, QUANTITY, DRUG_MANUFACTURER, DRUG_DESCRIPTION, DRUG_PRICE FROM DRUG INNER JOIN PRESCRIPTION ON DRUG.DRUG_ID = PRESCRIPTION.DRUG_ID WHERE MEDICALRECORD_ID = '" + medicalRecordId + "'";
                command = new SqlCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                List<Drug> drugs = new List<Drug>();
                while (reader.Read())
                {
                    drugs.Add(new Drug(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetDecimal(6)));
                }
                medicalRecord.Drugs = drugs;
                connection.Close();
                query = "SELECT SERVICE.SERVICE_ID, SERVICE_NAME, SERVICE_UNIT, SERVICE_PRICE, QUANTITY FROM SERVICE INNER JOIN SERVICEBILL ON SERVICEBILL.SERVICE_ID = SERVICE.SERVICE_ID WHERE MEDICALRECORD_ID = '" + medicalRecordId + "'";
                command = new SqlCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                List<Service> services = new List<Service>();
                while (reader.Read())
                {
                    services.Add(new Service(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetInt32(4), ""));
                }
                medicalRecord.Services = services;
                connection.Close();
                return medicalRecord;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
       
        
    }
}
