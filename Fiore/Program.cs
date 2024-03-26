using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lezione_3
{
    internal class Program
    {
        //Realizzare un programma in C# con fiori caratterizzati da un nome e da un prezzo e una fioreria da un nome e un indirizzo
        //Il programma deve permettere inserimento,aggiungimento,modifica,eliminazione e ricerca(per nome e per prezzo) degli fiori appartenenti alla fioreria
        static void Main(string[] args)
        {
            Fiore fiore = new Fiore("Rosa".ToLower());
            Fiore flower = new Fiore("Tulipano".ToUpper());
            fiore.Prezzo = 6.66;
            flower.Prezzo = 8.88;
            Console.WriteLine(fiore.Nome+fiore.Prezzo);
            //Console.WriteLine(fiore.Prezzo);
            Console.WriteLine(flower.Nome+fiore.Prezzo);
            //Console.WriteLine(flower.Prezzo);
            Console.WriteLine("**************************");
            Fioreria fioreria = new Fioreria("Fioreria Ding","Via Ding");
            Console.WriteLine(fioreria.NomeFioreria+fioreria.Indirizzo);
            //Console.WriteLine(fioreria.Indirizzo);
            fioreria.Indirizzo = "Via Diiiiiing";//Qua modifico l'indirizzzo della fioreria grazie a  set { _indirizzo = value; }
            Console.WriteLine(fioreria.Indirizzo);
            fioreria.Inserimento(fiore);
            fioreria.Inserimento(flower);
            fioreria.VisualizzaLista();
            Console.WriteLine(fioreria.Ricerca("Paolooooooo")); //Vado a cercare nella fioreria se c'è un fiore Paolo in questo caso non c'è
                                                                //Ritorna false
            Console.WriteLine(fioreria.RicercaPrezzo(8));
            Console.WriteLine(fioreria.Confronta("tulipano".ToUpper()));//Trovo il tulipano con il suo costo se non la trovo stampa 0
            Fiore Flower = fioreria.TrovaFiore("tulipano");
            Console.WriteLine(Flower.ToString());
            Console.ReadLine();
        }
    }
}
