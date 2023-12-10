using Moq;
using UijobsApi.DAL.Repositories.Empresas;
using UijobsApi.DAL.Unit_of_Work;
using UijobsApi.Exceptions;
using UijobsApi.Services.Empresas;


namespace UijobsApi.Tests;

[TestClass]
public class Empresa
{
    private readonly Mock<IEmpresaRepository> _mockEmpresaRepository;
    private readonly Mock<IUnitOfWork> _mockUnitOfWork;
    private readonly EmpresaService _empresaService;


    [TestMethod]
    public async Task ReturnBadRequestWhenCnpjIsAllZero()
    {
        string cnpj = "00000000";
        await Assert.ThrowsExceptionAsync<BadRequestException>(() => _empresaService.ValidarCNPJ(cnpj));
    }

    [TestMethod]
    public async Task ReturnBadRequestWhenCnpjIsAllNine()
    {
        string cnpj = "99999999";
        await Assert.ThrowsExceptionAsync<BadRequestException>(() => _empresaService.ValidarCNPJ(cnpj));
    }


}