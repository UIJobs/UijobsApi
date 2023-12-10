using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using UIJobsAPI.Data;
using UIJobsAPI.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace UijobsApi.DAL.Repositories.VagasCandidatos
{
    public class VagaCandidatoRepository : IVagaCandidatoRepository
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        public VagaCandidatoRepository(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<VagaCandidato> AddVagaCandidatoAsync(VagaCandidato novaVagaCandidato)
        {
            // Adiciona a nova vaga candidato ao contexto
            await _context.VagasCandidato.AddAsync(novaVagaCandidato);

            // Salva as mudanças no banco de dados
            await _context.SaveChangesAsync();

            // Obtém o ID recém-gerado
            int idVagas = novaVagaCandidato.idVagas; // Supondo que Id seja a propriedade que armazena o ID

            // Obtém a string de conexão do IConfiguration
            string connectionString = _configuration.GetConnectionString("ConexaoSmarter");

            // Chama a stored procedure com o ID obtido
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("PorcAderencia", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adiciona o valor do ID como parâmetro
                    cmd.Parameters.AddWithValue("@idVagas", idVagas);

                    // Executa o comando
                    cmd.ExecuteNonQuery();
                }
            }
            return novaVagaCandidato;
        }

        public async Task DeleteVagaCandidatoByIdAsync(VagaCandidato vagaCandidato)
        {
            _context.VagasCandidato.Remove(vagaCandidato);
        }

        public async Task<IEnumerable<VagaCandidato>> GetAllVagaCandidatoAsync()
        {
            return await _context.VagasCandidato.ToListAsync();
        }

        public async Task<VagaCandidato> GetVagaCandidatoByIdAsync(int id)
        {
            return await _context.VagasCandidato.FirstOrDefaultAsync(vagaCandi => vagaCandi.idVagas == id);
        }

        public async Task<List<VagaCandidato>> GetAllCandidatosbyIdAsync(int id)
        {
            return await _context.VagasCandidato
                .Where(vi => vi.idVagas == id)
                .ToListAsync();
        }
    }
}