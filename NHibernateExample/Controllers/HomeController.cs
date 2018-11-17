using NHibernateExample.Service.IService;
using NHibernateExample.ViewModel;
using System.Web.Mvc;

namespace NHibernateExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("{status}")]
        public ActionResult Index(string status)
        {
            return View(_userService.GetUsersViewModel(status));
        }

        public ActionResult About()
        {
            _userService.JoinTest();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult AddUser([Bind(Include = "FirstName, LastName, City")] UserCreateViewModel userCreateViewModel)
        {
            if (ModelState.IsValid)
            {
                _userService.Add(userCreateViewModel);

                return RedirectToAction("Index");
            }

            return View(userCreateViewModel);
        }
    }
}