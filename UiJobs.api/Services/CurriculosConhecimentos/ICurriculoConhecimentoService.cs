using UIJobsAPI.Models;

namespace UijobsApi.Services.CurriculosConhecimentos
{
    public interface ICurriculoConhecimentoService
    {
        public Task<IEnumerable<CurriculoConhecimento>> GetAllCurriculoConhecimentosAsync();

        public Task<List<CurriculoConhecimento>> GetAllConhecimentobyIdAsync(int id);

        public Task<CurriculoConhecimento> AddCurriculoConhecimentoAsync(CurriculoConhecimento novoCurriculoConhecimento);

        public Task DeleteCurriculoConhecimentoByIdAsync(int idCurriculo, int idConhecimento);
    }
}
