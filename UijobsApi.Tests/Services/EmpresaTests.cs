using Moq;
using UijobsApi.DAL.Repositories.Empresas;
using UijobsApi.DAL.Unit_of_Work;
using UijobsApi.Services.Empresas;


namespace UijobsApi.Tests;

[TestClass]
public class Empresa
{
    private readonly Mock<IEmpresaRepository> _mockEmpresaRepository;
    private readonly Mock<IUnitOfWork> _mockUnitOfWork;
    private readonly EmpresaService _EmpresaService;


    [TestMethod]
    public void TestMethod1()
    {
    }
}
