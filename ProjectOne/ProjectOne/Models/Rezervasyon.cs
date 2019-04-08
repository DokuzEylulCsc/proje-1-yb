using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
   public class Rezervasyon
    {
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int OdaNumarasi { get; set; }
        public bool IptalEdildi { get; set; }
        public List<Misafir> Misafirler { get; set; }

        public string misafiler
        {
            get
            {
                string _mis = "";
                foreach (var item in Misafirler)
                {
                    _mis += item.Ad + ",";
                }
                return _mis;
            }
        }

        public override string ToString()
        {
            return OdaNumarasi + ", G: " + GirisTarihi.Date.ToString("dd.MM.yyyy") + " Ç: " + CikisTarihi.Date.ToString("dd.MM.yyyy");
        }
    }
}
