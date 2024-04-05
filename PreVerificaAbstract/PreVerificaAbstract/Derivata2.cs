using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVerifica
{
    internal class Derivata2 : ClasseBase, Interface1
    {
        int nDerivata2;
        

        public Derivata2(int nBase, int a) : base(nBase)
        {
            nDerivata2 = a;
        }
        public override string Stampa()
        {
            return String.Format($"nBase: {NBase} nDerivata2: {nDerivata2}");
        }
        public string Saluto(string s)
        {
            return string.Format($"messaggio da derivata 2: {s}");
        }
    }
}
