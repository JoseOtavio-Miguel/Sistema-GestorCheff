using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestorCheff.Models
{
    public class Order
    {
        [Key]
        public long OrderId { get; set; }

        // Relacionamento com o usuário que fez o pedido
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        // Lista de itens do carrinho vinculados ao pedido
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

        // Data e hora em que o pedido foi feito
        public DateTime OrderDate { get; set; } = DateTime.Now;

        // Status da entrega (Ex: Pendente, Em Preparação, Enviado, Entregue, Cancelado)
        [Required]
        public DeliveryStatus Status { get; set; } = DeliveryStatus.Pendente;

        // Total do pedido
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalAmount { get; set; }

        // ID da loja (se seu sistema suportar múltiplas lojas)
        public long? IdLoja { get; set; }
        [ForeignKey("IdLoja")]
        public Market Loja { get; set; }
    }

    public enum DeliveryStatus
    {
        Pendente,
        EmPreparacao,
        Enviado,
        Entregue,
        Cancelado
    }
}
