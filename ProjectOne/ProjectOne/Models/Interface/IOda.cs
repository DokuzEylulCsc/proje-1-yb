using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Models.Interface
{
    public interface IOda
    {
        void RezervasyonYap(Rezervasyon _rez);
        bool RezervasyonDurumu(DateTime girisTarihi);
        void RezervasyonIptal(Rezervasyon _rez);
    }
}
