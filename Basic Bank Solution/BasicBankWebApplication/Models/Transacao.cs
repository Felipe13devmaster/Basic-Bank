using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Bank_Solution.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

        public int ContaId { get; set; }
        public Conta Conta { get; set; }
    }
}
