using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            /*O método ToTable define qual o nome que será dado a tabela no banco de dados*/
            ToTable("Produto");

            //Definimos a propriedade ProdutoId como chave primária
            HasKey(x => x.ProdutoId);
            
            //Descricao terá no máximo 150 caracteres e será um campo "NOT NULL"
            Property(x => x.Descricao).HasMaxLength(100).IsRequired();
            Property(x => x.Localizacao).HasMaxLength(50);
            Property(x => x.CodigoProduto).HasMaxLength(50).IsRequired();
            Property(x => x.PrecoCompra).HasPrecision(12, 4);
            Property(x => x.PrecoVenda).HasPrecision(12, 4);

            /*Na entidade Produto, a propriedade do tipo Grupo é obrigatória*/
            HasRequired(x => x.Grupo)
               .WithMany() //Grupo pode ter muitos Produtos
               .Map(m => m.MapKey("GrupoId"));//a chave estrangeira em Produto é GrupoId

            /*Na entidade Produto a propriedade do tipo Marca é requerida*/
            HasRequired(x => x.Marca)
               .WithMany() //a classe Marca pode ter uma lista de Produtos
               .Map(m => m.MapKey("MarcaId"));//a chave estrangeira é MarcaId

            HasRequired(x => x.Fornecedor)
              .WithMany()
              .Map(m => m.MapKey("FornecedorId"));

            HasRequired(x => x.Tamanho)
              .WithMany()
              .Map(m => m.MapKey("TamanhoId"));

            HasRequired(x => x.Cor)
                .WithMany()
                .Map(m => m.MapKey("CorId"));
        }
    }
}
