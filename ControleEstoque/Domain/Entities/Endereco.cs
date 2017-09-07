using System;

namespace Domain.Entities
{
    public class Endereco : IEntity
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public Pessoa Pessoa { get; set; }
        public Cidade Cidade { get; set; }
        public string TipoEndereco { get; set; }

        public string GetDescricao()
        {
            return $"{Logradouro} {Numero}";
        }

        public int GetId()
        {
            return EnderecoId;
        }
    }
}
