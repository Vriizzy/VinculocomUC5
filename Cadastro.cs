using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinculocomUC5
{
    public partial class Cadastro : Form
    {
        private Pessoa __pessoa;
        public Cadastro(Pessoa pessoa)
        {
           
            InitializeComponent();
            __pessoa = pessoa;
            txtNome.Text = pessoa.Nome;
            txtEscolaridade.Text = pessoa.Escolaridade;
            radioButton1.Checked = pessoa.Sexo is 'F';
            radioButton2.Checked = pessoa.Sexo is 'M';
            cboClasse.SelectedItem = pessoa.Classe.Substring(0, 8);

        }
        public Pessoa pessoa { get { return __pessoa; } }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            char sexo = radioButton1.Checked ? 'F' : 'M';
            string escolaridade = txtEscolaridade.Text;
            string classe = cboClasse.SelectedItem as string;
            __pessoa.atualizarCampos(nome, escolaridade, sexo, classe);
            Close();
        }
    }
}
