using System;
using System.Linq;
using API.DataAccess;

namespace API
{
    class Program
    {
        private static NORTHWNDContext dbContext = new NORTHWNDContext();

        static void Main(string[] args)
        { 
            PrintAllCustomers();
            System.Console.WriteLine("-------------------------------------------------------------------");
            PrintACustomer("TRAIH"); 
        }

        public static void PrintAllCustomers()
        {
            var customers = GetCustomers().ToList(); 
            customers.ForEach(x => Console.WriteLine("El cliente con el id " + x.CustomerId + " tiene nombre: " + x.ContactName + " y vive en " + x.Country ));
        }

        public static void PrintACustomer(string id)
        {
            var customer = GetCustomerById(id);
            System.Console.WriteLine("El cliente llamado(a): " + customer.ContactName + " vive en " + customer.Country);
        }

        private static IQueryable<Customer> GetCustomers()
        {
            return dbContext.Customers.Select(x => x);
        }

        private static Customer GetCustomerById(string id)
        {
            return GetCustomers().Where(x => x.CustomerId == id).FirstOrDefault();
        }
    }
}
