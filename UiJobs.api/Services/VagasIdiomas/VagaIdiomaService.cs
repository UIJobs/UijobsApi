﻿using UijobsApi.DAL.Repositories.VagasConhecimentos;
using UijobsApi.DAL.Repositories.VagasIdiomas;
using UijobsApi.DAL.Unit_of_Work;
using UIJobsAPI.Exceptions;
using UIJobsAPI.Models;

namespace UijobsApi.Services.VagasIdiomas
{
    public class VagaIdiomaService : IVagaIdiomaService
    {
        private readonly IVagaIdiomaRepository _vagaIdiomaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public VagaIdiomaService(IVagaIdiomaRepository vagaIdiomaRepository, IUnitOfWork unitOfWork)
        {
            _vagaIdiomaRepository = vagaIdiomaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<VagaIdioma> AddVagaIdiomaAsync(VagaIdioma novaVagaIdioma)
        {
            VagaIdioma vagaIdiomaExistente = await _vagaIdiomaRepository.GetVagaIdiomaByIdAsync(novaVagaIdioma.idVagas);
            if (vagaIdiomaExistente != null && vagaIdiomaExistente.Equals(novaVagaIdioma))
            {
                // bad request exception \/
                throw new Exception("Já existe uma Vaga cadastrado com esse Id.");
            }
            VagaIdioma vagaIdioma = await _vagaIdiomaRepository.AddVagaIdiomaAsync(novaVagaIdioma);
            await _unitOfWork.SaveChangesAsync();
            return vagaIdioma;
        }

        public async Task<IEnumerable<VagaIdioma>> GetAllVagaIdiomaAsync()
        {
            return await _vagaIdiomaRepository.GetAllVagaIdiomaAsync();
        }

        public async Task<VagaIdioma> GetVagaIdiomaByIdAsync(int id)
        {
            VagaIdioma vagaIdioma = await _vagaIdiomaRepository.GetVagaIdiomaByIdAsync(id);

            if (vagaIdioma == null)
            {
                throw new NotFoundException("vaga Idioma");
            }

            return vagaIdioma;
        }

        public async Task<List<VagaIdioma>> GetAllIdiomasbyIdAsync(int id)
        {
            List<VagaIdioma> vagaIdioma = await _vagaIdiomaRepository.GetAllIdiomasbyAsync(id);

            if (vagaIdioma == null)
            {
                throw new NotFoundException("vaga Idioma");
            }

            return vagaIdioma;
        }

        public async Task DeleteVagaIdiomaByIdAsync(int idVaga, int idIdioma)
        {
            var vagaIdioma = await _vagaIdiomaRepository.GetIdVagaAndIdIdiomaAsync(idVaga, idIdioma);

            if (vagaIdioma is null)
            {
                throw new NotFoundException("Vaga Idioma com id não existe");
            }
            _vagaIdiomaRepository.DeleteVagaIdiomaByIdAsync(idVaga, idIdioma);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}