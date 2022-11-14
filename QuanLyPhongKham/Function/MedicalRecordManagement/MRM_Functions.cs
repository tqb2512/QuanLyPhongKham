using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyPhongKham.Classes;
using System.Data;

namespace QuanLyPhongKham.Function.MedicalRecordManagement
{
    internal class MRM_Functions
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        public DataTable getTableData(string dataSource, string query)
        {
            connection = new SqlConnection(dataSource);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
