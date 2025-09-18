using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using controle_estoque_core.Models;

namespace controle_estoque_core.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // Cada "DbSet" é como uma prateleira no nosso estoque para cada tipo de ingrediente
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
    

    }
