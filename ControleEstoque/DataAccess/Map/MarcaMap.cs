using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class MarcaMap : EntityTypeConfiguration<Marca>
    {
        public MarcaMap()
        {
            ToTable("Marca");
            HasKey(x => x.MarcaId);
            Property(x => x.Descricao).HasMaxLength(50).IsRequired();
        }
    }
}
