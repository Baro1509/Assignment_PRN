using BusinessObject.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Order> GetOrders()
        {
            List<Order> orders;
            try
            {
                using Ass02Context context = new Ass02Context();
                orders = context.Orders.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        public List<Order> GetOrdersMember(int memberID)
        {
            List<Order> orders;
            try
            {
                Ass02Context context = new Ass02Context();
                orders = context.Orders.Where(Order => Order.MemberId.Equals(memberID)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        public List<Order> GetOrdersBydate(DateTime starDate, DateTime endDate)
        {
            List<Order> orders;
            try
            {
                Ass02Context context = new Ass02Context();
                orders = context.Orders.Where(Order => Order.OrderDate >= starDate && Order.OrderDate <= endDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        public List<Order> GetOrdersBydateMember(DateTime starDate, DateTime endDate, int memberID)
        {
            List<Order> orders;
            try
            {
                Ass02Context context = new Ass02Context();
                orders = context.Orders.Where(
                    Order => Order.OrderDate >= starDate && Order.OrderDate <= endDate && Order.MemberId.Equals(memberID))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        public void Insert(Order order)
        {
            try
            {
                using Ass02Context context = new Ass02Context();
                context.Orders.Add(order);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error in OrderDao Insert: " + ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public int GetOrderId(int memberId, DateTime date) {
            int id = 0;
            try {
                Order order;
                using Ass02Context context = new Ass02Context();
                order = context.Orders.Include(c => c.Member).Include(c => c.OrderDetails).SingleOrDefault(p => (p.Member.MemberId == memberId && p.OrderDate == date));
                id = order.OrderId;
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine("Error in OrderDao get order id: " + ex.Message);
                throw new Exception(ex.Message);
            }
            return id;
        }
    }
}
