using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Bank_Solution.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Uf { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
