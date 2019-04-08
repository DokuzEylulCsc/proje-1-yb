using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Models.Interface
{
    public interface IOtel
    {
        void RezervasyonYap(Oda _oda, Rezervasyon _rez);
        bool RezervasyonDurumu(Oda _oda, DateTime girisTarihi);
        bool RezervasyonIptal(Rezervasyon _rez);
    }
}
