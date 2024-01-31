using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO8
{
    internal class Pensao
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public int Quarto { get; set; }

        public Pensao(String nome, String email, int quarto)
        {
            this.Nome = nome;
            this.Email = email;
            this.Quarto = quarto;
        }
        public override string ToString()
        {
            return $"{Quarto}: {Nome}, {Email}";
        }

    }
}
