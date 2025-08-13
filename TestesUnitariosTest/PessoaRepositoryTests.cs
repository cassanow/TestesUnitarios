
using TestesUnitarios.Model;

namespace TestesUnitariosTest;

public class PessoaRepositoryTests
{
    [Fact]
    public void AdicionarPessoa_DeveAdicionarQuandoTudoValido()
    {
        var repository = new PessoaRepositoryFake();
        
        var pessoa = new Pessoa {Id = 1, Nome = "Arthur", Email = "arthur@gmail.com", Senha = "123456"};
        
        repository.Inserir(pessoa);
        
        Assert.NotNull(pessoa);
        Assert.Equal("Arthur", pessoa.Nome);
        Assert.Equal("arthur@gmail.com", pessoa.Email);
        Assert.Equal("123456", pessoa.Senha);
    }

    [Fact]
    public async Task GetPessoas_DeveRetornarListaDePessoas()
    {
        var repository = new PessoaRepositoryFake();
        repository.Inserir(new Pessoa {Id = 2, Nome = "Santos", Email = "santos@gmail.com", Senha = "123456"});
        repository.Inserir(new Pessoa {Id = 3, Nome = "Tottenham", Email = "spurs@gmail.com", Senha = "123456"});

        
        
        var resultado =  await repository.GetPessoas();
        
        Assert.NotNull(resultado);
        Assert.Contains(resultado, r => r.Nome == "Santos");
        Assert.Contains(resultado, r => r.Nome == "Tottenham");
        
    }
}