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
        public async Task<IActionResult> UploadFile([FromForm] IFormFile file)
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

    }
}
