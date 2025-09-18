using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_estoque_core.Models
{
  public class User
    {
     public int Id { get; set; }
     public required string Nome { get; set; }
     public required string Email { get; set; }
     public required string Tipo { get; set; }
     public required bool Status { get; set; } // "bool" é ótimo para Ativo/Inativo
    }
}
