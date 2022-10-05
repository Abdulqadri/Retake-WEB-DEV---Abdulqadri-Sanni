using Microsoft.AspNetCore.Mvc;

namespace E_Wallet.Controllers
{
    public class Customer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
