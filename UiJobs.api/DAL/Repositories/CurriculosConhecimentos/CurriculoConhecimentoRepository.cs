using Microsoft.EntityFrameworkCore;
using UIJobsAPI.Data;
using UIJobsAPI.Models;

namespace UijobsApi.DAL.Repositories.CurriculosConhecimentos
{
    public class CurriculoConhecimentoRepository : ICurriculoConhecimentoRepository
    {
        private readonly DataContext _context;

        public CurriculoConhecimentoRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<CurriculoConhecimento> AddCurriculoConhecimentoAsync(CurriculoConhecimento novoCurriculoConhecimento)
        {
            await _context.CurriculoConhecimentos.AddAsync(novoCurriculoConhecimento);
            return novoCurriculoConhecimento;
        }

        public  async Task DeleteCurriculoConhecimentoByIdAsync(int idCurriculo, int idConhecimento)
        {
            var curriculoConhecimentos = await _context.CurriculoConhecimentos.FirstOrDefaultAsync(ci => ci.idCurriculo == idCurriculo && ci.idConhecimentos == idConhecimento);

            if (curriculoConhecimentos != null)
                _context.CurriculoConhecimentos.Remove(curriculoConhecimentos);
        }

        public async Task<IEnumerable<CurriculoConhecimento>> GetAllCurriculoConhecimentosAsync()
        {
            return await _context.CurriculoConhecimentos.ToListAsync();
        }

        public async Task<CurriculoConhecimento> GetCurriculoConhecimentoByIdAsync(int idCurriculo, int idConhecimento)
        {
            return await _context.CurriculoConhecimentos.FirstOrDefaultAsync(ci => ci.idCurriculo == idCurriculo && ci.idConhecimentos == idConhecimento);
        }

        public async Task<List<CurriculoConhecimento>> GetAllConhecimentosbyAsync(int id)
        {
            return await _context.CurriculoConhecimentos
                .Where(vi => vi.idCurriculo == id)
                .ToListAsync();
        }
    }
}
