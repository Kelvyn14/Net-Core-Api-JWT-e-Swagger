using Microsoft.Extensions.DependencyInjection;
using Moq;
using TesteApiNetCore_Swagger_v1.Controllers;
using TesteApiNetCore_Swagger_v1.IServices;
using TesteApiNetCore_Swagger_v1.Service;
using Xunit.Abstractions;

namespace TesteApiNetCore_Swagger_v1.Tests.Controllers
{
    public class EstudantesControllerTest
    {
        private readonly ITestOutputHelper _testOutputHelper;
        //Mock<IEstudanteService> estudanteMoq = new Mock<IEstudanteService>();
        private readonly IEstudanteService _estudanteService;
        public ServiceProvider ServiceProvider { get; private set; }

        readonly ServiceCollection _services;

        public EstudantesControllerTest(ITestOutputHelper testOutputHelper)
        {

            // Cria o ServiceProvider.
            _services = new ServiceCollection();
            _estudanteService = ServiceProvider.GetService<IEstudanteService>();
            _services.BuildServiceProvider();
            using var scope = ServiceProvider.CreateScope();
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Iniciando os testes");
        }

        [Fact]
        public void ObterListagemDeUsuariosComSucesso()
        {
            // Arrange
            //var controller = new EstudantesController(estudanteMoq.Object);
            var expectedResult = 10;
            // Act
            var result = _estudanteService.Gets();

            //Assert
            Assert.Equal(result.Count, expectedResult);
        }
    }
}
