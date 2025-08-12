using TestesUnitarios.Model;

namespace TestesUnitarios.Interface.Repository;

public interface IPessoaRepository
{
    Task<List<Pessoa>> GetPessoas();
    
    Task Inserir(Pessoa pessoa);
}