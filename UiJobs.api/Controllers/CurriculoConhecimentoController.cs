using Microsoft.AspNetCore.Mvc;
using UijobsApi.DAL.Repositories.CurriculosConhecimentos;
using UijobsApi.DAL.Repositories.Cursos;
using UijobsApi.Services.CurriculosConhecimentos;
using UIJobsAPI.Data;
using UIJobsAPI.Exceptions;
using UIJobsAPI.Models;
using UIJobsAPI.Services.Cursos;

namespace UijobsApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CurriculoConhecimentoController : ControllerBase
    {
        private readonly ICurriculoConhecimentoService _curriculoConhecimentoService;
        private readonly ICurriculoConhecimentoRepository _curriculoConhecimentoRepository;
        private readonly DataContext _context;

        public CurriculoConhecimentoController(ICurriculoConhecimentoService curriculoConhecimentoService, ICurriculoConhecimentoRepository curriculoConhecimentoRepository, DataContext context)
        {
            _curriculoConhecimentoService = curriculoConhecimentoService;
            _curriculoConhecimentoRepository = curriculoConhecimentoRepository;
            _context = context;
        }

        [HttpGet("{idCurriculo}")]
        public async Task<IActionResult> GetByIdAsync(int idCurriculo)
        {
            try
            {
                List<CurriculoConhecimento> curriculoConhecimento = await _curriculoConhecimentoService.GetAllConhecimentobyIdAsync(idCurriculo);
                return Ok(curriculoConhecimento);
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
                IEnumerable<CurriculoConhecimento> listaCurriculoConhecimentos = await _curriculoConhecimentoService.GetAllCurriculoConhecimentosAsync();
                return Ok(listaCurriculoConhecimentos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddCurriculoConhecimentoAsync(CurriculoConhecimento novoCurriculoConhecimento)
        {
            try
            {
                CurriculoConhecimento curriculoConhecimento = await _curriculoConhecimentoService.AddCurriculoConhecimentoAsync(novoCurriculoConhecimento);
                return Ok(curriculoConhecimento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{idCurriculo}/{idConhecimento}")]
        public async Task<IActionResult> DeleteCurriculoConhecimento(int idCurriculo, int idConhecimento)
        {
            try
            {
                await _curriculoConhecimentoService.DeleteCurriculoConhecimentoByIdAsync(idCurriculo, idConhecimento);
                return NoContent(); // Retorna uma resposta 204 No Content após a exclusão bem-sucedida.
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorna um StatusCode 400 Bad Request em caso de erro.
            }
        }

    }
}
