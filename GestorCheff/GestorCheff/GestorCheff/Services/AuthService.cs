using GestorCheff.Data;
using Microsoft.EntityFrameworkCore;

namespace GestorCheff.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;

        public bool IsLoggedIn { get; private set; }
        public string LoggedEmail { get; private set; } = "";

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            var user = await _context.LoginUser
                .FirstOrDefaultAsync(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                IsLoggedIn = true;
                LoggedEmail = user.Email;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            IsLoggedIn = false;
            LoggedEmail = "";
        }
    }
}
