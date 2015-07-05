using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace gerenciadorFuncionarios
{
    class dal
    {
        public void Insert(modelo mo)
        {
            string connString = "SERVER=localhost;DATABASE=dbteste;UID=root;PASSWORD=;";
            MySqlConnection conexao = new MySqlConnection(connString);
            try
            {
                conexao.Open();
                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO funcionario(nome, cargo, endereco, telefone, idade)VALUES('" +
                    mo.Nome + "', '" + mo.Cargo + "', '" + mo.Endereco + "', '" + mo.Telefone + "', '" + mo.Idade + "');";
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }
    }
}
