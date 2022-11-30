using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Classes
{
    internal class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Patient()
        {
            
        }
        public Patient(int id, string name, string address, string phoneNumber, DateTime dateOfBirth)
        {
            ID = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }
    }
}
