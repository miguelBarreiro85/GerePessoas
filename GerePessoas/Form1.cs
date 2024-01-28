using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;

namespace GerePessoas
{
    public partial class Form1 : Form
    {
        //Create a observable collection of Pessoas

        private BindingList<Pessoa> ocPessoas = new BindingList<Pessoa>();


        public Form1()
        {
            InitializeComponent();
            listBoxPessoas.DataSource = ocPessoas;
        }

        private void addAluno(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxMorada.Text == "" || textBoxCurso.Text == "" || textBoxNumAluno.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            ocPessoas.Add(new Aluno(textBoxNome.Text, dateTimePickerDataNascimento.Value, textBoxMorada.Text, textBoxCurso.Text, int.Parse(textBoxNumAluno.Text)));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPessoa_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxMorada.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            ocPessoas.Add(new Pessoa(textBoxNome.Text, dateTimePickerDataNascimento.Value, textBoxMorada.Text, "pessoa"));
        }

        private void buttonAddAlunoEspecial_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxMorada.Text == "" || textBoxCurso.Text == "" || textBoxNumAluno.Text == "" || textBoxDificuldade.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            ocPessoas.Add(new AlunoEspecial(textBoxNome.Text, dateTimePickerDataNascimento.Value, textBoxMorada.Text, textBoxCurso.Text, int.Parse(textBoxNumAluno.Text), textBoxDificuldade.Text));
        }

        private void buttonAddProf_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxMorada.Text == "" || textBoxDisciplina.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            ocPessoas.Add(new Professor(textBoxNome.Text, dateTimePickerDataNascimento.Value, textBoxMorada.Text, textBoxDisciplina.Text));
        }

        private void pessoasChanged(object sender, EventArgs e)
        {
            Pessoa currentPessoa = (Pessoa)listBoxPessoas.SelectedItem;
            richTextBoxInd.Clear();
            if (currentPessoa == null)
            {
                return;
            }
            switch (currentPessoa.GetType().Name)
            {
                case "Aluno":
                    Aluno currentAluno = (Aluno)currentPessoa;
                    richTextBoxInd.Text = currentAluno.toShow();
                    break;
                case "Professor":
                    Professor currentProfessor = (Professor)currentPessoa;
                    richTextBoxInd.Text = currentProfessor.toShow();
                    break;
                case "AlunoEspecial":
                    AlunoEspecial currentAlunoEspecial = (AlunoEspecial)currentPessoa;
                    richTextBoxInd.Text = currentAlunoEspecial.toShow();
                    break;
                 default:
                    richTextBoxInd.Text = currentPessoa.toShow();
                    break;
            }


        }

        private void buttonQueTipoDePessoa_Click(object sender, EventArgs e)
        {
            Pessoa currentPessoa = (Pessoa)listBoxPessoas.SelectedItem;
            labelQueTipoDePessoa.Text = currentPessoa.queTipoDePessoaSou();
        }

        private void buttonPontuar_Click(object sender, EventArgs e)
        {
            var selectedITem = listBoxPessoas.SelectedItem as Pessoa;
            selectedITem.Pontuacao += 1;
            listBoxPessoas.Refresh();
        }
    }
}
