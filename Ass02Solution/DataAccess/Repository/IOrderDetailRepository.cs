using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntityModels;
namespace DataAccess.Repository {
    public interface IOrderDetailRepository {
        List<OrderDetail> GetOrdersDetailsByOID(int orderId);
    }
}
