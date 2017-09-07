using System;

namespace Domain.Entities
{
    public class Fornecedor : IEntity
    {
        public int FornecedorId { get; set; }
        public Pessoa Pessoa { get; set; }
        public Fornecedor()
        {
            this.Pessoa = new Pessoa();
        }
               
        public string GetDescricao()
        {
            return Pessoa.NomeRazao;
        }

        public int GetId()
        {
            return FornecedorId;
        }
    }
}
