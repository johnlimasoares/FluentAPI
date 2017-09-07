using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap() {
            ToTable("Endereco");
            HasKey(x => x.EnderecoId);
            Property(x => x.Logradouro).HasMaxLength(100).IsRequired();
            Property(x => x.Numero).HasMaxLength(15).IsRequired();
            Property(x => x.TipoEndereco).HasMaxLength(20).IsRequired();

            HasRequired(x => x.Pessoa)
               .WithMany()
               .Map(m => m.MapKey("PessoaId"));

            HasRequired(x => x.Cidade)
               .WithMany()
               .Map(m => m.MapKey("CidadeId"));
        }
    }
}
