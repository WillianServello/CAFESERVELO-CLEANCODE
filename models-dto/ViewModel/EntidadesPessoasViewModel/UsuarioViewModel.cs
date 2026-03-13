using models_dto.ViewModel.AbstractViewModel;
using System.ComponentModel.DataAnnotations;

namespace models_dto.ViewModel.EntidadesPessoasViewModel
{
    public class UsuarioViewModel : EntidadeAbstractViewModel
    {
        [Required(ErrorMessage = "Infome o login.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome dever ter entre 3 a 50 caracteres!")]
        public string login { get; set; } = string.Empty;

        [Required(ErrorMessage = "Infome a senha.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6)]
        public string senha { get; set; } = string.Empty;
        public IFormFile? Imagem { get; set; }
    }
}
