using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cibo> lista = new List<Cibo>();
            List<Pizzeria> listaP= new List<Pizzeria>();
            int scelta;
            do
            {
                Console.WriteLine("Benvenuto nel mondo del cibo");
                Console.WriteLine("Inserisci");
                Console.WriteLine("Visaulizza");
                Console.WriteLine("Rimuovi");
                Console.WriteLine("Controllo presenza");
                
                scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        lista.Add(new Pizzeria("Via riccone","Casa mia","Cinese","Denaro"));
                        lista.Add(new Pizza("Salamino", 6.5, "Italiano", "Piccante", "Ciao", "Italia"));
                        listaP.Add(new Pizzeria("C", "A","C","A")) ;
                        listaP.Add(new Pizzeria("B", "B", "B", "B"));
                        break;
                    case 2:
                        lista.ForEach(x => { Console.WriteLine(x.Visualizzazione()+" "+ x.GetType().Name); });
                        lista.ForEach(x => { if (x is Pizza) { Console.WriteLine(((Pizza)x)); } });
                        listaP.ForEach(x=> { if (x as Pizza != null) { Console.WriteLine(((Pizza)x).Visualizzazione()); } });
                        break;
                    case 3:
                        Pizzeria rimozione = listaP.Find(x => x.Via == "C");
                        listaP.Remove(rimozione);
                        Console.WriteLine("Lista dopo la rimozione");
                        listaP.ForEach(x=> { Console.WriteLine(x.Visualizzazione()); });
                        break;
                    case 4:
                        Pizzeria ricerca = listaP.Find(x => x.Via == "G");
                        if(ricerca != null)
                        {
                            Console.WriteLine("Trovato shabby");
                        }
                        else
                        {
                            Console.WriteLine("Non esiste shuabby");
                        }

                        
                        break;
                    default:
                        Console.WriteLine("GoodByeeee");
                        break;
                   
                }

            } while (scelta != 5);
            Console.ReadLine();
        }
   
    }
}
