using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace GestorCheff.Models
{
    public class Address
    {

        [Key]
        public long AddressId {  get; set; }

        // Address data (country-city-neighborhood-number)
        [Required(ErrorMessage = "O país é obrigatório")]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Neighborhood { get; set; }

        [Required]
        public string Number { get; set; }


        [Required(ErrorMessage = "O Cep é obrigatório")]
        public string Cep { get; set; }

    }
}
