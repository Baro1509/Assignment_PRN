using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace DataAccess {
    public class OrderDetailDAO {
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
        public List<OrderDetail> GetOrdersDetailsByOID(int OrderID)
        {
            List<OrderDetail> orderDetails;
            try
            {
                Ass02Context context = new Ass02Context();
                orderDetails = context.OrderDetails.Where(OrderDetail=> OrderDetail.OrderId.Equals(OrderID)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }
    }
}
