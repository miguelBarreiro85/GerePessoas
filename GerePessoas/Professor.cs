using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerePessoas
{
    internal class Professor : Pessoa
    {
        private string disciplina;

        public Professor(string nome, DateTime dataNascimento, string morada,string disciplina) : base(nome, dataNascimento,morada,"professor")
        {
            this.disciplina = disciplina;
        }

        new public string toShow()
        {
            return base.toShow() + "\n\tDisciplina: " + disciplina;
        }
    }
}
