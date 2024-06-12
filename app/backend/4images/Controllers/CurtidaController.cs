using _4images.Models;
using _4images.Services;
using Microsoft.AspNetCore.Mvc;

namespace _4images.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurtidaController : Controller
    {
        private readonly CurtidaService _curtidaService;

        public CurtidaController(CurtidaService curtidaService)
        {
            _curtidaService = curtidaService;
        }
        [HttpGet]
        public async Task<IEnumerable<Curtida>> GetCurtidas()
        {
            return await _curtidaService.GetCurtidasAsync();
        }
        [HttpGet("{id}")]
        public async Task<Curtida> GetCurtidasById(int id)
        {
            return await _curtidaService.GetCurtidaByIdAsync(id);
        }
        [HttpGet]
        public async Task<IEnumerable<Curtida>> GetCurtidasByUser(int userId)
        {
            return await _curtidaService.GetCurtidaByUserAsync(userId);
        }
        [HttpGet]
        public async Task<IEnumerable<Curtida>> GetCurtidaByImage(int imageId)
        {
            return await _curtidaService.GetCurtidaByImageAsync(imageId);
        }
        [HttpPost]
        public async Task<Curtida> CreateCurtida(Curtida curtida)
        {
            return await _curtidaService.CreateCurtidaAsync(curtida);
        }
    }
}
