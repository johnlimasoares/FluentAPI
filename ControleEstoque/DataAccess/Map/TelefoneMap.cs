using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class TelefoneMap : EntityTypeConfiguration<Telefone>
    {
        public TelefoneMap()
        {
            ToTable("Telefone");
            HasKey(x => x.TelefoneId);
            Property(x => x.Numero).HasMaxLength(12).IsRequired();
            Property(x => x.TipoFone).HasMaxLength(20).IsRequired();
            
            HasRequired(x => x.Pessoa)
                .WithMany()
               //.WithRequiredPrincipal() essa opção criaria uma fk telefoneId na tabela Pessoa 
               //.WithRequiredDependent() essa opção criaria uma fk pessoaId na tabela Telefone 1=1
               .Map(m => m.MapKey("PessoaId"));
        }

    }
}
