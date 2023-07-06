using Microsoft.AspNetCore.Mvc;
using Task02.Models;

namespace Task02.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CookieDataModel data)
        {
            if (ModelState.IsValid)
            {
                var options = new CookieOptions
                {
                    Expires = data.ExpirationDate
                };
                Response.Cookies.Append("Value", data.Value, options);
                return RedirectToAction("Check");
            }
            return View(data);
        }

        public IActionResult Check()
        {
            var value = Request.Cookies["Value"];
            return View("Check", value);
        }
    }

}
