using BusinessObject.EntityModels;
namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order>? GetOrders() => OrderDAO.Instance.GetOrders();
        public List<Order>? GetOrdersBydate(DateTime start, DateTime end) => OrderDAO.Instance.GetOrdersBydate(start, end);
        public List<Order>? GetOrdersMember(int memberID) => OrderDAO.Instance.GetOrdersMember(memberID);
        public List<Order>? GetOrdersBydateMember(DateTime start, DateTime end, int memberID) => OrderDAO.Instance.GetOrdersBydateMember(start, end, memberID);
        public void Insert(Order order) => OrderDAO.Instance.Insert(order);
    }
}
