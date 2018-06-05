using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Core.Repository.Interface
{
    public interface ContactRepository
    {
        Entity.Usuario LoginUsuario(string login, string senha);
    }
}
