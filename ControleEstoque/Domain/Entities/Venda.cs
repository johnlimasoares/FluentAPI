using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Venda
    {
        public int VendaId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataHoraVenda { get; set; }
        public decimal ValorTotalBruto { get; set; }
        public decimal ValorTotalLiquido { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal PercentualDesconto { get; set; }
        public ICollection<ItemVenda> ItemList { get; set; }
    }
}
