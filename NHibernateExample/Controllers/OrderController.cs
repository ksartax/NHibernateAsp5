using NHibernateExample.Service.IService;
using NHibernateExample.ViewModel.OrderViewModel;
using System.Web.Mvc;

namespace NHibernateExample.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: Order
        public ActionResult Index()
        {
            return View(_orderService.GetOrdersViewModel());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(OrderCreateViewModel ordersCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(ordersCreateViewModel);
            }

            _orderService.Add(ordersCreateViewModel);

            return RedirectToAction("Index");
        }
    }
}