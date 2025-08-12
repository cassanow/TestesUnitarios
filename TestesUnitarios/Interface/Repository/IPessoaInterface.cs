using TestesUnitarios.Model;

namespace TestesUnitarios.Interface.Repository;

public interface IPessoaInterface
{
    Task<List<Pessoa>> GetPessoas();
    
    Task Inserir(Pessoa pessoa);
}