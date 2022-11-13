using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Classes
{
    internal class Patient
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
        private string PhoneNumber { get; set; }
        private DateTime DateOfBirth { get; set; }
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
