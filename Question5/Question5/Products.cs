using System;
using System.Collections.Generic;
using System.Text;

namespace Question5
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public List<Customer> Buyer { get; set; }
    }
}
