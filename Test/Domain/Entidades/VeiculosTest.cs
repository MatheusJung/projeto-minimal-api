using minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class VeiculosTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange
        var adm = new Veiculo();

        //Act
        adm.Id = 1;
        adm.Nome = "teste";
        adm.Marca = "teste";
        adm.Ano = 2000;

        //Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste", adm.Nome);
        Assert.AreEqual("teste", adm.Marca);
        Assert.AreEqual(2000, adm.Ano);
    }
}
