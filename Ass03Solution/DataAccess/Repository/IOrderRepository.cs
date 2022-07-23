using BusinessObject.EntityModels;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        List<Order> GetOrdersBydate(DateTime startDate, DateTime endDate);
        List<Order> GetOrdersMember(int memberID);
        List<Order> GetOrdersBydateMember(DateTime startDate, DateTime endDate, int memberID);
        public void Insert(Order order);
        public int GetOrderId(int memberId, DateTime date);
    }
}

