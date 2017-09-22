using System;

namespace Domain.Entities
{
    public class ItemVenda
    {
        public Int32 ItemVendaId { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
        public string DescricaoProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoBruto { get; set; }
        public decimal PrecoLiquido { get; set; }
        public decimal PercentualDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
    }
}
