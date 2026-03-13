using Microsoft.AspNetCore.Mvc;

namespace models_dto.Controllers.Entidades
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
