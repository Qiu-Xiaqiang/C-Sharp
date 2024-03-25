using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Parallelopipedo : Rettangolo
    {
        double _profondità;

        public Parallelopipedo(double Base,double altezza, double profondità) : base(Base,altezza)
        {
            _profondità = profondità;
        }
        public double Profondita
        {
            get { return _profondità; }
            set { _profondità = value; }
        }
        override public double Area()
        {
            return _profondità * base.Area();//Metodo con ovveride che è una caratteristica Polimorfica
            //NB:anche con le classi astratte si usa il metodo ovveride nelle classi ereditate invece la classe astratta si scrive public abstract double + Firma
        }
        public override string ToString()
        {
            return string.Format($"Parallelopipedo-: Profondità:{_profondità,-10}Area:{Area(),-10}");
        }
    }
}
