using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.Servicos;
using minimal_api.vscode.Infraestrutura.Db;


namespace Test.Domain.Servicos;

[TestClass]
public sealed class VeiculosServicosTest
{
    public DbContexto CriarContextoTeste()
    {
        var builer = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        var configuration = builer.Build();

        return new DbContexto(configuration);
    
    }
    [TestMethod]
    public void TestandoSalvarVeiculo()
    {  // Arrange
        var contexto = CriarContextoTeste();
        contexto.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");
        var veiculo = new Veiculo();
        veiculo.Nome = "C4";
        veiculo.Marca = "Citroen";
        veiculo.Ano = 2000;

        
        var veiculoServico = new VeiculoServico(contexto);

        // Act
        veiculoServico.Incluir(veiculo);

        // Assert
        Assert.AreEqual(1, veiculoServico.Todos(1).Count());
    }
}
