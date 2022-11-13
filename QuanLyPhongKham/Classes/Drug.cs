using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Classes
{
    internal class Drug
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private string Unit { get; set; }
        private string Manufacturer { get; set; }
        private string Description { get; set; }
        private string Price { get; set; }
        public Drug(int id, string name, string unit, string manufacturer, string description, string price)
        {
            ID = id;
            Name = name;
            Unit = unit;
            Manufacturer = manufacturer;
            Description = description;
            Price = price;
        }
    }
}
