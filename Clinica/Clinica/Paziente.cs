using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Paziente
    {
        string _nome;//Sono 3 attributi della nostra classe paziente; 
        string _cognome;
        double _temperatura;

        //Metodo costruttore -------   Devobno essere pubblico per essere utilizzato dal main
        public Paziente(string nome, string cognome, double temperatura)//Costruttore paziente
        {
            _nome = nome;//Sinistra metto i variabili attributi e a destra i parametru passati al costruttore
            _cognome = cognome;
            _temperatura = temperatura;
        }
        //Creo metodi Get per prendere nomi, devono essere sempre pubblici per far utilizzare al main
        public string GetNome()//Metodo get che ritorna _(underload di nome)
        {
            return _nome;
        }
        public string GetCognome()
        {
            return _cognome;
        }
        public double GetTemperatura()
        {
            return _temperatura;
        }
        public void SetNome(string nome)//Metodo Set per cambiare il nome 
        {
            _nome = nome;
        }
        public void SetCognome(string cognome)
        {
            _cognome = cognome;
        }
        public void SetTemperatura(double temperatura)
        {
            _temperatura = temperatura;
        }
    }
}
