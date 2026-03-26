using Microsoft.EntityFrameworkCore;
using models_dto.Mapeamento.EntidadesMap;
using models_dto.Models.EntidadesPessoas;

public class BancoContext : DbContext
{
    public BancoContext(DbContextOptions<BancoContext> options) : base(options)
    {
    }

    public DbSet<ModelUsuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new UsuarioMap());
    }
}

