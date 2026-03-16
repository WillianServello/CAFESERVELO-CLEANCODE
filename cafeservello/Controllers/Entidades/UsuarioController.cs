using cafeservello.ViewModel.EntidadesPessoasViewModel;
using Microsoft.AspNetCore.Mvc;


namespace cafeservello.Controllers.Entidades
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
