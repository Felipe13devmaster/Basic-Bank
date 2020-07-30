using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Bank_Solution.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<DadosAcesso> DadosAcessos { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            contextOptionsBuilder.UseSqlServer("Data Source=LAPTOP-JK3T3A00;Initial Catalog=BasicBank;Integrated Security=True;Pooling=False");
        }
    }
}
