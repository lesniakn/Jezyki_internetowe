using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSIZ.Models
{
    public class Przedmiot
    {
        public int PrzedmiotID { get; set; }
        public int KategoriaID { get; set; }
        public string NazwaPrzedmiotu { get; set; }
        public string ProducentPrzedmiotu { get; set; }
        public DateTime DataDodania { get; set; }
        public string OpisPrzedmiotu { get; set; }
        public decimal CenaPrzedmiotu { get; set; }

        public virtual ICollection<Kategoria> Kategoria { get; set; }
    }
}