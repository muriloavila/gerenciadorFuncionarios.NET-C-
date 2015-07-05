using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciadorFuncionarios
{
    class funcionario
    {
        private int id;
        private string nome;
        private string cargo;
        private string endereco;
        private string telefone;
        private int idade;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
    }
}
