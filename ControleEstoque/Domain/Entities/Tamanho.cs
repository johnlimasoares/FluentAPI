using System;

namespace Domain.Entities
{
    public class Tamanho : IEntity
    {
        public int TamanhoId { get; set; }
        public string Descricao { get; set; }

        public string GetDescricao()
        {
            return Descricao;
        }

        public int GetId()
        {
            return TamanhoId;
        }
    }
}
