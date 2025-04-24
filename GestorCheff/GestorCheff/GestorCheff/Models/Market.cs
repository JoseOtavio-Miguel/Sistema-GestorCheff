using System.ComponentModel.DataAnnotations;

namespace GestorCheff.Models
{
    public class Market
    {
        // Chave primária da loja
        [Key]
        public long IdLoja { get; set; }

        // Nome do proprietário da loja
        [Required(ErrorMessage = "O nome do proprietário é obrigatório.")]
        public string Proprietario { get; set; }

        // Nome da loja
        [Required(ErrorMessage = "O nome da loja é obrigatório.")]
        public string NomeLoja { get; set; }

        // CNPJ da loja
        [StringLength(18, ErrorMessage = "CNPJ inválido.")]
        public string CNPJ { get; set; }

        // Endereço da loja
        public Address Endereco { get; set; }

        // Telefone de contato
        public string Telefone { get; set; }

        // Email da loja
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }
    }
}
