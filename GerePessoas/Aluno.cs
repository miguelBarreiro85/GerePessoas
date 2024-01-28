using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerePessoas
{
    internal class Aluno : Pessoa
    {
        public string curso;
        public int numero;

        public Aluno(string nome, DateTime dataDeNascimento, string morada, string curso, int numero)
            : base(nome, dataDeNascimento, morada, "aluno")
        {
 
            this.curso = curso;
            this.numero = numero;
        }

        new public string toShow()
        {
            return base.toShow() + "\n\tCurso: " + curso + "\n\tnumero: " + numero;
        }

    }

}
