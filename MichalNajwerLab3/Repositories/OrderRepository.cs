using MichalNajwerLab3.Models;
using Microsoft.EntityFrameworkCore;

namespace MichalNajwerLab3.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private DatabaseContext context;

        public OrderRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public List<Order> GetAllOrders()
        {
            var AllOrders = context.Orders.ToList();

            return AllOrders;
        }

        public Order GetOrder(Guid id)
        {
            var order = context.Orders.Where(x => x.Id == id).Include(x => x.OrderPizzas).ThenInclude(e => e.Pizza).FirstOrDefault();
            return order;

        }

        public void SaveOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }










    }
}
