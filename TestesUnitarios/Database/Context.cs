using Microsoft.EntityFrameworkCore;

namespace TestesUnitarios.Database;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }
}