using Microsoft.AspNetCore.Mvc;
using UijobsApi.Services.EnderecoCandidatos;
using UIJobsAPI.Data;
using UIJobsAPI.Exceptions;
using UIJobsAPI.Models;
using UijobsApi.DAL.Repositories.EnderecoCandidatos;

namespace UijobsApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoCandidatoController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IEnderecoCandidatoService _enderecoCandidatoService;
        private readonly IEnderecoCandidatoRepository _enderecoCandidatoRepository;

        public EnderecoCandidatoController(DataContext context, IEnderecoCandidatoService enderecoCandidatoService, IEnderecoCandidatoRepository enderecoCandidatoRepository)
        {
            _context = context;
            _enderecoCandidatoService = enderecoCandidatoService;
            _enderecoCandidatoRepository = enderecoCandidatoRepository;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            try
            {
                EnderecoCandidato enderecoCandidato = await _enderecoCandidatoService.GetEnderecoCandidatosByIdAsync(id);
                return Ok(enderecoCandidato);
            }
            catch (BaseException ex)
            {
                // isso a gente controla
                return ex.GetResponse();
            }
           
        }
        [HttpPost]
        public async Task<IActionResult> AddEnderecoCandidatoAsync(EnderecoCandidato novoEnderecoCandidato)
        {
            try
            {
                // Acesse os cabeçalhos da solicitação
                var headers = HttpContext.Request.Headers;

                // Exemplo: obter o valor do cabeçalho "Content-Type"
                if (headers.ContainsKey("Content-Type"))
                {
                    var contentType = headers["Content-Type"];
                    // Faça algo com o valor do cabeçalho, se necessário
                }

                // Restante da sua lógica para adicionar o endereço do candidato
                EnderecoCandidato enderecoCandidato = await _enderecoCandidatoService.AddEnderecoCandidatosAsync(novoEnderecoCandidato);

                // Retorne uma resposta de sucesso com o endereço criado
                return Created("Endereço do Candidato criado", enderecoCandidato);
            }
        catch (BaseException ex)
        {
                // Se houver uma exceção, retorne a resposta apropriada
                return ex.GetResponse();
            }


        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnderecoCandidatoAsync(int id)
        {
            try
            {
                await _enderecoCandidatoService.DeleteEnderecoCandidatoByIdAsync(id);
                return NoContent(); // Retorna uma resposta 204 No Content após a exclusão bem-sucedida.
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorna um StatusCode 400 Bad Request em caso de erro.
            }
        }



    }
}