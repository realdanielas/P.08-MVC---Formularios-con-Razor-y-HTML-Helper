using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace P._08_MVC___Formularios_con_Razor_y_HTML_Helper.Controllers
{
    public class vistasRazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HTML_Helper()
        {
            return View();
        }
    }
}
