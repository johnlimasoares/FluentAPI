using System;

namespace Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public string CodigoProduto { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }        
        public string Localizacao { get; set; }
        public string Observacao { get; set; }
        public int EstoqueAtual { get; set; }
        public bool IsInativo { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
        public Tamanho Tamanho { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Marca Marca { get; set; }
        public Grupo Grupo { get; set; }
        public Cor Cor { get; set; }
    }
}
