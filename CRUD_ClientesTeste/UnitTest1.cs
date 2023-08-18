using CRUD_Clientes.Controllers;
using CRUD_Clientes.Models;

namespace CRUD_ClientesTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Deve_Retornar_Verdadeiro_Quando_Cliente_Model_Estiver_Tudo_Preenchido()
        {
            //Arrange
            var model = new Cliente_Model();
            model.Nome = "Lucas";
            model.Sobrenome = "Prado";
            model.DataNascimento = new DateTime(1999,06,20);
            model.Endereco = "Rua 10 - Jales-SP";
            model.Numero = "1688";
            model.Codigo_Genero = 1;

            //Act
            var result = model.ValidaVazioNulo();

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Deve_Retornar_Falso_Quando_Cliente_Model_Não_Estiver_Tudo_Preenchido()
        {
            //Arrange
            var model = new Cliente_Model();
            model.Nome = "";
            model.Sobrenome = "Prado";
            model.DataNascimento = new DateTime(1999, 06, 20);
            model.Endereco = "Rua 10 - Jales-SP";
            model.Numero = "1688";
            model.Codigo_Genero = 1;

            //Act
            var result = model.ValidaVazioNulo();

            //Assert
            Assert.IsFalse(result);
        }
    }
}