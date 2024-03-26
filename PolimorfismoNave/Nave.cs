using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoNave
{
    internal class Nave
    {
        protected static double _costoBase = 0.10;
        protected string _nome;
        protected double _miglia;

        public Nave(string nome, double miglia)
        {
            _nome = nome;   
            _miglia = miglia;
        }
        public string Nome
        {
            get{ return _nome; }
        }
        public double Miglia
        {
            get { return _miglia; }
        }

        virtual public double CostoViaggio() //virtuale --> deve essere ridefinito nella classe derivata
        {
            return _costoBase * _miglia;
        }
    }
}
