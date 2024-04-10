using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gelateria
{
    internal class Gelato : Prodotti, Interface1
    {
        public enum Gusto
        {
            fragola,
            mango,
            anguria,
            melone,
            pistacchio,
            banana

        }
        int _palline;
        Gusto _gusto;

       

        public Gelato(string descrizione, string dimensione, double costo, int palline, Gusto gusto) : base (descrizione, dimensione,costo)
        {
            _palline = palline;
            _gusto = gusto;
        }
        public int Palline { get => _palline; }
        public Gusto TipoGusto { get => _gusto; }

        public override string Visualizzazione()
        {
            return string.Format($"Gelato=> Descrizione:{_descrizione}-Dimensione{_descrizione}-Costo:{_costo}Palline:{_palline}Gusto:{_gusto}");
        }
        //public string Go(string parola)
        //{
        //    return string.Format($"Messagio da Interfaccia:{parola}");
        //}
        public string Go(string parola)//Funziona anche così in modo più semplice
        {
            return parola;
        }

    }
}
