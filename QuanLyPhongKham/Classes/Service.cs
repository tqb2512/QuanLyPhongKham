using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Classes
{
    internal class Service
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public Service()
        {

        }
        public Service(int id, string name, string unit, decimal price, int quantity, string description)
        {
            ID = id;
            Name = name;
            Unit = unit;
            Price = price;
            Quantity = quantity;
            Description = description;
        }
    }
}
