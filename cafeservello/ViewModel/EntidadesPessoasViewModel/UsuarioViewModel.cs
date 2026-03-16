using cafeservello.ViewModel.AbstractViewModel;
using Microsoft.AspNetCore.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace cafeservello.ViewModel.EntidadesPessoasViewModel
{
    public class UsuarioViewModel : EntidadeAbstractViewModel
    {


        [Required(ErrorMessage = "Infome o login.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome dever ter entre 3 a 50 caracteres!")]
        public string Login { get; set; } = "Willian";

        [Required(ErrorMessage = "Infome a senha.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6)]
        public string Senha { get; set; } = string.Empty;

        [Required(ErrorMessage = "Infome o Email.")]
        [EmailAddress(ErrorMessage ="Informe um email válido!")]
        public string Email { get; set; } = string.Empty;
        public IFormFile? Imagem { get; set; }

        

    }
}
