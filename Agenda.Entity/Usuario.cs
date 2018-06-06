using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entity
{
    public class Usuario
    {
        public int idusuario { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int status { get; set; }
        public int nivelAcesso { get; set; }

    }

    public enum Perfil
    { 
    
        Administrador = 1,
        Operador = 2,
        Suporte = 3
    
    }
}
