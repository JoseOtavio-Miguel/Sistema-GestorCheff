using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestorCheff.Models
{
    public class Cart
    {
        // Chave primária do carrinho
        [Key]
        public long CartId { get; set; }

        // Relacionamento com o usuário (se o carrinho for associado a um usuário específico)
        public long UserId { get; set; }

        // Navegação para o usuário
        public User User { get; set; }

        // Lista de itens no carrinho
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

        // Data em que o carrinho foi criado (ou atualizado)
        public DateTime CreatedAt { get; set; }

        // Status do carrinho (ex: "Em andamento", "Finalizado")
        public string Status { get; set; }

        // Preço total do carrinho
        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (var item in CartItems)
                {
                    total += item.TotalPrice; // Total de cada item no carrinho
                }
                return total;
            }
        }
    }
}
