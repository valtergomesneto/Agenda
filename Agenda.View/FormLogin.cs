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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
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
                new Exception("Erro - " + ex.Message.ToString() + " - Contate o Suporte.");
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
                if (string.IsNullOrEmpty(txtLogin.Text) && string.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Informe Login e Senha", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    var retorno = new Agenda.Core.Service.Service().LoginUsuario(txtLogin.Text, txtSenha.Text);

                    if (retorno.idusuario != null)
                    {


                        if (retorno.idusuario > 0)
                        {

                            var frm = new FrmPrincipal();
                            frm.Iniciar(retorno);
                            frm.ShowDialog();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Login ou Senha Incorreto!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            catch (Exception ex)
            {
             new Exception("Erro - " + ex.Message.ToString() + " - Contate o Suporte.");
            }
        }
    }
}

