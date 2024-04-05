using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAstratta
{
    internal class ClasseBase
    {
        protected int _numero;
        public ClasseBase(int numero)
        {
            _numero= numero;
        }
        public virtual string Visualizza()
        {
            return String.Format($"Numero:{_numero}");
        }
    }
}
