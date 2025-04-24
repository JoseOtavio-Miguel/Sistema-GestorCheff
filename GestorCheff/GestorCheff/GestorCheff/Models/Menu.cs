using Microsoft.CodeAnalysis.Elfie.Model.Tree;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestorCheff.Models
{
    public class Menu
    {
        // Id do menu
        [Key]
        public long IdMenu { get; set; }

        // Nome do menu (exemplo: "Menu Principal", "Menu de Sobremesas")
        public string ItemType { get; set; }

        // Lista de itens do menu
        public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        // Construtor
        public Menu()
        {
            // Você pode adicionar alguns itens do menu no momento da criação, se necessário.
            // Exemplo de adicionar carpaccio
            MenuItems.Add(new MenuItem
            {
                IdItem = 1,
                Name = "Carpaccio",
                Description = "Carne crua fatiada finamente, temperada com azeite e limão.",
                Price = 25.00m,
                Category = "Entrada",
                IsAvailable = true
            });
        }
    }
}
