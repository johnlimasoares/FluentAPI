using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(x => x.ClienteId);
            HasRequired(p => p.Pessoa)
                .WithOptional()
                .Map(m => m.MapKey("PessoaId"));

        }
    }
}
