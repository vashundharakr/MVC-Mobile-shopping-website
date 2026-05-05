using MVC_MobileStockManagementApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVC_MobileStockManagementApplication.Controllers
{
    public class AdminHandlerController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private static List<AdminLogin> logins = new List<AdminLogin>();

        public AdminHandlerController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //Delete the mobiledetails that display to user

        [HttpPost]
        public async Task<IActionResult> Delete(string mobileName)
        {
            if (string.IsNullOrWhiteSpace(mobileName))
            {
                ViewBag.Error = "Mobile name cannot be empty.";
                return RedirectToAction(nameof(Index));
            }
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("http://localhost:5122/api/");

            try
            {
                var response = await client.DeleteAsync($"Purchase/remove/{mobileName}");

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index)); // Redirect to the mobile list after successful deletion
                }
                else
                {
                    ViewBag.Error = "Failed to delete the mobile.";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"An error occurred: {ex.Message}";
                return RedirectToAction(nameof(Index));
            }
        }


        public IActionResult Index()
        {
            return View();
        }

    }
}



