using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelateria
{
    internal class Torta : Prodotti,Interface1
    {
        public enum Gusto
        {
            crema,
            cioccolato,
            vaniglia
        }
        string _tipo;
        Gusto _gusto;
        public Torta(string descrizione,string dimensione,double costo,string tipo,Gusto gusto) : base(descrizione,dimensione,costo)
        {
            _tipo = tipo;
            _gusto = gusto;
        }
        public string Tipo
        {
            get { return _tipo; }
        }
        public Gusto TipoGusto
        {
            get { return _gusto; }
        }
        public override string Visualizzazione()
        {
            return string.Format($"Torta => Descrizione:{_descrizione}-Dimensione{_descrizione}-Costo:{_costo}Tipo:{_tipo}Gusto:{_gusto}");
        }
        public string Go(string parola)
        {
            return string.Format($"Messagio dall'interfaccia: {parola}");
        }
    }
}
