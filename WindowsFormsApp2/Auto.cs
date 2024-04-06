using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Auto
    {
        string _marca;
        string _modello;
        double _cilindrata;
        double _numeroVolumi;
        double _kmPercorsi;
        double _costoKmNoleggio;

        public Auto(string marca, string modello, double cilindrata, double numeroVolumi, double kmPercorsi, double costoKmNoleggio)
        {
            _marca = marca;
            _modello = modello;
            _cilindrata = cilindrata;
            _numeroVolumi = numeroVolumi;
            _kmPercorsi = kmPercorsi;
            _costoKmNoleggio = costoKmNoleggio;
        }

        public string Marca { get => _marca; }
        public string Modello { get => _modello;}
        public double Cilindrata { get => _cilindrata; }
        public double NumeroVolumi { get => _numeroVolumi; }
        public double KmPercorsi { get => _kmPercorsi; set => _kmPercorsi = value; }
        public double CostoKmNoleggio { get => _costoKmNoleggio; set => _costoKmNoleggio = value; }
        static public bool operator ==(Auto a1, Auto a2)
        {
            return string.Equals(a1.Marca, a2.Marca) && string.Equals(a1.Modello, a2.Modello);
        }
        static public bool operator !=(Auto a1, Auto a2)
        {
            return (a1 != a2);
        }
        public override string ToString()
        {
            return string.Format($"Moto => Marca:{_marca}Modello:{_modello}Cilindrata:{_cilindrata}Numero Volumi:{_numeroVolumi}Km percorsi{_kmPercorsi}_Costo km Percorsi:{_costoKmNoleggio}");
        }
    }
}
