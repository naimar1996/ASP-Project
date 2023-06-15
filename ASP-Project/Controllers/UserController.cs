using Microsoft.AspNetCore.Mvc;

namespace ASP_Project.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Naim";
            ViewData["Surname"] = "Rahimov";
            ViewData["Age"] = 27;
            ViewData["Country"] = "Azerbaijan";
            ViewData["PhoneNumber"] = "+994000000000";

            ViewData["Name1"] = "Fateh";
            ViewData["Surname1"] = "Huseynli";
            ViewData["Age1"] = 24;
            ViewData["Country1"] = "Azerbaijan";
            ViewData["PhoneNumber1"] = "+994000000000";

            ViewData["Name2"] = "Leyla";
            ViewData["Surname2"] = "Isgenderova";
            ViewData["Age2"] = 32;
            ViewData["Country2"] = "Azerbaijan";
            ViewData["PhoneNumber2"] = "+994000000000";

            return View();
        }
    }
}
