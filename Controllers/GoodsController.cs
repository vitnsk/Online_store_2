using Microsoft.AspNetCore.Mvc;

namespace Online_store_2.Controllers
{
    public class GoodsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
