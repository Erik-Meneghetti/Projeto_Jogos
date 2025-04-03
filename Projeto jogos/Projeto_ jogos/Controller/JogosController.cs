using Microsoft.AspNetCore.Mvc;

namespace Projeto__jogos.Controller
{
    public class JogosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
