using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_MobileStockManagementApplication.Models;

namespace MVC_MobileStockManagementApplication.Controllers;

//Default controller
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //HomeControllers view is set in index and logger is included

    public IActionResult Index()
    {
        _logger.LogInformation("login done and home page loaded");
        ViewBag.List = "ViewBAg title";
        return View();
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
