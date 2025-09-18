using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_estoque_core.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public required string NomeProduto { get; set; }
        public required int QuantidadeProduto { get; set; } 
        public required string NomeCliente { get; set; }

    }
}
