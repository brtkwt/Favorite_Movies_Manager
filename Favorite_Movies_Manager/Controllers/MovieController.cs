using Microsoft.AspNetCore.Mvc;

namespace Favorite_Movies_Manager.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
