using _4images.Models;
using _4images.Services;
using Microsoft.AspNetCore.Mvc;

namespace _4images.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LikeController : Controller
    {
        private readonly LikeService _likeService;

        public LikeController(LikeService likeService)
        {
            _likeService = likeService;
        }
        [HttpGet]
        public async Task<IEnumerable<Like>> GetLikes()
        {
            return await _likeService.GetLikesAsync();
        }
        [HttpGet("{id}")]
        public async Task<Like> GetLikesById(int id)
        {
            return await _likeService.GetLikeByIdAsync(id);
        }
        [HttpGet]
        public async Task<IEnumerable<Like>> GetLikesByUser(int userId)
        {
            return await _likeService.GetLikeByUserAsync(userId);
        }
        [HttpGet]
        public async Task<IEnumerable<Like>> GetLikeByImage(int imageId)
        {
            return await _likeService.GetLikeByImageAsync(imageId);
        }
        [HttpPost]
        public async Task<Like> CreateLike(Like like)
        {
            return await _likeService.CreateLikeAsync(like);
        }
    }
}
