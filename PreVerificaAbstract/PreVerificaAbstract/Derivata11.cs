using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVerifica
{
    internal class Derivata11 : Derivata1
    {
        int nDerivata11;

        public Derivata11(int nBase,int _nDerivata11, int a) : base (nBase,a)
        {
            nDerivata11 = _nDerivata11;
        }
        public override string Stampa()
        {
            return String.Format($"{base.Stampa()} nDerivata11: {nDerivata11}");
        }
    }
}
