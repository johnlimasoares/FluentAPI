using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class CorMap : EntityTypeConfiguration<Cor>
    {
        public CorMap()
        {
            ToTable("Cor");
            HasKey(x => x.CorId);
            Property(x => x.Descricao).HasMaxLength(50).IsRequired();
        }

    }
}
