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
        private OpenFileDialog leitura = new OpenFileDialog();
        private SaveFileDialog salvamento = new SaveFileDialog();
        private string caminho;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ao clicar, o codigo ira visualizar os dados
        /// </summary>
        /// <param name="sender">Botão de btnObterDados</param>
        /// <param name="e">o evento de clik</param>

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnObterDados_Click(object sender, EventArgs e)
        {
            //Vamos voltar nessa linha - 1
            leitura.Title = "Selecione o arquivo que contem os dados";
            // Verificar se deu tudo certo ao clicar em ok após selecionar o dado
            // Se ao obter o caminho o caminho deu certo, continua, caso contrario encerra
            if (leitura.ShowDialog() != DialogResult.OK) return;
            //Obtendo o caminho do arquivo
            caminho = leitura.FileName;
            //Tenta executar o trecho do codigo
            try
            {
                // ao digitar o camndo, lembre-se de clicar na lampada com x
                //Depois em using System.IO;
                // A criação de variavel com var, precisa da atribuição na sequencia
                //O File ira fazer a leitura dos dados dentro do arquivo que passei o caminho
                var textoLido = File.ReadAllText(caminho);
                //Extrair texto e coloca dentro do vetor
                string[] linhas = textoLido.ToString().Split('\n');
                //for (int i=0; i < linhas.lenght;i++)
                foreach (string linha in linhas) lboDados.Items.Add(linha);


            }
            // caso qualquer erro no try, vou pegar esse erro
            catch (Exception erro)
            {
                MessageBox.Show("erro.Message");
            }
        }
    }
}
