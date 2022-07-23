using BusinessObject.EntityModels;
namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public List<OrderDetail> GetOrdersDetailsByOID(int orderId) => OrderDetailDAO.Instance.GetOrdersDetailsByOID(orderId);
        public void Insert(OrderDetail orderDetail) => OrderDetailDAO.Instance.Insert(orderDetail);
    }
}
