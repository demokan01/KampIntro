using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product 
    {
        public int Id { get; set; }//Primary Key
        public int CategoryId { get; set; }//Foreign key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        


    }
}
