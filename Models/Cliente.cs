using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace controle_estoque_core.Models{

public class Cliente
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string CNPJ { get; set; }
    public required string Telefone { get; set; }
    public required string Email { get; set; }
    public required string Endereco { get; set; }
}
}