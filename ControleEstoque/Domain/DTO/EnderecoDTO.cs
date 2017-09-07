
using Domain.Entities;

namespace Domain.DTO
{
    public class EnderecoDTO
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public Pessoa Pessoa { get; set; }
        public Cidade Cidade { get; set; }
        public string TipoEndereco { get; set; }
        public bool IsPersisted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
