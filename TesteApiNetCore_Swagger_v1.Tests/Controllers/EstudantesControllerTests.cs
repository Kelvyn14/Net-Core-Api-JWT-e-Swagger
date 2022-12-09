using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using TesteApiNetCore_Swagger_v1.Controllers;
using TesteApiNetCore_Swagger_v1.IServices;
using TesteApiNetCore_Swagger_v1.Service;
using Xunit;
using Xunit.Abstractions;

namespace TesteApiNetCore_Swagger_v1.Tests.Controllers
{
    public class EstudantesControllerTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public EstudantesControllerTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Iniciando os testes");
        }

        [Fact]
        public void ObterListagemDeUsuariosComSucesso()
        {
            // Arrange
            var expectedResult = 5;
            var service = new Mock<IEstudanteService>();
            var mockData = new List<Models.Estudante>() {
                new Models.Estudante() { EstudanteId = 1, Nome = "teste 1", Roll = "presidente" } ,
                new Models.Estudante() { EstudanteId = 2, Nome = "teste 2", Roll = "diretor" } ,
                new Models.Estudante() { EstudanteId = 3, Nome = "teste 3", Roll = "aluno" } ,
                new Models.Estudante() { EstudanteId = 4, Nome = "teste 4", Roll = "limpador de vidros" },
                new Models.Estudante() { EstudanteId = 4, Nome = "teste 5", Roll = "zelador" }
            };
            service.Setup(m => m.Gets()).Returns(mockData);
            var controller = new EstudantesController(service.Object);

            // Act
            var result = controller.Get();

            //Assert
            Assert.Equal(result.Count, expectedResult);
        }
    }
}
