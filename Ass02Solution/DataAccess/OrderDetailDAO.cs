using BusinessObject.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
    }

}
