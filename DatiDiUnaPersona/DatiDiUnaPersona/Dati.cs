using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatiDiUnaPersona
{
    internal class Dati
    {
        string _nome;
        string _cognome;
        double _età;
        string _genere;
        string _nazionalità;
        string _richezza;
        string _feudo;

        public Dati(string nome, string cognome, double età, string genere, string nazionalità, string richezza, string feudo)
        {
            _nome = nome;
            _cognome = cognome;
            _età = età;
            _genere = genere;
            _nazionalità = nazionalità;
            _richezza = richezza;
            _feudo = feudo;
        }

        public string Nome { get => _nome; }
        public string Cognome { get => _cognome; }
        public double Età { get => _età; set => _età = value; }
        public string Genere { get => _genere; }
        public string Nazionalità { get => _nazionalità; }
        public string Richezza { get => _richezza; set => _richezza = value; }
        public string Feudo { get => _feudo; }

        public override string ToString()
        {
            return string.Format($"Essere umano: Nome:{_nome,-10}Cognome:{_cognome,-10}Età:{_età,-10}Genere:{_genere,-10}Nazionalità:{_nazionalità,-10}Richezza:{_richezza,-11}Feudo:{_feudo,-10}");
        }
    }
}
