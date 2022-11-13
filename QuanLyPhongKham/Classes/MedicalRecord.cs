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
        private int ID { get; set; }
        private DateTime Date { get; set; }
        private string Diagnosis { get; set; }
        private string Note { get; set; }
        Patient Patient;
        List<Drug> Drugs;
        List<Service> Services;
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
