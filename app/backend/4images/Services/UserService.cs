using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using _4images.Data;
using _4images.Models;
using System.Security.Cryptography;

namespace _4images.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;
        private readonly TokenService _tokenService;

        public UserService(ApplicationDbContext context, TokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
        public async Task<User> CreateUserAsync(User user)
        {
            user.Password = HashPassword(user.Password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
        public async Task<User> UpdateUserAsync(User user)
        {
            var existingUser = await _context.Users.FindAsync(user.Id);
            if (existingUser == null) return null;

            existingUser.FullName = user.FullName;
            existingUser.UserName = user.UserName;
            existingUser.Email = user.Email;
            existingUser.Signature = user.Signature;

            // only update password if it is changed
            if (!string.IsNullOrEmpty(user.Password))
            {
                existingUser.Password = HashPassword(user.Password);
            }

            _context.Users.Add(existingUser);
            await _context.SaveChangesAsync();
            return existingUser;
        }
        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<string> AuthenticateAsync(string fullname, string password)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.FullName == fullname);
            if (user == null || !VerifyPassword(user.Password, password))
            {
                return null;
            }

            return _tokenService.GenerateToken(user);
        }
        private string HashPassword(string password)
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
        private bool VerifyPassword(string hashedPassword, string password)
        {
            // posso adicionar uma lógica mais complexa posteriormente XD
            return hashedPassword == HashPassword(password);
        }
    }
}
