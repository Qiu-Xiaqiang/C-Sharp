using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAstrattaIntroduzione
{
    internal abstract class Battello
    {
        protected double _miglia;
        protected string _nome;
        public Battello(double miglia, string nome)
        {
            _miglia = miglia;
            _nome = nome;
        }
        public abstract double CostoViaggio();
    }
}
