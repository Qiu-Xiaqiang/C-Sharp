using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAstrattaIntroduzione
{
    internal class Gommone : Battello
    {
        double _costoMiglia = 0.5;
        public Gommone(string nome,double miglia):base(miglia,nome)
        {

        }
        public override double CostoViaggio()
        {
            return _costoMiglia * _miglia;
        }
    }
}
