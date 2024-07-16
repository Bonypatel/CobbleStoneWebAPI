using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CobbleStoneWebAPI.Models;
using CobbleStoneWebAPI.Controllers;
using System.Threading;

namespace CobbleStoneWebAPI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> LoadUsers()
    {
        var userController = new UserController();
        List<User> users = await userController.GetUsers();

        return View("User", users);
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
