using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigoDiPaoloooooo
{
    internal class Supermercato
    {
        static  int _codiceProgressivo=1;
        public static int CodiceProgressivo
        {
            get { return _codiceProgressivo++; }
        }
    }
    
}
