using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epicode_U5_W1_D1_2
{
    public class Dipendenti
    {
        public int PkDipendente { get; set; }
        public string Nome {  get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string CF { get; set; }
        public string Sposato { get; set; }
        public int FigliACarico { get; set; }
        public string Mansione { get; set;}
    }

    public class Pagamenti
    {
        public int PkPagamento { get; set; }
        public double Somma { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set;}
    }
}