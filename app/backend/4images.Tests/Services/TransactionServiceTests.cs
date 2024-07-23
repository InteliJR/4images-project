using Moq;
using Microsoft.EntityFrameworkCore;
using _4images.Data;
using _4images.Models;
using _4images.Services;
using NUnit.Framework.Legacy;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4images.Tests.Services
{
    [TestFixture]
    public class TransactionServiceTests
    {
        private ApplicationDbContext _context;
        private TransactionService _transactionService;
        private Mock<TokenService> _mockTokenService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
            _mockTokenService = new Mock<TokenService>("SecretKeyMuitoSecretaEssaChaveAAAAAAA");
            _transactionService = new TransactionService(_context, _mockTokenService.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [Test]
        public async Task GetTransactionsAsync_ShouldReturnAllTransactions()
        {
            // Arrange
            var transaction = new Transaction 
            { 
                Id = 1, 
                UserId = 1,
                Filename = "example_transaction.jpg"
            };
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            // Act
            var result = await _transactionService.GetTransactionsAsync();

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(1, result.Count());
        }

        [Test]
        public async Task GetTransactionByIdAsync_ShouldReturnCorrectTransaction()
        {
            // Arrange
            var transaction = new Transaction 
            { 
                Id = 1, 
                UserId = 1,
                Filename = "example_transaction.jpg"
            };
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            // Act
            var result = await _transactionService.GetTransactionByIdAsync(transaction.Id);

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(transaction.Id, result.Id);
        }

        [Test]
        public async Task GetTransactionByUserIdAsync_ShouldReturnTransactionsForUser()
        {
            // Arrange
            var user = new User 
            { 
                Id = 1, 
                FullName = "User One",
                UserName = "user1",
                Email = "user1@example.com",
                Password = "password",
                Signature = "signature"
            };
            _context.Users.Add(user);

            var transaction = new Transaction 
            { 
                Id = 1, 
                UserId = 1,
                Filename = "example_transaction.jpg"
            };
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            // Act
            var result = await _transactionService.GetTransactionByUserIdAsync(user.Id);

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(1, result.Count());
            ClassicAssert.AreEqual(transaction.UserId, result.First().UserId);
        }

        [Test]
        public async Task CreateTransactionAsync_ShouldAddTransactionAndReturnTransaction()
        {
            // Arrange
            var user = new User 
            { 
                Id = 1, 
                FullName = "User One",
                UserName = "user1",
                Email = "user1@example.com",
                Password = "password",
                Signature = "signature"
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var transaction = new Transaction 
            { 
                Id = 1, 
                UserId = user.Id,
                Filename = "example_transaction.jpg"
            };

            // Act
            var result = await _transactionService.CreateTransactionAsync(transaction);

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(transaction.Id, result.Id);
            ClassicAssert.AreEqual(transaction.UserId, result.UserId);

            var transactionsInDb = await _context.Transactions.ToListAsync();
            ClassicAssert.AreEqual(1, transactionsInDb.Count);
            ClassicAssert.AreEqual(transaction.Id, transactionsInDb[0].Id);
        }
    }
}
