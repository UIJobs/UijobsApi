using UIJobsAPI.Models;

namespace UijobsApi.DAL.Repositories.VagasConhecimentos
{
    public interface IVagaConhecimentoRepository
    {
        //Listar todos
        public Task<IEnumerable<VagaConhecimento>> GetAllVagaConhecimentoAsync();

        //listar por id
        public Task<VagaConhecimento> GetVagaConhecimentoByIdAsync(int id);

        public Task<VagaConhecimento> AddVagaConhecimentoAsync(VagaConhecimento novaVagaConhecimento);

        public Task DeleteVagaConhecimentoByIdAsync(int idVaga, int idConhecimento);

        public Task<List<VagaConhecimento>> GetAllConhecimentosbyAsync(int id);

        public Task<VagaConhecimento> GetIdVagaAndIdConhecimentoAsync(int idVaga, int idConhecimento);
    }
}
