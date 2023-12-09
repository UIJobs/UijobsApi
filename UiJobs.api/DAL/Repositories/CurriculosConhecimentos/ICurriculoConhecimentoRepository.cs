using UIJobsAPI.Models;

namespace UijobsApi.DAL.Repositories.CurriculosConhecimentos
{
    public interface ICurriculoConhecimentoRepository
    {

        public Task<IEnumerable<CurriculoConhecimento>> GetAllCurriculoConhecimentosAsync();

        public Task<CurriculoConhecimento> GetCurriculoConhecimentoByIdAsync(int idCurriculo, int idConhecimento);

        public Task<CurriculoConhecimento> AddCurriculoConhecimentoAsync(CurriculoConhecimento novoCurriculoConhecimento);

        public Task DeleteCurriculoConhecimentoByIdAsync(int idCurriculo, int idConhecimento);

        public Task<List<CurriculoConhecimento>> GetAllConhecimentosbyAsync(int id);
    }
}
