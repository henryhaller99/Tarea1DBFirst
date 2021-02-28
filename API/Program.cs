using System;
using System.Linq;
using API.DataAccess;

namespace API
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NORTHWNDContext dbContext = new NORTHWNDContext(); // instanciamos el dbContext

            var customers = dbContext.Customers.Select(c => new {
                c.CustomerId,
                c.ContactName,
                c.Country
            }).ToList(); // hacemos la consulta a la base de datos y la materializamos

            customers.ForEach(x => Console.WriteLine("El cliente con el id " + x.CustomerId + " tiene nombre: " + x.ContactName + " y vive en " + x.Country ));
        }
    }
}
