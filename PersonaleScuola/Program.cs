using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaleScuola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dipedente> nuovaLista = new List<Dipedente>();
            nuovaLista.Add(new Docente("Informatica", Docente.Ruolo.insegnanteLaureato, "Prof Spiller", "Maschio", "Via Alcide De Gasperi n.21"));
            nuovaLista.Add(new Impiegato("Ufficio informatico", "Prof Melon", "Maschio", "Via Alcide De Gasperi n.21"));
            nuovaLista.ForEach(x => { Console.WriteLine(x.ToString()); }) ;
            Console.ReadLine();

        }
    }
}
