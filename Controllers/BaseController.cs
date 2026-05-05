using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MVC_MobileStockManagementApplication.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Check if the user is logged in
            if (context.HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                // Redirect to the login page if not logged in
                context.Result = new RedirectToActionResult("Login", "Account", null);
            }

            base.OnActionExecuting(context);
        }
    }
}