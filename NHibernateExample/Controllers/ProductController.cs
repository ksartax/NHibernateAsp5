using NHibernateExample.Service.IService;
using NHibernateExample.Service.IService.Helper;
using NHibernateExample.ViewModel.ProductViewModel;
using System.Web.Mvc;
using Unity.Attributes;

namespace NHibernateExample.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISelectList _sizeSelectList;

        public ProductController(IProductService productService, [Dependency("Size")]ISelectList selectList)
        {
            _productService = productService;
            _sizeSelectList = selectList;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(_productService.GetProductsViewModel());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewData["Sizes"] = _sizeSelectList.GetSelectList();

            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductCreateViewModel productCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Sizes"] = _sizeSelectList.GetSelectList();

                return View(productCreateViewModel);
            }

            _productService.Add(productCreateViewModel);

            return RedirectToAction("Index");
        }
    }
}