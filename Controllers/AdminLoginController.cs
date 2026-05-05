using MVC_MobileStockManagementApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVC_MobileStockManagementApplication.Controllers
{
    public class AdminLoginController : Controller
    {
        private static List<AdminLogin> logins = new List<AdminLogin>();

        public IActionResult Index()
        {
            return View();
        }
    }

}