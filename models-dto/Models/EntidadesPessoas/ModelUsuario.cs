using Microsoft.AspNetCore.Identity.Data;
using models_dto.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace models_dto.Models.EntidadesPessoas
{
    public class ModelUsuario : EntitidadeAbstract
    {
        public string Login { get; private set; } = string.Empty;
        public string Senha { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string? ImagemUrl { get; private set; }
    }
}
