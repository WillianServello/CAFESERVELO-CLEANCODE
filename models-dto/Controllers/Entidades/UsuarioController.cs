using Microsoft.AspNetCore.Mvc;
using models_dto.ViewModel.EntidadesPessoasViewModel;

namespace models_dto.Controllers.Entidades
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            UsuarioViewModel userView = new UsuarioViewModel();
            return View(userView);
        }
    }
}
