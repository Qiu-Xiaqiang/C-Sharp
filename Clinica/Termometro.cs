using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Termometro
    {
        double _temperatura;
        public void SetTemperaturaTermometo(double temperatura)
        {
            _temperatura=temperatura;
        }
        public double GetTemperaturaTermometro()
        {
            return _temperatura;
        }
    }
}
