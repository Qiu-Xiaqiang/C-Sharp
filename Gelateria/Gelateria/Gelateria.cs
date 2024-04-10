using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelateria
{
    internal class Gelateria
    {
        string _via;
        string _luogo;
        List<Gelateria> negozio;
        public Gelateria(string via, string luogo)
        {
            Via = via;
            Luogo = luogo;
            negozio = new List<Gelateria>();
        }
        public string Via { get => _via; set => _via = value; }
        public string Luogo { get => _luogo; set => _luogo = value; }
        public void Inserimento(Gelateria gelato)
        {
            negozio.Add(gelato);
        }
        public void Visualizzazione()
        {
            negozio.ForEach(x => { Console.WriteLine(x.ToString()); });
        }
        public override string ToString()
        {
            return string.Format($"Gelateria => Via:{_via}Luogo:{_luogo}");
        }
    }
}
