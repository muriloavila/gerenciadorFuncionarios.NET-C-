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
    public partial class frmUpdate : Form
    {
        public frmUpdate(string idfuncionario)
        {
            InitializeComponent();
            string connString = "SERVER=localhost;DATABASE=dbteste;UID=root;PASSWORD=;";
            MySqlConnection conexao = new MySqlConnection(connString);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM funcionario WHERE idfuncionario = '"+idfuncionario+"';";
            try
            {
                conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lblID.Text = reader["idfuncionario"].ToString();
                    txtUptNome.Text = reader["nome"].ToString();
                    txtUptCargo.Text = reader["cargo"].ToString();
                    txtUptEnd.Text = reader["endereco"].ToString();
                    txtUptTel.Text = reader["telefone"].ToString();
                    numUptIdade.Value = Convert.ToInt16(reader["idade"].ToString());
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
                     
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connString = "SERVER=localhost;DATABASE=dbteste;UID=root;PASSWORD=;";
            MySqlConnection conexao = new MySqlConnection(connString);
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE funcionario SET nome = '"+txtUptNome.Text+
                                    "', cargo = '"+txtUptCargo.Text+"', endereco = '"+txtUptEnd.Text+"', telefone = '"+
                                    txtUptTel.Text+"', idade = '"+numUptIdade.Value+"' WHERE idfuncionario = '"+lblID.Text+"';";
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            this.Close();
        }
    }
}
