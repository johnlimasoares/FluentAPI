using System;

namespace Domain.Entities
{
    public class Marca : IEntity
    {
        public int MarcaId { get; set; }
        public string Descricao { get; set; }

        public string GetDescricao()
        {
            return Descricao;
        }

        public int GetId()
        {
            return MarcaId;
        }
    }
}
