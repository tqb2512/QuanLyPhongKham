using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Classes;

namespace QuanLyPhongKham.Classes
{
    internal class MedicalRecord
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Diagnosis { get; set; }
        public string Note { get; set; }
        public Patient Patient;
        public Employee Employee;
        public List<Drug> Drugs;
        public List<Service> Services;
        public MedicalRecord()
        {
            
        }
        public MedicalRecord(int id, DateTime date, Patient patient, List<Drug> drugs, List<Service> services, string diagnosis, string note)
        {
            ID = id;
            Date = date;
            Patient = patient;
            Drugs = drugs;
            Services = services;
            Diagnosis = diagnosis;
            Note = note;
        }
    }
}
