using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Bank_Solution.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
