using System;

namespace Domain.Entities
{
    public class Cidade : IEntity
    {
        public int CidadeId { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public string GetDescricao()
        {
            return Nome;
        }

        public int GetId()
        {
            return CidadeId;
        }
    }
}
