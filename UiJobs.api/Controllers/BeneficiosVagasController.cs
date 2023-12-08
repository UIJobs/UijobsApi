﻿using Microsoft.AspNetCore.Mvc;
using UIJobsAPI.Data;
using UIJobsAPI.Exceptions;
using UIJobsAPI.Models;
using UijobsApi.Services.BeneficiosVagas;

namespace UijobsApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BeneficiosVagasController : ControllerBase
    {
        private readonly IBeneficioVagaService _beneficioVagaService;
        private readonly DataContext _context;

        public BeneficiosVagasController(IBeneficioVagaService beneficioVagaService, DataContext context)
        {
            _beneficioVagaService = beneficioVagaService;
            _context = context;
        }

        [HttpGet("{vagaId}")]
        public async Task<IActionResult> GetByVagaIdBeneficioIdAsync(int vagaId)
        {
            try
            {
                List<BeneficioVaga> beneficioVaga = await _beneficioVagaService.GetBeneficioVagaByIdAsync(vagaId);
                return Ok(beneficioVaga);
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

        [HttpPost]
        public async Task<IActionResult> AddCBeneficioVagaAsync(BeneficioVaga novoBeneficioVaga)
        {
            try
            {
                BeneficioVaga beneficioVaga = await _beneficioVagaService.AddBeneficioVagaAsync(novoBeneficioVaga);
                return Ok(beneficioVaga);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{idBeneficio}/{idVaga}")]
        public async Task<IActionResult> DeleteBenficioVaga(int idBeneficio, int idVaga)
        {
            try
            {
                await _beneficioVagaService.DeleteBeneficioVagaByIdAsync(idBeneficio, idVaga);
                return NoContent(); // Retorna uma resposta 204 No Content após a exclusão bem-sucedida.
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorna um StatusCode 400 Bad Request em caso de erro.
            }
        }
    }
}
