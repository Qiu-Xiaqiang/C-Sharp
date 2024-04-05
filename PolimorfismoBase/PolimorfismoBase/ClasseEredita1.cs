using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAstratta
{
    internal class ClasseEredita1 : ClasseBase
    {
        int _numero2;
        public ClasseEredita1(int numero2,int numero):base(numero)
        {
            _numero2 = numero2;
        }
        public override string Visualizza()
        {
            return string.Format($"{base.Visualizza()}Numero2: {_numero2}");
        }

    }
}
