using UijobsApi.DAL.Repositories.CurriculosConhecimentos;
using UijobsApi.DAL.Repositories.Cursos;
using UijobsApi.DAL.Unit_of_Work;
using UIJobsAPI.Exceptions;
using UIJobsAPI.Models;

namespace UijobsApi.Services.CurriculosConhecimentos
{
    public class CurriculoConhecimentoService : ICurriculoConhecimentoService
    {
        private readonly ICurriculoConhecimentoRepository _curriculoConhecimentoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CurriculoConhecimentoService(ICurriculoConhecimentoRepository curriculoConhecimentoRepository, IUnitOfWork unitOfWork)
        {
            _curriculoConhecimentoRepository = curriculoConhecimentoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CurriculoConhecimento> AddCurriculoConhecimentoAsync(CurriculoConhecimento novoCurriculoConhecimento)
        {
            CurriculoConhecimento curriConheExistente = await _curriculoConhecimentoRepository.GetCurriculoConhecimentoByIdAsync(novoCurriculoConhecimento.idCurriculo, novoCurriculoConhecimento.idConhecimentos);
            if (curriConheExistente != null && curriConheExistente.Equals(novoCurriculoConhecimento))
            {
                // bad request exception \/
                throw new Exception("Já existe um curso cadastrado com esse Id");
            }
            CurriculoConhecimento curriculoConhecimento = await _curriculoConhecimentoRepository.AddCurriculoConhecimentoAsync(novoCurriculoConhecimento);
            await _unitOfWork.SaveChangesAsync();
            return curriculoConhecimento;
        }

        public async Task DeleteCurriculoConhecimentoByIdAsync(int idCurriculo, int idConhecimento)
        {
            var curriculoConhecimento = await _curriculoConhecimentoRepository.GetCurriculoConhecimentoByIdAsync(idCurriculo, idConhecimento);

            if (curriculoConhecimento == null)
            {
                throw new NotFoundException("BeneficioVaga com id não existe");
            }

            await _curriculoConhecimentoRepository.DeleteCurriculoConhecimentoByIdAsync(idCurriculo, idConhecimento);
            await _unitOfWork.SaveChangesAsync();
        }



        public async Task<IEnumerable<CurriculoConhecimento>> GetAllCurriculoConhecimentosAsync()
        {
            return await _curriculoConhecimentoRepository.GetAllCurriculoConhecimentosAsync();
        }

        public async Task<CurriculoConhecimento> GetCurriculoConhecimentoByIdAsync(int idCurriculo, int idConhecimento)
        {
            CurriculoConhecimento curriculoConhecimento = await _curriculoConhecimentoRepository.GetCurriculoConhecimentoByIdAsync(idCurriculo, idConhecimento);

            if (curriculoConhecimento == null)
            {
                throw new NotFoundException("Curriculo Conhecimento");
            }

            return curriculoConhecimento;
        }

        public async Task<List<CurriculoConhecimento>> GetAllConhecimentobyIdAsync(int id)
        {
            List<CurriculoConhecimento> curriculoConhecimento = await _curriculoConhecimentoRepository.GetAllConhecimentosbyAsync(id);

            if (curriculoConhecimento == null)
            {
                throw new NotFoundException("vaga Idioma");
            }

            return curriculoConhecimento;
        }
    }
}
