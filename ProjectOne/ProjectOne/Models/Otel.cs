using ProjectOne.Models.Enums;
using ProjectOne.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
   public class Otel : IOtel
    {
        public Otel(string otelAdi, string otelAdresi, OtelTipi otelTipi)
        {
            _adi = otelAdi;
            Adresi = otelAdresi;
            OtelTipi = otelTipi;
            _odalar = OdaOlustur(otelTipi);
        }

        private string _adi;
        public string Adi
        {
            get
            {
                return _adi;
            }
        }
        string Adresi { get; set; }
        OtelTipi OtelTipi { get; set; }

        private List<Oda> _odalar;
        public List<Oda> Odalari
        {
            get
            {
                return _odalar;
            }
        }

        List<Oda> OdaOlustur(OtelTipi otelTipi)
        {
            var odalar = new List<Oda>();
            switch (otelTipi)
            {
                case OtelTipi.Pansiyon:
                    odalar.AddRange(new List<Oda>()
                    {
                        new Oda() { Numara = 101, YatakTipi = YatakTipi.Tek, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 102, YatakTipi = YatakTipi.Tek, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 103, YatakTipi = YatakTipi.Tek, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 104, YatakTipi = YatakTipi.Cift, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 105, YatakTipi = YatakTipi.Cift, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 106, YatakTipi = YatakTipi.Cift, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 107, YatakTipi = YatakTipi.Cift, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 108, YatakTipi = YatakTipi.Ikiz, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 109, YatakTipi = YatakTipi.Ikiz, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 110, YatakTipi = YatakTipi.Ikiz, DenizManzarasi = false, HavuzManzarasi = true},
                    });
                    break;
                case OtelTipi.Otel:
                    odalar.AddRange(new List<Oda>()
                    {
                        new Oda() { Numara = 101, YatakTipi = YatakTipi.Tek, DenizManzarasi = false, HavuzManzarasi = false},
                        new Oda() { Numara = 102, YatakTipi = YatakTipi.Tek, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 103, YatakTipi = YatakTipi.Tek, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 104, YatakTipi = YatakTipi.Cift, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 105, YatakTipi = YatakTipi.Cift, DenizManzarasi = true, HavuzManzarasi = true},
                        new Oda() { Numara = 106, YatakTipi = YatakTipi.Cift, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 107, YatakTipi = YatakTipi.Cift, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 108, YatakTipi = YatakTipi.Ikiz, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 109, YatakTipi = YatakTipi.Ikiz, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 110, YatakTipi = YatakTipi.Ikiz, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 111, YatakTipi = YatakTipi.Tek, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 112, YatakTipi = YatakTipi.Tek, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 113, YatakTipi = YatakTipi.Tek, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 114, YatakTipi = YatakTipi.Cift, DenizManzarasi = true, HavuzManzarasi = true},
                        new Oda() { Numara = 115, YatakTipi = YatakTipi.Cift, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 116, YatakTipi = YatakTipi.Cift, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 117, YatakTipi = YatakTipi.Cift, DenizManzarasi = true, HavuzManzarasi = false},
                        new Oda() { Numara = 118, YatakTipi = YatakTipi.Ikiz, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 119, YatakTipi = YatakTipi.Ikiz, DenizManzarasi = false, HavuzManzarasi = true},
                        new Oda() { Numara = 120, YatakTipi = YatakTipi.Ikiz, DenizManzarasi = true, HavuzManzarasi = true},
                    });
                    break;
                default:
                    break;
            }

            odalar.First().Rezervasyonlar.Add(new Rezervasyon()
            {
                GirisTarihi = DateTime.Now,
                CikisTarihi = DateTime.Now.AddDays(1),
                Misafirler = new List<Misafir>()
                {
                    new Misafir() { Ad = "Berkay Adsan"},
                },
                OdaNumarasi = 101,
            });

            return odalar;
        }

        public bool RezervasyonDurumu(Oda _oda, DateTime girisTarihi)
        {
            var state = _oda.Rezervasyonlar.Any(x => x.GirisTarihi.Date == girisTarihi.Date);

            if (!state)
            {
                state = _oda.Rezervasyonlar.Any(x => x.GirisTarihi < girisTarihi.Date && x.CikisTarihi.Date > girisTarihi);
            }

            return state;
        }

        public void RezervasyonYap(Oda _oda, Rezervasyon _rez)
        {
            _oda.Rezervasyonlar.Add(_rez);
        }

        public bool RezervasyonIptal(Rezervasyon _rez)
        {
            var _oda = Odalari.FirstOrDefault(x => x.Numara == _rez.OdaNumarasi);
            if (_oda != null)
            {
                _oda.Rezervasyonlar.Remove(_rez);
                return true;
            }
            else
            {
                return false;
            }
        }

        public float DolulukOrani(DateTime girisTarihi)
        {
            int count = 0;
            foreach (var oda in Odalari)
            {
                if (oda.Rezervasyonlar.Any(y => y.GirisTarihi.Date == girisTarihi.Date))
                {
                    count++;
                }
            }

            return (count / (float)Odalari.Count) * 100;
        }
    }
}
