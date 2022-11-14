using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Classes
{
    internal class Service
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Unit { get; set; }
        public Service(string name, int price, string unit)
        {
            Name = name;
            Price = price;
            Unit = unit;
        }

    }
}
