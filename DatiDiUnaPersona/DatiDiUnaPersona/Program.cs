using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatiDiUnaPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dati> listaPersona = new List<Dati>();
            listaPersona.Add(new Dati("Xiaqiang", "Qiu", 18, "Maschio", "Cinese", "43879879¥", "6 montagne 邱山 - Alte 2200 metri+"));
            listaPersona.ForEach(x => { Console.WriteLine(x.ToString()); });
            Console.ReadLine();
        }
    }
}
