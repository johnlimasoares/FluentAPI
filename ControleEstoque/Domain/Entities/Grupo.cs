using System;

namespace Domain.Entities
{
    public class Grupo : IEntity
    {
        public int GrupoId { get; set; }
        public string Descricao { get; set; }

        public string GetDescricao()
        {
            return Descricao;
        }

        public int GetId()
        {
            return GrupoId;
        }
    }
}
