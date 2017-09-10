using System;

namespace Domain.Entities
{
    public class Cliente : IEntity
    {
        public int ClienteId { get; set; }
        public Pessoa Pessoa { get; set; }
                 
        public string GetDescricao()
        {
            return Pessoa.NomeRazao;
        }

        public int GetId()
        {
            return ClienteId;
        }
    }
}
