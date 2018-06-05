using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Core.Service.Interface
{
    public interface ContactService
    {
        Entity.Usuario LoginUsuario(string login, string senha);
    }
}
