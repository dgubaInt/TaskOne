using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskOne.Models;
using TaskOne.Repositories.Interfaces;
using TaskOne.ViewModels;

namespace TaskOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserDataRepository _userDataRepository;

        public HomeController(ILogger<HomeController> logger, IUserDataRepository userDataRepository)
        {
            _logger = logger;
            _userDataRepository = userDataRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                await _userDataRepository.RegisterData(userViewModel);
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Stats()
        {
            var requestResult = await _userDataRepository.GetStats();
            return View(requestResult);
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