using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    internal class PizzaDiavola : Pizza
    {
        string _salamino;
        public PizzaDiavola(string salamino,string nome,string dimensione):base(nome,dimensione) 
        {
            _salamino = salamino;
        }
        public string Salamino
        { get { return _salamino; } }
        public override string Visualizza()
        {
            return string.Format($"{base.Visualizza(),10}Gusto:{_salamino,10}");
        }
      
    }
}
