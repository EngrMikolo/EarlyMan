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

        public ViewResult Index()
        {
            return View(repository.Prints);
        }
    }
}