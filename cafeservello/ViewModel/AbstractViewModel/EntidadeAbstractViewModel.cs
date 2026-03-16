using System.ComponentModel.DataAnnotations;

namespace cafeservello.ViewModel.AbstractViewModel
{
    public abstract class EntidadeAbstractViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required(ErrorMessage = "Informe o nome.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome dever ter entre 3 a 50 caracteres!")]
        public string Nome { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; } = DateTime.UtcNow;
        public DateTime DataUpdateCadastro { get; set; } = DateTime.UtcNow;

        
    }
}
