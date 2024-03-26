using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Clinica
{
    internal class Reparto
    {
        string _nomeStanza;
        int _numPosti;
        Termometro _termometroReparto;//Le classi comunicano tra di loro in questo caso la classe Termometro.cs(Serve la new)
        List<Paziente> ListaDiPazienti;//Liosta degli pazienti con dato di tipo Paziente(Serve la new)
        Specializzazione _tipoStanza;
        public Reparto(string nomeStanza,int numPosti,Specializzazione tipoStanza )//Metodo costruttore reparto
        {
            _nomeStanza = nomeStanza;
            _numPosti = numPosti;
            _tipoStanza= tipoStanza;
            _termometroReparto = new Termometro();
            ListaDiPazienti = new List<Paziente>();
        }
        public void AggiungiPaziente(Paziente paziente)
        {
            if(ListaDiPazienti.Count==_numPosti)
            {
                Console.WriteLine("Lista pieno non puoi più accogliere un paziente");
            }
            else
            {
                if (ListaDiPazienti.Exists(x => x.GetNome() == paziente.GetNome() && x.GetCognome() == paziente.GetCognome()))//Con exists va a vedere se c'è un determionato elemento
                {
                    Console.WriteLine("Abbiamo trovato un paziente duplicato con lo stesso nome e cognome non puoi inserirlo");
                }
                else
                {
                    ListaDiPazienti.Add(paziente);
                }
            }
        }
    }
   
}
