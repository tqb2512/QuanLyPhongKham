using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Classes
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name, string position)
        {
            ID = id;
            Name = name;
            Position = position;
        }
    }
}
