using BusinessObject.EntityModels;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CartDAO
    {
        private static CartDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CartDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CartDAO();
                    }
                    return instance;
                }
            }
        }
        public CartDAO() { }

        public int AddOrder(Member member)
        {
            OrderDAO.Instance.Insert(new Order()
            {
                MemberId = member.MemberId,
                OrderDate = DateTime.Now
            });
            List<Order> list = OrderDAO.Instance.GetOrders();
            int id = list[list.Count - 1].OrderId;
            return id;
        }

        public void AddOrderDetail(int orderID, Product product, double discount)
        {
            ProductRepository productRepository = new ProductRepository();
            if (productRepository.GetProductByID(product.ProductId).UnitsInStock >= product.UnitsInStock)
            {
                OrderDetailDAO.Instance.Insert(new OrderDetail()
                {
                    OrderId = orderID,
                    ProductId = product.ProductId,
                    UnitPrice = product.UnitPrice,
                    Quantity = product.UnitsInStock,
                    Discount = discount
                });
                var newProduct = productRepository.GetProductByID(product.ProductId);
                newProduct.UnitsInStock = newProduct.UnitsInStock - product.UnitsInStock;
                productRepository.Update(newProduct);
            }
        }
    }
}
