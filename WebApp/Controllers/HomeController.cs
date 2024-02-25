using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from action method";
        }

        public string Error()
        {
            return "opps, something went wrong";
        }
    }
}
