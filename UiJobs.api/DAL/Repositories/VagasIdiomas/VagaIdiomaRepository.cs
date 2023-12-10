using Microsoft.EntityFrameworkCore;
using UIJobsAPI.Data;
using UIJobsAPI.Models;

namespace UijobsApi.DAL.Repositories.VagasIdiomas
{
    public class VagaIdiomaRepository : IVagaIdiomaRepository
    {
        private readonly DataContext _context;

        public VagaIdiomaRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<VagaIdioma> AddVagaIdiomaAsync(VagaIdioma novaVagaIdioma)
        {
            await _context.VagasIdiomas.AddAsync(novaVagaIdioma);
            return novaVagaIdioma;
        }

        public async Task DeleteVagaIdiomaByIdAsync(int idVaga, int idIdioma)
        {
            var vagaIdioma = await _context.VagasIdiomas.FirstOrDefaultAsync(vi => vi.idVagas == idVaga && vi.idIdiomas == idIdioma);

            if (vagaIdioma != null)
                _context.VagasIdiomas.Remove(vagaIdioma);
        }

        public async Task<IEnumerable<VagaIdioma>> GetAllVagaIdiomaAsync()
        {
            return await _context.VagasIdiomas.ToListAsync();
        }

        public async Task<VagaIdioma> GetVagaIdiomaByIdAsync(int id)
        {
            return await _context.VagasIdiomas.FirstOrDefaultAsync(vagaIdioma => vagaIdioma.idIdiomas == id);
        }

        public async Task<List<VagaIdioma>> GetAllIdiomasbyAsync(int id)
        {
            return await _context.VagasIdiomas
                .Where(vi => vi.idVagas == id)
                .ToListAsync();
        }
        public async Task<VagaIdioma> GetIdVagaAndIdIdiomaAsync(int idVaga, int idIdioma)
        {
            return await _context.VagasIdiomas.FirstOrDefaultAsync(vi => vi.idVagas == idVaga && vi.idIdiomas == idIdioma);
        }
    }
}