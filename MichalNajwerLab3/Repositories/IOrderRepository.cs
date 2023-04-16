using MichalNajwerLab3.Models;

namespace MichalNajwerLab3.Repositories
{
    public interface IOrderRepository
    {


        public Order GetOrder(Guid id);
        public void SaveOrder(Order order);

        public List<Order> GetAllOrders();

    }
}
