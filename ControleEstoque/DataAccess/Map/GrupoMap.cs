using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class GrupoMap : EntityTypeConfiguration<Grupo>
    {
        public GrupoMap()
        {
            ToTable("Grupo");
            HasKey(x => x.GrupoId);
            Property(x => x.Descricao).HasMaxLength(50).IsRequired();
        }

    }
}
