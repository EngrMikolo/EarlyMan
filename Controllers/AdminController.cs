using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Telefin.Models;

namespace Telefin.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<AppUser> userManager;

        public AdminController(UserManager<AppUser> usrMgr)
        {
            userManager = usrMgr;
        }

        public ViewResult Index() => View(userManager.Users);

        public ViewResult Login() => View();
    }
}