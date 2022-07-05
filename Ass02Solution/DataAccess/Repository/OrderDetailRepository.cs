using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntityModels;
namespace DataAccess.Repository {
    public class OrderDetailRepository : IOrderDetailRepository{
        public List<OrderDetail> GetOrdersDetailsByOID(int orderId) => OrderDetailDAO.Instance.GetOrdersDetailsByOID(orderId);
    }
}
