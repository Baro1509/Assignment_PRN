using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntityModels;
using Microsoft.EntityFrameworkCore;


namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null ;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }return instance;
                }
            }
        }

        public Product Get(int productId)
        {
            Product product = null;
            try
            {
                using var context = new Ass02Context();
                product = context.Products.Include(c => c.Category ).Include(o => o.OrderDetails).SingleOrDefault(p=>p.ProductId == productId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public void Update(Product product)
        {
            if (product != null)
            {
                try
                {
                    Product _product = Get(product.ProductId);
                    if (_product != null)
                    {
                        _product = product;
                        using var context = new Ass02Context();
                        context.Products.Update(product);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Product does not exist!");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void Add(Product product)
        {
            try
            {
                Product _product = product;
                using var context = new Ass02Context();
                context.Products.Add(_product);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int productId)
        {
            try
            {
                Product _product = Get(productId);
                if (_product != null)
                {
                    using var context = new Ass02Context();
                    context.Products.Remove(_product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>(); 
            try 
            {
                using var context = new Ass02Context();
                products = context.Products.Include(c => c.Category).Include(o => o.OrderDetails).ToList();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }
    }
}
