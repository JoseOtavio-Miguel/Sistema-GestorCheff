using Microsoft.CodeAnalysis.Elfie.Model.Tree;
using System.ComponentModel.DataAnnotations;

namespace GestorCheff.Models
{
    public class MenuItem
    {
        // Chave primária do item do menu
        [Key]
        public long IdItem { get; set; }

        // Nome do item
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Descrição detalhada do prato
        [StringLength(500)]
        public string Description { get; set; }

        // Preço
        [Range(0.01, 1000.00)]
        public decimal Price { get; set; }

        // Categoria (ex: entrada, principal, sobremesa)
        [Required]
        public string Category { get; set; }

        // Se está disponível
        public bool IsAvailable { get; set; }

        // Tipo de item (relacionamento com ItemType)
        public string ItemType { get; set; }
    }
}
