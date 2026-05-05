using Microsoft.AspNetCore.Mvc;
using MVC_MobileStockManagementApplication.Models;

namespace MVC_MobileStockManagementApplication.Controllers
{
    public class PurchaseController : Controller
    {
        private static List<Purchase> purchases = new List<Purchase>();

        //Table detail of mobiles which can be edited easily
        public IActionResult Index()
        {
            return View(purchases);
        }

        //Mobile can be buyed and the receipt is generated here
        public IActionResult Buy()
        {
            return View();
        }

        //Purchase page Method

        public IActionResult Views()
        {
            return View();
        }

        //Slide show of the mobile

        public IActionResult Display()
        {
            return View();
        }

    }
}