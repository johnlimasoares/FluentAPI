using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class VendaMap : EntityTypeConfiguration<Venda>
    {
        public VendaMap()
        {
            ToTable("Venda");

            HasRequired(x => x.Produto)
               .WithMany()
               .Map(m => m.MapKey("ProdutoId"));
        }
       
    }
}
