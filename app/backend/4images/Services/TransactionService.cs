using _4images.Data;
using _4images.Models;
using Microsoft.EntityFrameworkCore;

namespace _4images.Services
{
    public class TransactionService
    {
        private readonly ApplicationDbContext _context;
        private readonly TokenService _tokenService;

        public TransactionService(ApplicationDbContext context, TokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsAsync()
        {
            return await _context.Transactions.ToListAsync();
        }

        public async Task<Transaction> GetTransactionByIdAsync(int id)
        {
            return await _context.Transactions.FindAsync(id);
        }

        public async Task<IEnumerable<Transaction>> GetTransactionByUserIdAsync(int userId)
        {
            var transactions = await _context.Transactions
                                        .Where(t => t.UserId == userId)
                                        .ToListAsync();

            return transactions;
        }
        public async Task<Transaction> CreateTransactionAsync(Transaction transaction)
        {
            // Validar UserId
            var userId = await _context.Users.FindAsync(transaction.UserId);
            if (userId == null) return null;

            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }
    }
}
