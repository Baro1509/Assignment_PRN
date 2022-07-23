using BusinessObject.EntityModels;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrdersDetailsByOID(int orderId);
        public void Insert(OrderDetail orderDetail);
    }
}

