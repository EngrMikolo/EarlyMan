using Microsoft.AspNetCore.Mvc;
using Telefin.Models;

namespace Telefin.Controllers
{
    public class PrintController : Controller
    {
        private IPrintRepository repository;

        public PrintController(IPrintRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.Prints);

        public ViewResult ProductShowcase() => View(repository.Prints);

        public ViewResult ItemSummary() => View();
    }
}