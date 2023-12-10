using UijobsApi.DAL.Repositories.Empresas;
using UijobsApi.DAL.Unit_of_Work;
using UIJobsAPI.Exceptions;
using UIJobsAPI.Models;

namespace UijobsApi.Services.Empresas
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IUnitOfWork _unitOfWork;
        private object _context;

        public EmpresaService(IEmpresaRepository empresaRepository, IUnitOfWork unitOfWork)
        {
            _empresaRepository = empresaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Empresa> AddEmpresaAsync(Empresa novaEmpresa)
        {
            Empresa empresaExistente = await _empresaRepository.GetEmpresaByIdAsync(novaEmpresa.idEmpresa);
            
            if (empresaExistente != null && empresaExistente.Equals(novaEmpresa))
            {
                // bad request exception \/
                throw new Exception("Já existe uma empresa Cadastrada com esse perfil.");
            }
            if(!IsCnpjValido(novaEmpresa.cnpj))
            {
                throw new Exception("CNPJ inválido!");
            }
            Empresa empresa = await _empresaRepository.AddEmpresaAsync(novaEmpresa);
            await _unitOfWork.SaveChangesAsync();
            return empresa;
        }

        public async Task DeleteEmpresaAsync(int id)
        {
            Empresa empresa = await _empresaRepository.GetEmpresaByIdAsync(id);

            if (empresa is null)
            {
                throw new NotFoundException("Candidato com id não existe");
            }
            _empresaRepository.DeleteEmpresaAsync(empresa);
            await _unitOfWork.SaveChangesAsync();
        }


        public async Task<Empresa> GetEmpresaByIdAsync(int id)
        {
            Empresa empresa = await _empresaRepository.GetEmpresaByIdAsync(id);

            if (empresa == null)
            {
                throw new NotFoundException("Empresa");
            }

            return empresa;
        }

        private bool IsCnpjValido(string cnpj)
        {
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            if (string.IsNullOrWhiteSpace(cnpj) || cnpj.Length != 14)
            {
                return false;
            }

            int[] digitos = cnpj.Select(d => int.Parse(d.ToString())).ToArray();

            int soma = 0;
            int resto;

            // Calcula o primeiro dígito verificador
            for (int i = 0; i < 12; i++)
            {
                soma += digitos[i] * (13 - i);
            }

            resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            if (digitos[12] != digitoVerificador1)
            {
                return false;
            }

            soma = 0;

            // Calcula o segundo dígito verificador
            for (int i = 0; i < 13; i++)
            {
                soma += digitos[i] * (14 - i);
            }

            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            return digitos[13] == digitoVerificador2;
        }

    }
}
