using Microsoft.EntityFrameworkCore;
using TestesUnitarios.Database;
using TestesUnitarios.Interface.Repository;
using TestesUnitarios.Model;

namespace TestesUnitarios.Repository;

public class PessoaRepository : IPessoaRepository
{
    private readonly Context _context;

    public PessoaRepository(Context context)
    {
        _context = context;
    }
    
    public async Task<List<Pessoa>> GetPessoas()
    {
        return await _context.Pessoas.ToListAsync();
    }

    public async Task Inserir(Pessoa pessoa)
    {
        _context.Pessoas.Add(pessoa);
        await _context.SaveChangesAsync();
    }
}