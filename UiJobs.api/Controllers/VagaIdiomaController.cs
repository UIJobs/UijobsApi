using Microsoft.AspNetCore.Mvc;
using UIJobsAPI.Data;
using UIJobsAPI.Exceptions;
using UIJobsAPI.Models;
using UijobsApi.Services.VagasConhecimentos;
using UijobsApi.Services.VagasIdiomas;

namespace UijobsApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class VagaIdiomaController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IVagaIdiomaService _vagaIdiomaService;

        public VagaIdiomaController(DataContext context, IVagaIdiomaService vagaIdiomaService)
        {
            _context = context;
            _vagaIdiomaService = vagaIdiomaService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            try
            {
                List<VagaIdioma> vagaIdioma = await _vagaIdiomaService.GetAllIdiomasbyIdAsync(id);
                return Ok(vagaIdioma);
            }
            catch (BaseException ex)
            {
                return ex.GetResponse();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<VagaIdioma> listavagaIdioma = await _vagaIdiomaService.GetAllVagaIdiomaAsync();
                return Ok(listavagaIdioma);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddVagaIdiomaAsync(VagaIdioma novaVagaIdioma)
        {
            try
            {
                VagaIdioma vagaIdioma = await _vagaIdiomaService.AddVagaIdiomaAsync(novaVagaIdioma);
                return Created("Vaga Idioma", vagaIdioma);
            }
            catch (BaseException ex)
            {
                // isso a gente controla
                return ex.GetResponse();
            }
            catch (Exception ex)
            {
                // isso foge da gente
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{idVaga}/{idIdioma}")]
        public async Task<IActionResult> DeleteVaga(int idVaga, int idIdioma)
        {
            try
            {
                await _vagaIdiomaService.DeleteVagaIdiomaByIdAsync(idVaga, idIdioma);
                return NoContent(); // Retorna uma resposta 204 No Content após a exclusão bem-sucedida.
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorna um StatusCode 400 Bad Request em caso de erro.
            }
        }
    }
}
