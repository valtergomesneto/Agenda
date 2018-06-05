using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Entity;

namespace Agenda.Core.Repository
{
    public class Repository : Interface.ContactRepository
    {
        public Entity.Usuario LoginUsuario(string login, string senha)
        {
            try
            {



            }
            catch (Exception ex)
            {
                new Exception(ex.Message.ToString());
            }
            return new Entity.Usuario();
        }
    }
}
