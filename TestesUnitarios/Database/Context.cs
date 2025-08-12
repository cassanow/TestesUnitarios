using Microsoft.EntityFrameworkCore;
using TestesUnitarios.Model;

namespace TestesUnitarios.Database;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }
    
    public DbSet<Pessoa> Pessoas { get; set; }
    
}