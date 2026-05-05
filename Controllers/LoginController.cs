using MVC_MobileStockManagementApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVC_MobileStockManagementApplication.Controllers
{
    public class LoginController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<Login> _logger;
        private static List<AdminLogin> logins = new List<AdminLogin>();


        public IActionResult index()
        {
            return View();
        }
    }

}