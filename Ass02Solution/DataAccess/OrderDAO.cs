﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace DataAccess {
    public class OrderDAO {
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
        public OrderDAO() { }
        public List<Order> GetOrders()
        {
            List<Order> orders;
            try
            {
                Ass02Context context = new Ass02Context();
                orders = context.Orders.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        public List<Order> GetOrdersBydate(DateTime starDate,DateTime endDate)
        {
            List<Order> orders;
            try {
                Ass02Context context = new Ass02Context();
                orders=context.Orders.Where(Order => Order.OrderDate >= starDate && Order.OrderDate<=endDate).ToList();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        //MemberRole
        public List<Order> GetOrdersMember(int memberID)
        {
            List<Order> orders;
            try
            {
                Ass02Context context = new Ass02Context();
                orders = context.Orders.Where(Order=>Order.MemberId.Equals(memberID)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        public List<Order> GetOrdersBydateMember(DateTime starDate, DateTime endDate,int memberID)
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

    }
}
