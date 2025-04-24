using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace GestorCheff.Models
{
    public class User
    {
        // User Id
        [Key]
        public long UserId { get; set; }


        // User data
        public string Username { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Cpf { get; set; }


        // Login data

        public string Email { get; set; }

        public string Password { get; set; }


        // List of User addresses
        public ICollection<Address> Addresses { get; set; } = new List<Address>();


        // List of Orders

       
    }
}
