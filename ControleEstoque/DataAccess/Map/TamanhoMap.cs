using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class TamanhoMap : EntityTypeConfiguration<Tamanho>
    {
        public TamanhoMap()
        {
            ToTable("Tamanho");
            HasKey(x => x.TamanhoId);
            Property(x => x.Descricao).HasMaxLength(2).IsRequired();

        }
    }
}
