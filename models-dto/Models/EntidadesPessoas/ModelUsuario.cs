using Microsoft.AspNetCore.Identity.Data;
using models_dto.Models.Abstract;

namespace models_dto.Models.EntidadesPessoas
{
    public class ModelUsuario : EntitidadeAbstract
    {
        public string login { get; private set; } = string.Empty;
        public string senha { get; private set; } = string.Empty; 
        public string? ImagemUrl { get; private set; }
    }
}
