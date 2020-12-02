using ClienteFornecedor.Entidades.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClienteFornecedor.Contexto
{
    public class ClienteFornecedorContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Itens> Itens { get; set; }
        //construtor
        public ClienteFornecedorContext(DbContextOptions<ClienteFornecedorContext> options)
         : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Daniela\\source\\repos\\ClienteFornecedor\\ClienteFornecedor\\Scripts\\DBDados.mdf;Integrated Security=True;Connect Timeout=30");
        //}
    }
}
