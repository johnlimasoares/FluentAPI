using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap(){
            ToTable("Cidade");
            HasKey(x => x.CidadeId);
            Property(x => x.Nome).HasMaxLength(50).IsRequired();
        }

    }
}
