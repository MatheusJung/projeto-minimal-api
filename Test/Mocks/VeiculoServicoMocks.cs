using minimal_api.Dominio.DTOs;
using minimal_api.Dominio.Entidades;
using minimal_api.Infraestrutura.Interfaces;

namespace Test.Mocks;

public class VeiculoServicoMocks : IVeiculoServico
{
    private static List<Veiculo> veiculos = new List<Veiculo>();

    public void Apagar(Veiculo veiculo)
    {
        veiculos.Remove(veiculo);
    }

    public void Atualizar(Veiculo veiculo)
    {
        var index = veiculos.IndexOf(veiculo);
        if (index > -1)
        {
            veiculos[index].Nome = "Teste1";
            veiculos[index].Marca = "Teste2";
            veiculos[index].Ano = 2000;    
        }
    }

    public Veiculo? BuscaPorId(int id)
    {
        return veiculos.Find(x => x.Id == id);
    }

    public void Incluir(Veiculo veiculo)
    {
        veiculo.Id = veiculos.Count + 1;
        veiculos.Add(veiculo);
    }

    public List<Veiculo>? Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        return veiculos;
    }
}