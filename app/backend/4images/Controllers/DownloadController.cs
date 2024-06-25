using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _4images.Models;
using _4images.Services;
using Microsoft.AspNetCore.Authorization;

namespace _4images.Controllers
{
    [Authorize(Policy = "AdminOnly")]
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private readonly DownloadService _downloadService;

        public DownloadController(DownloadService downloadService)
        {
            _downloadService = downloadService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Download>>> GetDownloads()
        {
            var downloads = await _downloadService.GetAllDownloadsAsync();
            return Ok(downloads);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Download>> GetDownload(int id)
        {
            var download = await _downloadService.GetDownloadByIdAsync(id);
            if (download == null)
            {
                return NotFound();
            }
            return Ok(download);
        }

        [HttpPost]
        public async Task<ActionResult<Download>> CreateDownload(Download download)
        {
            var createdDownload = await _downloadService.CreateDownloadAsync(download);
            return CreatedAtAction(nameof(GetDownload), new { id = createdDownload.Id }, createdDownload);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDownload(int id, Download download)
        {
            if (id != download.Id)
            {
                return BadRequest();
            }

            await _downloadService.UpdateDownloadAsync(download);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDownload(int id)
        {
            await _downloadService.DeleteDownloadAsync(id);
            return NoContent();
        }
    }
}
