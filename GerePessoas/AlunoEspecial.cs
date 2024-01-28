using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerePessoas
{
    internal class AlunoEspecial : Aluno
    {
        private string dificuldade;
        public AlunoEspecial(string nome, DateTime dataNascimento, string morada, string curso, int numero, string dificuldade) : base(nome, dataNascimento, morada, curso, numero)
        {
            this.dificuldade = dificuldade;
        }

        new public string toShow()
        {
            return base.toShow() + "\n\tDificuldade: " + dificuldade;
        }
    }
}
