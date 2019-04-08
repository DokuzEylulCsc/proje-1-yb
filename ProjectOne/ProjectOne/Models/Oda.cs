using ProjectOne.Models.Enums;
using ProjectOne.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
   public class Oda : IOda
    {
        public Oda()
        {
            Rezervasyonlar = new List<Rezervasyon>();
        }

        public int Numara { get; set; }
        public YatakTipi YatakTipi { get; set; }
        public bool DenizManzarasi { get; set; }
        public bool HavuzManzarasi { get; set; }
        public List<Rezervasyon> Rezervasyonlar { get; set; }

        public bool RezervasyonDurumu(DateTime girisTarihi)
        {
            return Rezervasyonlar.Any(x => x.GirisTarihi.Date == girisTarihi.Date);
        }

        public void RezervasyonYap(Rezervasyon _rez)
        {
            Rezervasyonlar.Add(_rez);
        }

        public void RezervasyonIptal(Rezervasyon _rez)
        {
            Rezervasyonlar.Remove(_rez);
        }

        public override string ToString()
        {
            string ozellik = "";
            if (DenizManzarasi && HavuzManzarasi)
            {
                ozellik = " (Deniz ve Havuz Manzaralı)";
            }
            else if (DenizManzarasi)
            {
                ozellik = " (Deniz Manzaralı)";
            }
            else if (HavuzManzarasi)
            {
                ozellik = " (Havuz Manzaralı)";
            }

            return Numara.ToString() + ozellik;
        }
    }
}
