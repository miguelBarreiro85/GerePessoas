using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GerePessoas
{
    internal class Pessoa : INotifyPropertyChanged
    {
        public string nome;
        public DateTime dataDeNascimento;
        public string morada;
        private int pontuacao;
        public string tipoDePessoa;
        public int Pontuacao { get => pontuacao; set => SetField(ref pontuacao, value); }

        public event PropertyChangedEventHandler PropertyChanged;

        public Pessoa(string nome, DateTime dataDeNascimento, string morada, string tipoDePessoa)
        {
            this.nome = nome;
            this.dataDeNascimento = dataDeNascimento;
            this.morada = morada;
            pontuacao = 0;
            this.tipoDePessoa = tipoDePessoa;
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public int Idade()
        {
            //Return age check mont and day
            int age = DateTime.Now.Year - dataDeNascimento.Year;
            if (DateTime.Now.DayOfYear < dataDeNascimento.DayOfYear)
                age -= 1;
            return age;
        }

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public override string ToString()
        {
            return nome + " (" + Idade() + " anos) - " + morada + " - " + pontuacao + " pontos";
        }

        public string queTipoDePessoaSou()
        {
            return tipoDePessoa;
        }

        public string toShow()
        {
            return "Nome: " + nome + "\n\t" + "Idade: " + Idade() + "\n\t" + "Morada: " + morada + "\n\t" + "Pontuação: " + pontuacao;
        }


    }
}
