using System;
using System.Linq;
using API.DataAccess;
using API.Services;

namespace API
{
    class Program
    {
        public static CustomerSC customerService = new CustomerSC();
        public static OrderSC orderService = new OrderSC();

        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tCUSTOMERS INFO");
            PrintAllCustomers();
            Console.WriteLine("---------------------------------------");
            PrintACustomer("TRAIH");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\t\t\tORDERS INFO");
            PrintAllOrders();
            Console.WriteLine("---------------------------------------");
            PrintAOrder(11070);

        }

        public static void PrintAllCustomers()
        {
            var customers = customerService.GetCustomers().ToList();
            customers.ForEach(x => Console.WriteLine("El cliente con el id " +
            x.CustomerId + " tiene nombre: " +
            x.ContactName + " y vive en " + x.Country));
        }

        public static void PrintACustomer(string id)
        {
            var customer = customerService.GetCustomerById(id);
            System.Console.WriteLine("El cliente llamado(a): " +
            customer.ContactName + " vive en " + customer.Country);
        }

        public static void PrintAllOrders()
        {
            var orders = orderService.GetOrders().ToList();
            orders.ForEach(x => Console.WriteLine("La orden " +
            x.OrderId + " esta registrada"));
        }
        public static void PrintAOrder(int id)
        {
            var order = orderService.GetOrder(id);
            Console.WriteLine("La orden" + order.OrderId +
            " esta lista para ser transferida");
        }
    }
}
