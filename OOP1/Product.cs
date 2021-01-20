using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //ürün birimfiyatı
        public double UnitPrice { get; set; }
        //ürün stod adeti
        public int UnitInStock { get; set; }
        
        
    }
}
