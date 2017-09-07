using System;

namespace Domain.Entities
{
    public class Venda
    {
        public int VendaId { get; set; }
        public DateTime DataSaida { get; set; }
        public virtual Produto Produto { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Quantidade { get; set; }

    }
}
