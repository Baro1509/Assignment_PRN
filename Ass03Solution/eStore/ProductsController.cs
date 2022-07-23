using BusinessObject.EntityModels;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStore
{
    public class ProductsController : Controller
    {
        IProductRepository productRepository = null;
        public ProductsController() => productRepository = new ProductRepository();

        // GET: ProductsController
        public ActionResult Index()
        {
            var productList = productRepository.GetProducts();
            return View(productList);
        }
        
        public ActionResult UserIndex()
        {
            var productList = productRepository.GetProducts();
            return View(productList);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var product = productRepository.Get(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productRepository.Add(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(product);
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productRepository.Get(id.Value);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                if(id != product.ProductId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    productRepository.Update(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var product = productRepository.Get(id.Value);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                productRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: ProductsController/Buy/5
        public ActionResult Buy(int? id) {
            if (id == null) {
                return NotFound();
            }

            var product = productRepository.Get(id.Value);
            if (product == null) {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductsController/Buy/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Buy(int id, IFormCollection collection) {
            try {
                Product p = productRepository.Get(id);
                p.UnitsInStock -= 1;
                productRepository.Update(p);
                return RedirectToAction(nameof(UserIndex));
            } catch (Exception ex) {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
