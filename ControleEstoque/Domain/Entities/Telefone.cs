namespace Domain.Entities
{
    public class Telefone
    {
        public int TelefoneId { get; set; }
        public string Numero { get; set; }
        public string TipoFone { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
