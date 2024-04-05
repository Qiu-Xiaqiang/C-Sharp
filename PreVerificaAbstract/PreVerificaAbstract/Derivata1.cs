using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVerifica
{
    internal class Derivata1 : ClasseBase
    {
        int nDerivata1;

        public Derivata1(int nBase, int a) : base(nBase)
        {
            nDerivata1 = a;
        }

        public override string Stampa()
        {
            return String.Format($"nBase: {NBase} nDerivata1: {nDerivata1}");            
        }
    }
}
