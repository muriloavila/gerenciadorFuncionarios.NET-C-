using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciadorFuncionarios
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            modelo add = new modelo();
            dal da = new dal();

            add.Nome = txtAddNome.Text;
            add.Cargo = txtAddCargo.Text;
            add.Endereco = txtAddEnd.Text;
            add.Telefone = txtAddTel.Text;
            add.Idade = Convert.ToInt16(numAddIdade.Value);

            da.Insert(add);

            txtAddNome.Text = "";
            txtAddCargo.Text = "";
            txtAddEnd.Text = "";
            txtAddTel.Text = "";
            numAddIdade.Value = 0;

            frmPrincipal principal = new frmPrincipal();
            principal.Update();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
