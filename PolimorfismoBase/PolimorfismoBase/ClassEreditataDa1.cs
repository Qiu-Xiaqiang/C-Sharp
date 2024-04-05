using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAstratta
{
    internal class ClassEreditataDa1 : ClasseEredita1
    {
        int _cifra;
        public ClassEreditataDa1(int cifra,int numero,int numero2) : base (numero,numero2)
        {
            _cifra = cifra;
        }
        public override string Visualizza()
        {
            return String.Format($"{base.Visualizza()}Cifra:{_cifra}");
        }
    }
}
