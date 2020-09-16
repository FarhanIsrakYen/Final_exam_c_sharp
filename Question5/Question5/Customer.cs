using System;
using System.Collections.Generic;
using System.Text;

namespace Question5
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public string EmailID { get; set; }
        public List<Customer> AllCustomer { get; set; }
    }
}
