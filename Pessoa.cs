using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinculocomUC5
{
    internal class Pessoa
    {
        // private -> este cara foca vosoveç apenas no Pessoa.cs
        private string _nome;
        private char _sexo;
        private string _escolaridade;
        private string _classe;
        /// <summary>
        /// construindo a identidade em outro codigo
        /// </summary>
        /// <param name="nome">Nome da pessoa da base de dados</param>
        /// <param name="sexo">Sexo da pessoa da base de dados</param>
        /// <param name="escolaridade">Escolaridade da pessoa da base de dados</param>
        /// <param name="classe">Classe da pessoa da base de dados</param>
        // public -> este construtor fica visivel para todos
        public Pessoa(string nome, char sexo, string escolaridade, string classe)
        {
            this._nome = nome;
            this. _sexo = sexo;
            this._escolaridade = escolaridade;
            this._classe = classe;
        }
    }
}
