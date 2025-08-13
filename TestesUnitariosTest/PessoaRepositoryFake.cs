using TestesUnitarios.Interface.Repository;
using TestesUnitarios.Model;

namespace TestesUnitariosTest;

public class PessoaRepositoryFake() : IPessoaRepository
{
    private readonly List<Pessoa> _pessoas = new();
    
    public async Task<List<Pessoa>> GetPessoas()
    {
        await Task.Delay(10);
        
        return _pessoas;
    }

    public Task Inserir(Pessoa pessoa)
    {
        _pessoas.Add(pessoa);
        return Task.CompletedTask;
    }
}
