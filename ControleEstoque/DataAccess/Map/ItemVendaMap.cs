using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class ItemVendaMap : EntityTypeConfiguration<ItemVenda>
    {
        public ItemVendaMap()
        {
            ToTable("ItemVenda");

            HasRequired(x => x.Produto)
                .WithMany()
                .Map(x => x.MapKey("ProdutoId"));

            HasRequired(x => x.Venda)
                .WithMany(x => x.ItemList)
                .Map(x => x.MapKey("VendaId"));

            Property(x => x.DescricaoProduto)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
