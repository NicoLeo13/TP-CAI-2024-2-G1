using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Utils
{
    public class NegocioValidaciones
    {
        public bool Login(string usuario)
        {
            if(usuario.Length < 8) 
                return true;
            return false;
        }


    }
}
