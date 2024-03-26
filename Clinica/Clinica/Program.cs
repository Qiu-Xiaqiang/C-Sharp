using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paziente malato = new Paziente("Ye", "Ding", 41.5);//Dati passati dal costruttore con nome,cognome e temperatura attraverso la new
            Paziente malato2 = new Paziente("Xiaoyu", "Xia", 38.5);//Passo con un'altro new i dati del paziente 2
            Console.WriteLine("Dati paziente number one");
            Console.WriteLine("Nome:" + malato.GetNome());//Riesco a stampare il nome del malato con questo metodo
            Console.WriteLine("Cognome:" + malato.GetCognome());//Riesco a stampare il cognome del malato con questo metodo
            Console.WriteLine("Temperatura:" + malato.GetTemperatura());//Riesco a stampare la temperatura del malato con questo metodo
            Console.WriteLine("Dati paziente number two");
            Console.WriteLine("Nome:" + malato2.GetNome());//Riesco a stampare il nome del malato2 con questo metodo
            Console.WriteLine("Cognome:" + malato2.GetCognome());//Riesco a stampare il cognome del malato2 con questo metodo
            Console.WriteLine("Temperatura:" + malato2.GetTemperatura());//Riesco a stampare la temperatura del malato2 con questo metodo
            malato.SetNome("Alessandro");//Con il metodo set riesco a cambiare il nome, in questo caso il nome del malato 1
            Console.WriteLine(malato.GetNome());//Stampo dopo a video la modifica ripassando di nuovo con GetNomr
            malato.SetTemperatura(39);//Stessa cosa per la temperatura
            Console.WriteLine(malato.GetTemperatura());//Stampo a video
            Reparto stanza = new Reparto("Stanza 1", 5, Specializzazione.Ginecologia);
            Reparto stanza1 = new Reparto("Stanza 8", 8, Specializzazione.Oncologia);
            stanza.AggiungiPaziente(malato2);
            stanza1.AggiungiPaziente(malato);
            Console.ReadLine();
        }
    }
}
