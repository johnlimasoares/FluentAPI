    using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class FornecedorMap : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMap()
        {
            ToTable("Fornecedor");
            HasKey(x => x.FornecedorId);
            HasRequired(p => p.Pessoa)
                //.WithRequiredDependent() -- Esta opção obriga persistir um fornecedor sempre que for persistir uma pessoa, gerando erro ao persistir um cliente, pois na persistencia de cliente é necessário persistir uma pessoa
                .WithOptional()
                .Map(m => m.MapKey("PessoaId"));

        }
    }
}
