using Microsoft.AspNetCore.Mvc;

namespace MonsterReviewApp.Controllers
{
    public class MonsterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
