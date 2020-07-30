using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Bank_Solution.Models
{
    public class DadosAcesso
    {
        public int Id { get; set; }
        public string NomeAcesso { get; set; }
        public int Senha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
