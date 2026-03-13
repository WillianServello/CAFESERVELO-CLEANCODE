using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models_dto.Models.EntidadesPessoas;

namespace models_dto.Mapeamento.EntidadesMap
{
    public sealed class UsuarioMap : IEntityTypeConfiguration<ModelUsuario>
    {
        public void Configure(EntityTypeBuilder<ModelUsuario> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder
                .Property(x => x.Nome)
                .HasColumnName("Name")
                .HasMaxLength(100)
                .IsRequired(); 

            builder
                .Property(x => x.Email)
                .HasColumnName("Email")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.Login)
                .HasColumnName("Login")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.Senha)
                .HasColumnName("Senha")
                .HasMaxLength (100)
                .IsRequired();

            builder
                .Property(x => x.ImagemUrl)
                .HasColumnName("Imagem")
                .HasMaxLength (100)
                .IsRequired();

            builder
                .Property(x => x.DataCadastro)
                .HasColumnName("DataCadastro")
                .IsRequired();

            builder
                .Property(x => x.DataUpdateCadastro)
                .HasColumnName("DataAtualizacao")
                .HasMaxLength (100)
                .IsRequired();
        }
    }
}
