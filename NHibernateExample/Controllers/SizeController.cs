using NHibernateExample.Service.IService;
using NHibernateExample.ViewModel.SizeViewModel;
using System.Web.Mvc;

namespace NHibernateExample.Controllers
{
    public class SizeController : Controller
    {
        private readonly ISizeService _sizeService;

        public SizeController(ISizeService sizeService)
        {
            _sizeService = sizeService;
        }

        // GET: Size
        public ActionResult Index()
        {
            return View(_sizeService.GetSizesViewModel());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SizeCreateViewModel sizeCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(sizeCreateViewModel);
            }

            _sizeService.Add(sizeCreateViewModel);

            return RedirectToAction("Index");
        }
    }
}