
// Classe que representa um item no carrinho (cada item do menu com quantidade)
using GestorCheff.Models;
using System.ComponentModel.DataAnnotations;

public class CartItem
{
    // Chave primária do item do carrinho
    [Key]
    public long CartItemId { get; set; }

    // Quantidade do item no carrinho
    public int Quantity { get; set; }

    // Preço unitário do item
    public decimal Price { get; set; }

    // Chave estrangeira para o item do menu
    public long MenuItemId { get; set; }

    // Navegação para o item do menu
    public MenuItem MenuItem { get; set; }

    // Preço total do item (Quantity * Price)
    public decimal TotalPrice
    {
        get
        {
            return Quantity * Price;
        }
    }
}