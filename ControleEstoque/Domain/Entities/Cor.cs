namespace Domain.Entities
{
    public class Cor : IEntity
    {
        public int CorId { get; set; }
        public string Descricao { get; set; }

        public string GetDescricao()
        {
            return Descricao;
        }

        public int GetId()
        {
            return CorId;
        }
    }
}
