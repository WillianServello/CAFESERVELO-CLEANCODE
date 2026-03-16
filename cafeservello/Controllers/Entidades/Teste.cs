using Microsoft.AspNetCore.Mvc;

namespace models_dto.Controllers.Entidades
{
    public class Teste : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
