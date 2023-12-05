using UIJobsAPI.Models;

namespace UijobsApi.DAL.Repositories.CurriculosIdiomas
{
    public interface ICurriculoIdiomaRepository
    {
        public Task<IEnumerable<CurriculoIdioma>> GetAllCurriculoIdiomasAsync();

        public Task<CurriculoIdioma> GetCurriculoIdiomasByIdAsync(int curriculoId, int idiomaId);
        public Task<CurriculoIdioma> AddCurriculoIdiomaAsync(CurriculoIdioma novoCurriculoIdioma);

        public Task DeleteCurriculoIdiomaByIdAsync(int curriculoId, int idiomaId);
    }
}
