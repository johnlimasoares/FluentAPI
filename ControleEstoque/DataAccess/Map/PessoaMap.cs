using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            ToTable("Pessoa");
            HasKey(x => x.PessoaId);
            Property(x => x.NomeRazao).HasMaxLength(50).IsRequired();
            Property(x => x.ApelidoFantasia).HasMaxLength(50).IsRequired();
            Property(x => x.CpfCnpj).HasMaxLength(14).IsRequired();
            Property(x => x.RgIe).HasMaxLength(20).IsRequired();
            Property(x => x.TipoPessoa).HasMaxLength(1).IsRequired();

            
                
        }
    }
}
