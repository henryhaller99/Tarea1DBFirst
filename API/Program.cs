using System;
using System.Linq;
using API.DataAccess;
using API.Services;

namespace API
{
    class Program
    {
        public static CustomerSC customerService = new CustomerSC();

        
        static void Main(string[] args)
        { 
            PrintAllCustomers();
            System.Console.WriteLine("-------------------------------------------------------------------");
            PrintACustomer("TRAIH"); 
        }

        public static void PrintAllCustomers()
        {
            var customers = customerService.GetCustomers().ToList();
            customers.ForEach(x => Console.WriteLine("El cliente con el id " + x.CustomerId + " tiene nombre: " + x.ContactName + " y vive en " + x.Country ));
        }

        public static void PrintACustomer(string id)
        {
            var customer = customerService.GetCustomerById(id);
            System.Console.WriteLine("El cliente llamado(a): " + customer.ContactName + " vive en " + customer.Country);
        }

       
    }
}
