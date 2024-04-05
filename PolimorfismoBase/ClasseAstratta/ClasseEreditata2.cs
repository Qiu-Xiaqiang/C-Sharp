using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAstratta
{
    internal class ClasseEreditata2: ClasseBase
    {
        int _numero3;
        public ClasseEreditata2(int numero3,int numero):base(numero)
        {
            _numero3 = numero3;
        }
        public override string Visualizza()
        {
            return string.Format($"{base.Visualizza()}Numero3:{_numero3}");
        }
    }
}
