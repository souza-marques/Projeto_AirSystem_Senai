using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Senai.Models
{
   public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public DateTime Nascimento { get; set; }
        public int Numero { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public bool Admin { get; set; }
    }
}
