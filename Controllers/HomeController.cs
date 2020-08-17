using Microsoft.AspNetCore.Mvc;
using Telefin.Models;

namespace Telefin.Controllers
{
    public class HomeController : Controller
    {
        private IPromotionRepository promotionRepository;
        private IPrintRepository printRepository;

        public HomeController(IPrintRepository printRepo, IPromotionRepository promoRepo)
        {
            printRepository = printRepo;
            promotionRepository = promoRepo;
        }

        public ViewResult Index() => View(promotionRepository.Promos);

        public ViewResult ProductShowcase() => View(printRepository.Prints);

        public ViewResult ItemSummary() => View();
    }
}