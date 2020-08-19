using Microsoft.AspNetCore.Mvc;
using Telefin.Models;
using Telefin.Models.ViewModels;

namespace Telefin.Controllers
{
    public class HomeController : Controller
    {
        private IPrintRepository printRepo;
        private IPromotionRepository promoRepo;
        private HomepageViewModel homePageVM;

        public HomeController(IPrintRepository print, IPromotionRepository promo)
        {
            printRepo = print;
            promoRepo = promo;
            homePageVM = new HomepageViewModel
            {
                printRepository = printRepo,
                promotionRepository = promoRepo
            };
        }

        public ViewResult Index() => View(homePageVM);

        public ViewResult ProductShowcase() => View(homePageVM);

        public ViewResult ItemSummary() => View();
    }
}