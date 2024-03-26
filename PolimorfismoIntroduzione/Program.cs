using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoIntroduzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dipedente> lista = new List<Dipedente>();
            lista.Add(new Dipedente("Emiliano Spiller", "Maschio",15));
            lista.Add(new Docente("Gasparini Filippo", "Maschio","Insegnante di lingua italiana",10, 15));
            lista.ForEach(x => { Console.WriteLine(x.ToString()); });
            Console.WriteLine("----------------------------------------------------------------------");
            Dipedente []personale = new Dipedente[2];
            personale[0] = new Dipedente("Emiliano Spiller", "Maschio", 15);
            personale[1] = new Docente("Gasparini Filippo", "Maschio", "Insegnante di lingua italiana", 10, 15);
            for (int i = 0;i< personale.Length;i++)
            {
                Console.WriteLine(personale[i]);
                Console.WriteLine(personale[i].Stipendio()); 
            }
            Console.ReadLine();
        }
    }
}
