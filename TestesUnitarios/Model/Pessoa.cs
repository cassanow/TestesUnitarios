using System.ComponentModel.DataAnnotations;

namespace TestesUnitarios.Model;

public class Pessoa
{
    [Key]
    public int Id { get; set; }
    
    public string Nome { get; set; }
    
    public string Email { get; set; }
    
    public string Senha { get; set; }
}