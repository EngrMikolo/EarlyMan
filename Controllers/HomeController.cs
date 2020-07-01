using Microsoft.AspNetCore.Mvc;
using Telefin.Models;

namespace Telefin.Controllers
{
    public class HomeController: Controller
    {
       public ActionResult Index()
        {
            return View();
        }

    }
}
