using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSIZ.Models
{
    public class Kategoria
    {
        public int KategoriaID { get; set; }
        public string NazwaKategorii { get; set; }
        public string OpisKategorii { get; set; }
        public virtual ICollection<Przedmiot> Przedmiot { get; set; }
    }
}