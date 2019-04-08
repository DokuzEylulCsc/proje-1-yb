using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public class Misafir
    {
        public string TCkimlikNo { get; set; }
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public List<Rezervasyon> Rezervasyonlar { get; set; }
    }
}
