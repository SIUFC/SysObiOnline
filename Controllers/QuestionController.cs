using Microsoft.AspNetCore.Mvc;

namespace SysObiOnline.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
