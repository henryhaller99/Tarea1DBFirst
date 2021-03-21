using System.Linq;
using API.DataAccess;

namespace API.Services
{
    public class OrderSC : BaseSC
    {
        public Order GetOrder(int id)
        {
            return GetOrders().Where(x => x.OrderId == id).FirstOrDefault();
        }

        public IQueryable<Order> GetOrders()
        {
            return dbContext.Orders.Select(x => x);
        }
    }
}