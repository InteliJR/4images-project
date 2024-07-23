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
    public class DownloadServiceTests
    {
        private ApplicationDbContext _context;
        private DownloadService _downloadService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
            _downloadService = new DownloadService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [Test]
        public async Task GetAllDownloadsAsync_ShouldReturnAllDownloads()
        {
            // Arrange
            var fileMetadata = new FileMetadata 
            { 
                BlobUrl = "https://example.com/blob",
                ContentType = "image/jpeg",
                FileName = "example.jpg"
            };
            var transaction = new Transaction
            {
                Filename = "example_transaction.jpg"
            };
            var download = new Download { Id = 1, FileMetadata = fileMetadata, Transaction = transaction };
            _context.Downloads.Add(download);
            await _context.SaveChangesAsync();

            // Act
            var result = await _downloadService.GetAllDownloadsAsync();

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(1, result.Count());
        }

        [Test]
        public async Task GetDownloadByIdAsync_ShouldReturnCorrectDownload()
        {
            // Arrange
            var fileMetadata = new FileMetadata 
            { 
                BlobUrl = "https://example.com/blob",
                ContentType = "image/jpeg",
                FileName = "example.jpg"
            };
            var transaction = new Transaction
            {
                Filename = "example_transaction.jpg"
            };
            var download = new Download { Id = 1, FileMetadata = fileMetadata, Transaction = transaction };
            _context.Downloads.Add(download);
            await _context.SaveChangesAsync();

            // Act
            var result = await _downloadService.GetDownloadByIdAsync(download.Id);

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(download.Id, result.Id);
            ClassicAssert.AreEqual(download.FileMetadata, result.FileMetadata);
            ClassicAssert.AreEqual(download.Transaction, result.Transaction);
        }

        [Test]
        public async Task CreateDownloadAsync_ShouldAddDownloadAndReturnDownload()
        {
            // Arrange
            var fileMetadata = new FileMetadata 
            { 
                BlobUrl = "https://example.com/blob",
                ContentType = "image/jpeg",
                FileName = "example.jpg"
            };
            var transaction = new Transaction
            {
                Filename = "example_transaction.jpg"
            };
            var download = new Download { Id = 1, FileMetadata = fileMetadata, Transaction = transaction };

            // Act
            var result = await _downloadService.CreateDownloadAsync(download);

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(download.Id, result.Id);
            ClassicAssert.AreEqual(download.FileMetadata, result.FileMetadata);
            ClassicAssert.AreEqual(download.Transaction, result.Transaction);

            var downloadsInDb = await _context.Downloads.ToListAsync();
            ClassicAssert.AreEqual(1, downloadsInDb.Count);
            ClassicAssert.AreEqual(download.Id, downloadsInDb[0].Id);
        }

        [Test]
        public async Task UpdateDownloadAsync_ShouldUpdateAndReturnDownload()
        {
            // Arrange
            var fileMetadata = new FileMetadata 
            { 
                BlobUrl = "https://example.com/blob",
                ContentType = "image/jpeg",
                FileName = "example.jpg"
            };
            var transaction = new Transaction
            {
                Filename = "example_transaction.jpg"
            };
            var download = new Download { Id = 1, FileMetadata = fileMetadata, Transaction = transaction };
            _context.Downloads.Add(download);
            await _context.SaveChangesAsync();

            // Act
            download.FileMetadata = new FileMetadata
            {
                BlobUrl = "https://example.com/blob/updated",
                ContentType = "image/png",
                FileName = "example_updated.png"
            };
            download.Transaction = new Transaction
            {
                Filename = "example_transaction_updated.jpg"
            };
            var result = await _downloadService.UpdateDownloadAsync(download);

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(download.Id, result.Id);
            ClassicAssert.AreEqual(download.FileMetadata, result.FileMetadata);
            ClassicAssert.AreEqual(download.Transaction, result.Transaction);
        }

        [Test]
        public async Task DeleteDownloadAsync_ShouldRemoveDownload()
        {
            // Arrange
            var fileMetadata = new FileMetadata 
            { 
                BlobUrl = "https://example.com/blob",
                ContentType = "image/jpeg",
                FileName = "example.jpg"
            };
            var transaction = new Transaction
            {
                Filename = "example_transaction.jpg"
            };
            var download = new Download { Id = 1, FileMetadata = fileMetadata, Transaction = transaction };
            _context.Downloads.Add(download);
            await _context.SaveChangesAsync();

            // Act
            await _downloadService.DeleteDownloadAsync(download.Id);

            // Assert
            var downloadsInDb = await _context.Downloads.ToListAsync();
            ClassicAssert.AreEqual(0, downloadsInDb.Count);
        }
    }
}
