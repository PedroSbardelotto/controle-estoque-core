using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_estoque_core.Models
{
    public class Produto
    {

        public int Id { get; set; }
        public required string Nome { get; set; }
        public required int Quantidade { get; set; }
        public required string Descricao { get; set; }
        public required string Tipo { get; set; }
        public required decimal Preco { get; set; } 
        public string Status 
        { 
            get
            {
                return Quantidade > 0 ? "Em Estoque" : "Sem Estoque";
            }
        }
    }
}
