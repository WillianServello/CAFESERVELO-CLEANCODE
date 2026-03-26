using models_dto.Models.EntidadesPessoas;

namespace models_dto.Repositorio.UsuarioRepositorio
{
    public interface IUsuarioRepositorio
    {
        Task<ModelUsuario> GetById(Guid id);
        Task<List<ModelUsuario>> GetUser();
        Task<ModelUsuario> AddUser(ModelUsuario modelUsuario);
        Task<ModelUsuario> UpdateUser(ModelUsuario modelUsuario);
    }
}
