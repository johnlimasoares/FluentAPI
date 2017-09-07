using Domain.Entities;

namespace Domain.DTO
{
    public class TelefoneDTO
    {
        public int TelefoneId { get; set; }
        public string Numero { get; set; }
        public string TipoFone { get; set; }
        public Pessoa Pessoa { get; set; }
        public bool IsPersisted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
