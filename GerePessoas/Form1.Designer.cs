using System.Collections.ObjectModel;

namespace GerePessoas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelMorada = new System.Windows.Forms.Label();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.listBoxPessoas = new System.Windows.Forms.ListBox();
            this.buttonAddAluno = new System.Windows.Forms.Button();
            this.textBoxNumAluno = new System.Windows.Forms.TextBox();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.textBoxDificuldade = new System.Windows.Forms.TextBox();
            this.labelNumeroAluno = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.labelDificuldade = new System.Windows.Forms.Label();
            this.buttonAddAlunoEspecial = new System.Windows.Forms.Button();
            this.buttonAddProf = new System.Windows.Forms.Button();
            this.buttonAddPessoa = new System.Windows.Forms.Button();
            this.buttonPontuar = new System.Windows.Forms.Button();
            this.labelDadosDoIndividuo = new System.Windows.Forms.Label();
            this.buttonQueTipoDePessoa = new System.Windows.Forms.Button();
            this.labelQueTipoDePessoa = new System.Windows.Forms.Label();
            this.richTextBoxInd = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 33);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(277, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(12, 72);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(277, 20);
            this.dateTimePickerDataNascimento.TabIndex = 2;
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(8, 118);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(43, 13);
            this.labelMorada.TabIndex = 3;
            this.labelMorada.Text = "Morada";
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(12, 134);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(277, 20);
            this.textBoxMorada.TabIndex = 4;
            // 
            // listBoxPessoas
            // 
            this.listBoxPessoas.FormattingEnabled = true;
            this.listBoxPessoas.Location = new System.Drawing.Point(311, 23);
            this.listBoxPessoas.Name = "listBoxPessoas";
            this.listBoxPessoas.Size = new System.Drawing.Size(450, 147);
            this.listBoxPessoas.TabIndex = 5;
            this.listBoxPessoas.SelectedIndexChanged += new System.EventHandler(this.pessoasChanged);
            // 
            // buttonAddAluno
            // 
            this.buttonAddAluno.Location = new System.Drawing.Point(11, 387);
            this.buttonAddAluno.Name = "buttonAddAluno";
            this.buttonAddAluno.Size = new System.Drawing.Size(82, 51);
            this.buttonAddAluno.TabIndex = 6;
            this.buttonAddAluno.Text = "Adicionar aluno";
            this.buttonAddAluno.UseVisualStyleBackColor = true;
            this.buttonAddAluno.Click += new System.EventHandler(this.addAluno);
            // 
            // textBoxNumAluno
            // 
            this.textBoxNumAluno.Location = new System.Drawing.Point(80, 196);
            this.textBoxNumAluno.Name = "textBoxNumAluno";
            this.textBoxNumAluno.Size = new System.Drawing.Size(209, 20);
            this.textBoxNumAluno.TabIndex = 7;
            this.textBoxNumAluno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(80, 231);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(209, 20);
            this.textBoxCurso.TabIndex = 8;
            // 
            // textBoxDisciplina
            // 
            this.textBoxDisciplina.Location = new System.Drawing.Point(80, 257);
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            this.textBoxDisciplina.Size = new System.Drawing.Size(209, 20);
            this.textBoxDisciplina.TabIndex = 9;
            // 
            // textBoxDificuldade
            // 
            this.textBoxDificuldade.Location = new System.Drawing.Point(80, 286);
            this.textBoxDificuldade.Name = "textBoxDificuldade";
            this.textBoxDificuldade.Size = new System.Drawing.Size(209, 20);
            this.textBoxDificuldade.TabIndex = 10;
            // 
            // labelNumeroAluno
            // 
            this.labelNumeroAluno.AutoSize = true;
            this.labelNumeroAluno.Location = new System.Drawing.Point(9, 196);
            this.labelNumeroAluno.Name = "labelNumeroAluno";
            this.labelNumeroAluno.Size = new System.Drawing.Size(52, 13);
            this.labelNumeroAluno.TabIndex = 11;
            this.labelNumeroAluno.Text = "Nº Aluno:";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(8, 231);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(37, 13);
            this.labelCurso.TabIndex = 12;
            this.labelCurso.Text = "Curso:";
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.Location = new System.Drawing.Point(9, 257);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(55, 13);
            this.labelDisciplina.TabIndex = 13;
            this.labelDisciplina.Text = "Disciplina:";
            // 
            // labelDificuldade
            // 
            this.labelDificuldade.AutoSize = true;
            this.labelDificuldade.Location = new System.Drawing.Point(9, 286);
            this.labelDificuldade.Name = "labelDificuldade";
            this.labelDificuldade.Size = new System.Drawing.Size(63, 13);
            this.labelDificuldade.TabIndex = 14;
            this.labelDificuldade.Text = "Dificuldade:";
            // 
            // buttonAddAlunoEspecial
            // 
            this.buttonAddAlunoEspecial.Location = new System.Drawing.Point(99, 387);
            this.buttonAddAlunoEspecial.Name = "buttonAddAlunoEspecial";
            this.buttonAddAlunoEspecial.Size = new System.Drawing.Size(82, 51);
            this.buttonAddAlunoEspecial.TabIndex = 15;
            this.buttonAddAlunoEspecial.Text = "Adicionar aluno especial";
            this.buttonAddAlunoEspecial.UseVisualStyleBackColor = true;
            this.buttonAddAlunoEspecial.Click += new System.EventHandler(this.buttonAddAlunoEspecial_Click);
            // 
            // buttonAddProf
            // 
            this.buttonAddProf.Location = new System.Drawing.Point(187, 387);
            this.buttonAddProf.Name = "buttonAddProf";
            this.buttonAddProf.Size = new System.Drawing.Size(82, 51);
            this.buttonAddProf.TabIndex = 16;
            this.buttonAddProf.Text = "Adicionar professor";
            this.buttonAddProf.UseVisualStyleBackColor = true;
            this.buttonAddProf.Click += new System.EventHandler(this.buttonAddProf_Click);
            // 
            // buttonAddPessoa
            // 
            this.buttonAddPessoa.Location = new System.Drawing.Point(12, 358);
            this.buttonAddPessoa.Name = "buttonAddPessoa";
            this.buttonAddPessoa.Size = new System.Drawing.Size(257, 23);
            this.buttonAddPessoa.TabIndex = 17;
            this.buttonAddPessoa.Text = "Adicionar pessoa";
            this.buttonAddPessoa.UseVisualStyleBackColor = true;
            this.buttonAddPessoa.Click += new System.EventHandler(this.buttonAddPessoa_Click);
            // 
            // buttonPontuar
            // 
            this.buttonPontuar.Location = new System.Drawing.Point(311, 176);
            this.buttonPontuar.Name = "buttonPontuar";
            this.buttonPontuar.Size = new System.Drawing.Size(450, 23);
            this.buttonPontuar.TabIndex = 18;
            this.buttonPontuar.Text = "Pontuar";
            this.buttonPontuar.UseVisualStyleBackColor = true;
            this.buttonPontuar.Click += new System.EventHandler(this.buttonPontuar_Click);
            // 
            // labelDadosDoIndividuo
            // 
            this.labelDadosDoIndividuo.AutoSize = true;
            this.labelDadosDoIndividuo.Location = new System.Drawing.Point(308, 203);
            this.labelDadosDoIndividuo.Name = "labelDadosDoIndividuo";
            this.labelDadosDoIndividuo.Size = new System.Drawing.Size(101, 13);
            this.labelDadosDoIndividuo.TabIndex = 19;
            this.labelDadosDoIndividuo.Text = "Dados do Indivíduo";
            // 
            // buttonQueTipoDePessoa
            // 
            this.buttonQueTipoDePessoa.Location = new System.Drawing.Point(311, 372);
            this.buttonQueTipoDePessoa.Name = "buttonQueTipoDePessoa";
            this.buttonQueTipoDePessoa.Size = new System.Drawing.Size(450, 23);
            this.buttonQueTipoDePessoa.TabIndex = 21;
            this.buttonQueTipoDePessoa.Text = "Que tipo de pessoa sou?";
            this.buttonQueTipoDePessoa.UseVisualStyleBackColor = true;
            this.buttonQueTipoDePessoa.Click += new System.EventHandler(this.buttonQueTipoDePessoa_Click);
            // 
            // labelQueTipoDePessoa
            // 
            this.labelQueTipoDePessoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelQueTipoDePessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQueTipoDePessoa.Location = new System.Drawing.Point(308, 406);
            this.labelQueTipoDePessoa.Name = "labelQueTipoDePessoa";
            this.labelQueTipoDePessoa.Size = new System.Drawing.Size(453, 35);
            this.labelQueTipoDePessoa.TabIndex = 22;
            this.labelQueTipoDePessoa.Text = "label1";
            this.labelQueTipoDePessoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQueTipoDePessoa.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBoxInd
            // 
            this.richTextBoxInd.Location = new System.Drawing.Point(311, 219);
            this.richTextBoxInd.Name = "richTextBoxInd";
            this.richTextBoxInd.Size = new System.Drawing.Size(450, 147);
            this.richTextBoxInd.TabIndex = 23;
            this.richTextBoxInd.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxInd);
            this.Controls.Add(this.labelQueTipoDePessoa);
            this.Controls.Add(this.buttonQueTipoDePessoa);
            this.Controls.Add(this.labelDadosDoIndividuo);
            this.Controls.Add(this.buttonPontuar);
            this.Controls.Add(this.buttonAddPessoa);
            this.Controls.Add(this.buttonAddProf);
            this.Controls.Add(this.buttonAddAlunoEspecial);
            this.Controls.Add(this.labelDificuldade);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.labelNumeroAluno);
            this.Controls.Add(this.textBoxDificuldade);
            this.Controls.Add(this.textBoxDisciplina);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.textBoxNumAluno);
            this.Controls.Add(this.buttonAddAluno);
            this.Controls.Add(this.listBoxPessoas);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.ListBox listBoxPessoas;
        private System.Windows.Forms.Button buttonAddAluno;
        private System.Windows.Forms.TextBox textBoxNumAluno;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.TextBox textBoxDisciplina;
        private System.Windows.Forms.TextBox textBoxDificuldade;
        private System.Windows.Forms.Label labelNumeroAluno;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.Label labelDificuldade;
        private System.Windows.Forms.Button buttonAddAlunoEspecial;
        private System.Windows.Forms.Button buttonAddProf;
        private System.Windows.Forms.Button buttonAddPessoa;
        private System.Windows.Forms.Button buttonPontuar;
        private System.Windows.Forms.Label labelDadosDoIndividuo;
        private System.Windows.Forms.Button buttonQueTipoDePessoa;
        private System.Windows.Forms.Label labelQueTipoDePessoa;
        private System.Windows.Forms.RichTextBox richTextBoxInd;

    }
}

