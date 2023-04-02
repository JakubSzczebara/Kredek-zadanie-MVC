using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Models;
using SklepInternetowy.Repositories;
using System.Diagnostics;

namespace SklepInternetowy.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemsRepository _ItemsRepository;
        public HomeController(IItemsRepository itemsRepository)
        {
            _ItemsRepository = itemsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shop()
        {
            var items=_ItemsRepository.getAll();
            return View(items);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}