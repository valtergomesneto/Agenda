using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Entity;

namespace Agenda.View
{
    public partial class frmAdicionarUsuario : Form
    {
        //variavel
        private Entity.Usuario _Usuario;

        public frmAdicionarUsuario()
        {
            InitializeComponent();
        }

        //Função que recebe o objeto do usuario

        internal void Usuario(Entity.Usuario objUsuario)
        {
        
            //Instancia o objeto Usuario
            _Usuario = new Usuario();
            //Alimenta a variavel com o parametro objUsuario
            _Usuario = objUsuario;
        
        }
    }
}
