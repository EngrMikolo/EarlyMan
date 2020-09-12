using Microsoft.AspNetCore.Mvc;

namespace Telefin.Controllers
{
    public class UserController : Controller
    {
        public ViewResult CreateAccount() => View("Create");

        [HttpPost]
        public ActionResult Create() => RedirectToAction("Index", "Home");

        public ViewResult SignIn() => View();
    }
}