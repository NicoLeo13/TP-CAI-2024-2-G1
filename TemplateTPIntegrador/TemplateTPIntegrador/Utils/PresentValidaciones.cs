﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTPIntegrador
{
    public class PresentacionValidaciones
    {
        public bool ValidarStringVacio(string texto)
        {
            if(string.IsNullOrEmpty(texto)) 
                return true;
            return false;
        }
    }
}
