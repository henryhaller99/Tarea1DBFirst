using System.Linq;
using API.DataAccess;

namespace API.Services
{

    public class CustomerSC : BaseSC
    {
       
        public IQueryable<Customer> GetCustomers()
        {
            return dbContext.Customers.Select(x => x);
        }

        public Customer GetCustomerById(string id)
        {
            return GetCustomers().Where(x => x.CustomerId == id).FirstOrDefault();
        }
    }


}