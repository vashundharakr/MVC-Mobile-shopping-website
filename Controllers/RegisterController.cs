using MVC_MobileStockManagementApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVC_MobileStockManagementApplication.Controllers
{
    public class RegisterController : Controller
    {
        private static List<Register> register = new List<Register>();

        // View for the registration page

        public IActionResult Index()
        {
            return View(register);
        }
    }
}