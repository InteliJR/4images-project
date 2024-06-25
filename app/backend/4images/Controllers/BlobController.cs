﻿using _4images.Services;
using _4images.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _4images.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobController : ControllerBase
    {
        private readonly BlobService _blobService;
        private readonly IFileMetadataService _fileMetadataService;

        public BlobController(BlobService blobService, IFileMetadataService fileMetadataService)
        {
            _blobService = blobService;
            _fileMetadataService = fileMetadataService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Arquivo não enviado ou está vazio.");
            }

            var fileName = file.FileName;
            var contentType = file.ContentType;
            var size = file.Length;

            using (var stream = file.OpenReadStream())
            {
                await _blobService.UploadFileAsync(stream, fileName);
            }

            var fileMetadata = new FileMetadata
            {
                BlobUrl = $"{_blobService.GetBlobUrl(fileName)}",
                FileName = fileName,
                ContentType = contentType,
                Size = size
            };

            await _fileMetadataService.AddFileMetadataAsync(fileMetadata);

            return Ok("Arquivo enviado com sucesso!");
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListFiles()
        {
            var files = await _blobService.ListFilesAsync();
            return Ok(files);
        }

        [HttpGet("download/{fileName}")]
        public async Task<IActionResult> DownloadFile(string fileName)
        {
            var stream = await _blobService.DownloadFileAsync(fileName);
            return File(stream, "application/octet-stream", fileName);
        }

        [HttpDelete("delete/{fileName}")]
        public async Task<IActionResult> DeleteFile(string fileName)
        {
            await _blobService.DeleteFileAsync(fileName);
            return Ok(new { message = "Arquivo excluído com sucesso!" });
        }
    }
}
