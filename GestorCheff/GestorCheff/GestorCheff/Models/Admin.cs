using GestorCheff.Models;

namespace GestorCheff.Models
{
    public class Admin : User
    {
        // Inherit positions properties
        public string Status { get; set; }
    }
}
