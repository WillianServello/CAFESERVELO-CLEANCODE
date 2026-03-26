using Microsoft.EntityFrameworkCore;
using models_dto.Models.EntidadesPessoas;


namespace models_dto.Repositorio.UsuarioRepositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext? _bancoContext;
        public UsuarioRepositorio(BancoContext? bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Task<ModelUsuario> AddUser(ModelUsuario modelUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<ModelUsuario> GetById(Guid id)
        {
            if (_bancoContext == null)
                throw new ArgumentNullException("Houve um problema com o servidor");

            return await _bancoContext.Usuarios
                .FirstOrDefaultAsync(x => x.Id == id && x.IsActive == true) 
                ?? throw new ArgumentException("Houve um problema com o servidor");
        }

        public async Task<List<ModelUsuario>> GetUser()
        {
            if (_bancoContext == null)
                throw new Exception("Houve um problema com o servidor");

            return await _bancoContext.Usuarios.Where(x => x.IsActive == true).ToListAsync();
        }

        public Task<ModelUsuario> UpdateUser(ModelUsuario modelUsuario)
        {
            throw new NotImplementedException();
        }

    }
}
