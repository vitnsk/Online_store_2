using Microsoft.AspNetCore.Mvc;
using Online_store_2.Models;

namespace Online_store_2.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if(ModelState.IsValid) {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
