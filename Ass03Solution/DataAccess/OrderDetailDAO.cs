using BusinessObject.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        public OrderDetailDAO() { }

        public List<OrderDetail> GetOrderDetails()
        {
            List<OrderDetail> list;
            try
            {
                Ass02Context context = new Ass02Context();
                list = context.OrderDetails.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public List<OrderDetail> GetOrdersDetailsByOID(int OrderID)
        {
            List<OrderDetail> orderDetails;
            try
            {
                Ass02Context context = new Ass02Context();
                orderDetails = context.OrderDetails.Where(OrderDetail => OrderDetail.OrderId.Equals(OrderID)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }
        public void Insert(OrderDetail orderDetail)
        {
            try
            {
                using Ass02Context context = new Ass02Context();
                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error in OrderDetailDAO Insert: " + ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public OrderDetail GetOrderDetail(int orderId, int productId) {
            OrderDetail orderDetail = null;
            try {
                Ass02Context context = new Ass02Context();
                orderDetail = context.OrderDetails.Include(p => p.Order).Include(p => p.Product).SingleOrDefault(o => (o.OrderId == orderId && o.ProductId == productId));

            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return orderDetail;
        }

        public void Update(OrderDetail detail) {
            if (detail != null) {
                try {
                    OrderDetail d = GetOrderDetail(detail.OrderId, detail.ProductId);
                    if (d != null) {
                        d = detail;
                        using var context = new Ass02Context();
                        context.OrderDetails.Update(detail);
                        context.SaveChanges();
                    } else {
                        throw new Exception("Order detail does not exist!");
                    }
                } catch (Exception ex) {
                    throw new Exception(ex.Message);
                }
            }
        }
    }

}