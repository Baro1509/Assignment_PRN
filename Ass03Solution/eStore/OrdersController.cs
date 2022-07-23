using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eStore
{
    public class OrdersController : Controller
    {
        readonly IOrderRepository orderRepository = new OrderRepository();
        readonly IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public OrdersController()
        {
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();
        }
        // GET: OrdersController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrdersController/Details/5
        public ActionResult Details(int id)
        {
            var detail = orderDetailRepository.GetOrdersDetailsByOID(id);
            return View(detail);
        }
        // GET: OrdersController/Details/5
        public ActionResult DetailsMem(int id)
        {
            var detail = orderDetailRepository.GetOrdersDetailsByOID(id);
            return View(detail);
        }

        // GET: OrdersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdersController/Edit/5
        public ActionResult Edit(int id)
        {

            return View();
        }

        // POST: OrdersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: OrdersContelete/5
        public ActionResult List()
        {
            int? roleId = HttpContext.Session.GetInt32("LoginMemberRoleId");
            int? memberId = HttpContext.Session.GetInt32("LoginMemberId");
            var orders = orderRepository.GetOrders();

            if (roleId != null && roleId == 2 && memberId != null)
            {

                return RedirectToAction(nameof(ListMem));
            }
            return View(orders);
        }
        // GET: OrdersContelete/5
        public ActionResult ListMem()
        {

            int? memberId = HttpContext.Session.GetInt32("LoginMemberId");

            var orders = orderRepository.GetOrdersMember(memberId.Value);

            return View(orders);
        }

    }
}
