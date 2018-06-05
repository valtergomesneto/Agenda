using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Entity;

namespace Agenda.Core.Service
{
   public class Service : Interface.ContactService
    {

       public   Entity.Usuario LoginUsuario()
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
