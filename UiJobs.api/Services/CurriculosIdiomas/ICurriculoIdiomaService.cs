using UIJobsAPI.Models;

namespace UijobsApi.Services.CurriculosIdiomas
{
    public interface ICurriculoIdiomaService
    {
        public Task<IEnumerable<CurriculoIdioma>> GetAllCurriculoIdiomasAsync();

        public Task<CurriculoIdioma> GetCurriculoIdiomasByIdAsync(int curriculoId, int idiomaId);
        public Task<CurriculoIdioma> AddCurriculoIdiomaAsync(CurriculoIdioma novoCurriculoIdioma);

        public Task DeleteCurriculoIdiomaByIdAsync(int curriculoId, int idiomaId);

        public Task<List<CurriculoIdioma>> GetAllConhecimentobyIdAsync(int id);
    }
}
