using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinculocomUC5
{
    public partial class Cadastro : Form
    {
        private Pessoa _pessoa;

        public Cadastro()
        {
            InitializeComponent();
            btnExcluir.Enabled = false;
            btnAtualizar.Text = "Inserir";
        }

        public Cadastro(Pessoa pessoa)
        {
            InitializeComponent();
            _pessoa = pessoa;
            txtNome.Text = pessoa.Nome;
            txtEscolaridade.Text = pessoa.Escolaridade;
            radioButton1.Checked = pessoa.Sexo == 'M';
            radioButton2.Checked = pessoa.Sexo == 'F';
            cboClasse.SelectedItem = pessoa.Classe;

        }

        public Pessoa pessoa { get { return _pessoa; } }


    

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            char sexo = radioButton2.Checked ? 'M' : 'F';
            string escolaridade = txtEscolaridade.Text;
            string classe = cboClasse.SelectedItem as string;
            if (_pessoa == null)
                _pessoa = new Pessoa(nome, sexo, escolaridade, classe);
            else
                _pessoa.atualizarCampos(nome, escolaridade, sexo, classe);
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _pessoa = null;
            Close();
        }
    }
}
