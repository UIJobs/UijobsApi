using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;
using UijobsApi.DAL.Repositories.EnderecoEmpresas;
using UijobsApi.DAL.Unit_of_Work;
using UIJobsAPI.Exceptions;
using UIJobsAPI.Models;

namespace UijobsApi.Services.EnderecoEmpresas
{
    public class EnderecoEmpresaService : IEnderecoEmpresaService
    {
        private readonly IEnderecoEmpresaRepository _enderecoEmpresaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EnderecoEmpresaService(IEnderecoEmpresaRepository enderecoEmpresaRepository, IUnitOfWork unitOfWork)
        {
            _enderecoEmpresaRepository = enderecoEmpresaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<EnderecoEmpresa> AddEnderecoEmpresaAsync(EnderecoEmpresa novoEnderecoEmpresa)
        {
            EnderecoEmpresa enderecoEmpresaExistente = await _enderecoEmpresaRepository.GetEnderecoEmpresaByIdAsync(novoEnderecoEmpresa.idEmpresa);

            if (enderecoEmpresaExistente != null && enderecoEmpresaExistente.Equals(novoEnderecoEmpresa))
            {
                // bad request exception \/
                throw new Exception("Já existe uma empresa com esse id endereco Cadastrado.");
            }
            //condição pra saber se todos os números são iguais ao primeiro
            if (!ValidaCEP(novoEnderecoEmpresa.cep))
            {
                throw new Exception("CEP inválido");
            }
            EnderecoEmpresa enderecoEmpresa = await _enderecoEmpresaRepository.AddEnderecoEmpresaAsync(novoEnderecoEmpresa);
            await _unitOfWork.SaveChangesAsync();
            return enderecoEmpresa;
        }

        public async Task DeleteEnderecoEmpresaAsync(int id)
        {
            EnderecoEmpresa enderecoEmpresa = await _enderecoEmpresaRepository.GetEnderecoEmpresaByIdAsync(id);

            if (enderecoEmpresa is null)
            {
                throw new NotFoundException("Endereco com id não existe");
            }
            _enderecoEmpresaRepository.DeleteEnderecoEmpresaAsync(enderecoEmpresa);
            await _unitOfWork.SaveChangesAsync();
        }


        public async Task<EnderecoEmpresa> GetEnderecoEmpresaByIdAsync(int id)
        {
            EnderecoEmpresa enderecoEmpresa = await _enderecoEmpresaRepository.GetEnderecoEmpresaByIdAsync(id);

            if (enderecoEmpresa == null)
            {
                throw new NotFoundException("Endereco Empresa");
            }

            return enderecoEmpresa;
        }

        public bool ValidaCEP(string cep)
        {
            Regex Rgx = new Regex(@"^(?!0+$|9+$)\d{8}$");
            return Rgx.IsMatch(cep);
        }

    }
}
