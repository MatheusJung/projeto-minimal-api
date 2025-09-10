using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.Servicos;
using minimal_api.vscode.Infraestrutura.Db;


namespace Test.Domain.Servicos;

[TestClass]
public sealed class AdministradorServicosTest
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
    public void TestandoSalvarAdministrador()
    {  // Arrange
        var contexto = CriarContextoTeste();
        contexto.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores");
        var adm = new Administrador();
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        var administradorServico = new AdministradorServico(contexto);

        // Act
        administradorServico.Incluir(adm);
        // Assert
        Assert.AreEqual(1, administradorServico.Todos(1).Count());
    }
}
