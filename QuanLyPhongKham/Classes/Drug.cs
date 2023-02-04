using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Classes
{
    internal class Drug
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Drug()
        {
            
        }
        public Drug(int id, string name, int typeid, string typename, string unit, int quantity, string manufacturer, string description, decimal price)
        {
            ID = id;
            Name = name;
            TypeID = typeid;
            TypeName = typename;
            Unit = unit;
            Quantity = quantity;
            Manufacturer = manufacturer;
            Description = description;
            Price = price;
        }

        public Drug(int id, string name, string unit, int quantity, string manufacturer, string description, decimal price)
        {
            ID = id;
            Name = name;
            Unit = unit;
            Quantity = quantity;
            Manufacturer = manufacturer;
            Description = description;
            Price = price;
        }
    }
}
