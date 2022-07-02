using BusinessObject.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;
public class ProductDAO
{
    private static ProductDAO instance = null;
    private static readonly object instanceLock = new object();
    private ProductDAO()
    {
    }

    public static ProductDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }
    }

    //-------------------------------------------------------------------

    public void Insert(Product product)
    {
        try
        {
            using Ass02Context context = new Ass02Context();
            context.Products.Add(product);
            context.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in ProductDAO Insert: " + ex.Message);
            throw new Exception(ex.Message);
        }
    }

    //-------------------------------------------------------------------

    public List<Product> GetAllProducts()
    {
        List<Product> products = null;
        try
        {
            using Ass02Context context = new Ass02Context();
            products = context.Products.ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in ProductDAO GetAllProducts: " + ex.Message);
            throw new Exception(ex.Message);
        }
        return products;
    }

    //-------------------------------------------------------------------

    public List<Product> GetProducts(string productName)
    {
        List<Product> products = null;
        try
        {
            using Ass02Context context = new Ass02Context();
            products = context.Products.SelectMany(context.Products.);
        }
    }
}
