using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinculocomUC5
{
    public partial class Form1 : Form
    {
        private OpenFileDialog Leitura = new OpenFileDialog();
        private SaveFileDialog Salvamento = new SaveFileDialog();
        private string caminho;
        protected Pessoa pessoa = null;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ao clucar, o codigo ira visualizar os dados
        /// </summary>
        /// <param name="sender">botao de btnDados</param>
        /// <param name="e">o evento de click</param>

        private void btnDados_Click(object sender, EventArgs e)
        {
            Leitura.Filter = "|*.txt";
            Leitura.Title = "Selecione o arquivo de dados";
            //vamos voltar nessa linha - 1
            //verificar se deu tudo certo ao clicar em ok, apos selecionar o dado
            //se ao obter o caminho o caminho deu certo,continua caso contrario encerra
            if (Leitura.ShowDialog() != DialogResult.OK) return;
            //obtendo o caminho do arquivo
            caminho = Leitura.FileName;
            //crie uma variavel, que o tipo é desconhecido
            try
            {
                //ao digitar o comando, lembre-se de clicar com x
                //depois em system.IO;
                //a criaçao de variavel com var, precisa da atribuicao na sequencia
                //o file, ira fazer a leitura dos dados dentro do arquivo que passei o caminho
                var textoLido = File.ReadAllText(caminho);
                //extrair texto
                string[] linhas = textoLido.ToString().Split('\n');
                for (int i = 0; i < linhas.Length; i = i + 4)
                {
                    string nome = linhas[i];
                    char sexo = linhas[i + 1].ToString()[0];
                    string escolaridade = linhas[i + 2];
                    string classe = linhas[i + 3];
                    Pessoa novapessoa = new Pessoa(nome, sexo, escolaridade, classe);
                    lboDados.Items.Add(novapessoa);
                }


            }
            // caso aconteça qualquer erro no try, vou pegar o erro
            catch (Exception erro)
            {
                //qualquer erro que aparecer, vou visualizar
                MessageBox.Show(erro.Message);
            }
        }

        /// <summary>
        /// pode modificar os dados, basta clicar no dado que deseja modificar, e clicar em ok, para salvar as modificações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

    

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (caminho == null) return;
            StreamWriter salvarArquivo = new StreamWriter(caminho);
            string texto = "";
            foreach (Pessoa pessoa in lboDados.Items)
            {
                texto += pessoa.Nome + "\n";
                texto += pessoa.Sexo == 'F' ? "Feminino" : "Masculino\n";
                texto += pessoa.Escolaridade;
                texto += pessoa.Classe + "\n";
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pessoa novapessoa;
            using (Cadastro cadastro = new Cadastro())
            {
                cadastro.ShowDialog();
                novapessoa = cadastro.pessoa;
            }
            if (novapessoa != null) return;
            lboDados.Items.Add(novapessoa);
            lboDados.Update();
        }

        private void btnSalvarComo_Click(object sender, EventArgs e)
        {
            if (lboDados.Items.Count == 0) return;
            Salvamento.Filter = "Arquivo |*.txt!*.txt";
            Salvamento.FileName = "Selecione o local para salvar o arquivo";
            if (Salvamento.ShowDialog() != DialogResult.OK &&
                Salvamento.FileName == null) return;
            FileStream abrirArquivo = Salvamento.OpenFile() as FileStream;
            StreamWriter salvandoArquivo = new StreamWriter(abrirArquivo);
            string texto = "";
            foreach (Pessoa pessoa in lboDados.Items)
            {
                texto += pessoa.Nome + "\n";
                texto += pessoa.Sexo == 'F' ? "Feminino" : "Masculino\n";
                texto += pessoa.Escolaridade;
                texto += pessoa.Classe + "\n";
            }
        }

        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pessoa AntigaPessoa = (sender as ListBox).SelectedItem as Pessoa;
            if (AntigaPessoa == null) return;
            Pessoa novapessoa;
            using (Cadastro cadastro = new Cadastro(AntigaPessoa))
            {
                cadastro.ShowDialog();
                novapessoa = cadastro.pessoa;
            }
            lboDados.ClearSelected();
            if (novapessoa == null)
                lboDados.Items.Remove(AntigaPessoa);
            else
            {
                for (int i = 0; i < lboDados.Items.Count; i++)
                {
                    if (lboDados.Items[i] == AntigaPessoa)
                    {
                        lboDados.Items[i] = novapessoa;
                        break;
                    }
                }
            }
            lboDados.Update();


        
    }

        private void btnObterDados_Click(object sender, EventArgs e)
        {
            Leitura.Filter = "|*.txt";
            Leitura.Title = "Selecione o arquivo de dados";
            //vamos voltar nessa linha - 1
            //verificar se deu tudo certo ao clicar em ok, apos selecionar o dado
            //se ao obter o caminho o caminho deu certo,continua caso contrario encerra
            if (Leitura.ShowDialog() != DialogResult.OK) return;
            //obtendo o caminho do arquivo
            caminho = Leitura.FileName;
            //crie uma variavel, que o tipo é desconhecido
            try
            {
                //ao digitar o comando, lembre-se de clicar com x
                //depois em system.IO;
                //a criaçao de variavel com var, precisa da atribuicao na sequencia
                //o file, ira fazer a leitura dos dados dentro do arquivo que passei o caminho
                var textoLido = File.ReadAllText(caminho);
                //extrair texto
                string[] linhas = textoLido.ToString().Split('\n');
                for (int i = 0; i < linhas.Length; i = i + 4)
                {
                    string nome = linhas[i];
                    char sexo = linhas[i + 1].ToString()[0];
                    string escolaridade = linhas[i + 2];
                    string classe = linhas[i + 3];
                    Pessoa novapessoa = new Pessoa(nome, sexo, escolaridade, classe);
                    lboDados.Items.Add(novapessoa);
                }


            }
            // caso aconteça qualquer erro no try, vou pegar o erro
            catch (Exception erro)
            {
                //qualquer erro que aparecer, vou visualizar
                MessageBox.Show(erro.Message);
            }
        }
    }
    }


