using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {

            try
            {

                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;


            }
            catch (Exception ex)
            {

                new Exception("Erro " + ex.Message.ToString() + " - Contate o suporte.");

            }
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Informe o Login", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!string.IsNullOrEmpty(txtSenha.Text) && string.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Informe a Senha", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtLogin.Text) && string.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Informe Login e Senha", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                }
            }
            catch (Exception ex)
            {
                
                new Exception("Erro " + ex.Message.ToString() + " - Contate o suporte.");

            }
        }
    }
}
