using System;
using System.Linq;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server = DESKTOP-64F91VI\\MSSQLSERVER2019; Database = CSharp; User Id = csharp_user; Password = 123456;";
            var migrationAssemblyName = typeof(Program).Assembly.FullName;
            var context = new FrameworkContext(connectionString, migrationAssemblyName);

            CreateProducts(context);
            AddCustomer(context);

            var customer = GetCustomer(context, 2);
            Console.WriteLine(customer.Name);
            context.Customers.Remove(customer);
            context.SaveChanges();

        }

        public static Customer GetCustomer(FrameworkContext context, int id)
        {
            var customer = context.Customers.Where(option => option.Id == id).FirstOrDefault();
            return customer;
        }

        public static void AddCustomer(FrameworkContext context)
        {
            var newCustomer = new Customer
            {
                Name = "Farhan",
                Mobile = "12345678",
                EmailID = "a@a.com",
                Address = "Dhaka, Bangladesh"
            };

            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public static void CreateProducts(FrameworkContext context)
        {
            var product = new Products
            {
                ProductName = "Walton",
                Price = 6000,
            };

            var customer = new Customer
            {
                Name = "Farhan",
                Mobile = "12345678",
                EmailID = "a@a.com",
                Address = "Dhaka, Bangladesh"
            };

            product.Buyer = new System.Collections.Generic.List<Customer>();
            product.Buyer.Add(customer);

            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}
