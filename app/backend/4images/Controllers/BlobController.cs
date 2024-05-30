using _4images.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _4images.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobController : ControllerBase
    {
        private readonly BlobService _blobService;
        public BlobController(BlobService blobService)
        {
            _blobService = blobService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Arquivo não enviado ou está vazio.");
            }

            using (var stream = file.OpenReadStream())
            {
                await _blobService.UploadFileAsync(stream, file.FileName);
            }

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
