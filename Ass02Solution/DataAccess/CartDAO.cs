using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntityModels;

namespace DataAccess {
    public class CartDAO {
        private static CartDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CartDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new CartDAO();
                    }
                    return instance;
                }
            }
        }
        public CartDAO() { }

        public int AddOrder(Member member) {
            int id = 0;
            List<Order> list = OrderDAO.Instance.GetOrders();
            foreach (Order order in list) { 
                id = Math.Max(id, order.OrderId);
            }
            OrderDAO.Instance.Insert(new Order() {
                OrderId = id,
                MemberId = member.MemberId,
                OrderDate = DateTime.Now
            });
            return id;
        }

        public void AddOrderDetail(int orderID, Product product, double discount) {
            OrderDetailDAO.Instance.Insert(new OrderDetail() {
                OrderId = orderID,
                ProductId = product.ProductId,
                UnitPrice = product.UnitPrice,
                Quantity = product.UnitsInStock,
                Discount = discount
            });
        }
    }
}
