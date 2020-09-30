using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kundeApp1.Models
{
    public class Kunde
    {
        public int id { get; set; } //brukes som kommunikasjon mellom klient og tjener og for å opprette tabell i databasen
        public object[] Id { get; internal set; }
        public string navn { get; set; }
        public object Navn { get; internal set; }
        public string adresse { get; set; }
        public object Adresse { get; internal set; }
    }
}
