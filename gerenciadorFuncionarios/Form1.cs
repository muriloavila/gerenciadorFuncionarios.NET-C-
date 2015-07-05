using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gerenciadorFuncionarios
{
    
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listaFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //string de conexao com o banco de dados
            string connString = "SERVER=localhost;DATABASE=dbteste;UID=root;PASSWORD=;";
            //variavel de conexao
            MySqlConnection conexao = new MySqlConnection(connString);
            MySqlCommand comando = conexao.CreateCommand();
            //criação do comando
            comando.CommandText = "SELECT * FROM funcionario";
            //tentativa de abrir
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            //variavel de leitura de banco de Dados
            MySqlDataReader reader = comando.ExecuteReader();
            //adiciona uma linha com os valores das variaveis acima
            while (reader.Read())
            {
                dgFuncionario.Rows.Add(reader["idfuncionario"].ToString(),
                                        reader["nome"].ToString(),
                                        reader["cargo"].ToString(),
                                        reader["endereco"].ToString(),
                                        reader["telefone"].ToString(),
                                        reader["idade"].ToString());
            }
            conexao.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdd adicionar = new frmAdd();
            adicionar.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //limpa as linhas e refaz a leitura no banco apos uma alteração
            dgFuncionario.Rows.Clear();
            string connString = "SERVER=localhost;DATABASE=dbteste;UID=root;PASSWORD=;";
            MySqlConnection conexao = new MySqlConnection(connString);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM funcionario";
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                dgFuncionario.Rows.Add(reader["idfuncionario"].ToString(),
                                        reader["nome"].ToString(),
                                        reader["cargo"].ToString(),
                                        reader["endereco"].ToString(),
                                        reader["telefone"].ToString(),
                                        reader["idade"].ToString());
            }
            conexao.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            //Deleta o item pegando a linha que esta selecionada no DataGrid View
            string deleteItem = dgFuncionario.CurrentRow.Cells[0].Value.ToString();
            //string comando = "DELETE FROM funcionario WHERE idfuncionario = '" + deleteItem + "';";
            string connString = "SERVER=localhost;DATABASE=dbteste;UID=root;PASSWORD=;";
            MySqlConnection conexao = new MySqlConnection(connString);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM funcionario WHERE idfuncionario = '" + deleteItem + "';";
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                dgFuncionario.Refresh();
                MessageBox.Show(deleteItem + " Deletado");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //botão de busca
            string connString = "SERVER=localhost;DATABASE=dbteste;UID=root;PASSWORD=;";
            MySqlConnection conexao = new MySqlConnection(connString);
            MySqlCommand comando = conexao.CreateCommand();
            //faz a checagem para ver se há texto ou se a coluna possui algum valor
            if (cmbColunas.SelectedItem != null || txtBusca.Text != null) { 
            //o comando localiza no banco de dados
                comando.CommandText = "SELECT * FROM funcionario WHERE "+cmbColunas.SelectedItem+" LIKE '%"+txtBusca.Text+"%';";
            }
            else //caso não tenha nenhum valor no comboBox, ou se não tem nenhum texto na caixa de texto
            {
                comando.CommandText = "SELECT * FROM funcionario";
            }
            try
            {
                dgFuncionario.Rows.Clear();
                conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                //escreve no DataGrid segundo o camando
                while (reader.Read())
                {
                    dgFuncionario.Rows.Add(reader["idfuncionario"].ToString(),
                                        reader["nome"].ToString(),
                                        reader["cargo"].ToString(),
                                        reader["endereco"].ToString(),
                                        reader["telefone"].ToString(),
                                        reader["idade"].ToString());
                }
                    conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //pega o id da linha selecionada e envia para o formulario FRMUPDATE
            string idfuncionario = dgFuncionario.CurrentRow.Cells[0].Value.ToString();
            frmUpdate update = new frmUpdate(idfuncionario);
            update.ShowDialog();
           
        }
    }
}
