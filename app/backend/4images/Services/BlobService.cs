using Azure.Storage.Blobs;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace _4images.Services
{
    public class BlobService
    {
        private readonly string _connectionString;
        private readonly string _containerName = "itmantestcontainer";

        public BlobService()
        {
            _connectionString = Environment.GetEnvironmentVariable("AZURE_BLOB_STORAGE");
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("A string de conexão do Azure Blob Storage não foi encontrada nas variáveis de ambiente.");
            }
        }

        private BlobServiceClient CreateBlobServiceClient()
        {
            return new BlobServiceClient(_connectionString);
        }

        public async Task UploadFileAsync(Stream fileStream, string fileName)
        {
            var blobServiceClient = CreateBlobServiceClient();
            var blobContainerClient = blobServiceClient.GetBlobContainerClient(_containerName);
            var blobClient = blobContainerClient.GetBlobClient(fileName);

            await blobClient.UploadAsync(fileStream, overwrite: true);
        }

        public async Task<IEnumerable<string>> ListFilesAsync()
        {
            var blobServiceClient = CreateBlobServiceClient();
            var blobContainerClient = blobServiceClient.GetBlobContainerClient(_containerName);

            var blobs = new List<string>();
            await foreach (var blobItem in blobContainerClient.GetBlobsAsync())
            {
                blobs.Add(blobItem.Name);
            }

            return blobs;
        }

        public async Task<Stream> DownloadFileAsync(string fileName)
        {
            var blobServiceClient = CreateBlobServiceClient();
            var blobContainerClient = blobServiceClient.GetBlobContainerClient(_containerName);
            var blobClient = blobContainerClient.GetBlobClient(fileName);

            var downloadInfo = await blobClient.DownloadAsync();
            return downloadInfo.Value.Content;
        }

        public async Task DeleteFileAsync(string fileName)
        {
            var blobServiceClient = CreateBlobServiceClient();
            var blobContainerClient = blobServiceClient.GetBlobContainerClient(_containerName);
            var blobClient = blobContainerClient.GetBlobClient(fileName);

            await blobClient.DeleteIfExistsAsync();
        }

        public string GetBlobUrl(string fileName)
        {
            var blobServiceClient = CreateBlobServiceClient();
            var blobContainerClient = blobServiceClient.GetBlobContainerClient(_containerName);
            var blobClient = blobContainerClient.GetBlobClient(fileName);

            return blobClient.Uri.ToString();
        }
    }
}
