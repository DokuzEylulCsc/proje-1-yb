using ProjectOne.Models;
using ProjectOne.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Otel otel;
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerBas.Value = DateTime.Now;
            dateTimePickerBit.Value = DateTime.Now.AddDays(1);

            comboBoxYatakTipi.DataSource = Enum.GetValues(typeof(YatakTipi));

            otel = new Otel("Gedik Otel", "Seferihisar İzmir", OtelTipi.Otel);
            labelOtelAdi.Text = otel.Adi;
        }

        private void btnOdaSorgula_Click(object sender, EventArgs e)
        {
            labelList.Text = "Uygun Odalar";
            labelDoluOdalar.Text = "Dolu Odalar: ";
            listBoxOdalar.Items.Clear();

            var date1 = dateTimePickerBas.Value;
            var date2 = dateTimePickerBit.Value;
            var denizManzarasi = checkBoxDenizManzarasi.Checked;
            var havuzManzarasi = checkBoxHavuzManzarasi.Checked;
            var yatakTipi = comboBoxYatakTipi.SelectedItem;

            foreach (var oda in otel.Odalari)
            {
                if (oda.DenizManzarasi == denizManzarasi && oda.HavuzManzarasi == havuzManzarasi && Enum.GetName(typeof(YatakTipi), oda.YatakTipi) == yatakTipi.ToString())
                {
                    if (oda.Rezervasyonlar != null && oda.Rezervasyonlar.Count > 0)
                    {
                        // Rezervasyon kontrolü (Oda Müsait mi?)
                        var rezervasyonDurumu = otel.RezervasyonDurumu(oda, date1);

                        if (!rezervasyonDurumu)
                        {
                            listBoxOdalar.Items.Add(oda);
                        }
                        else
                        {
                            labelDoluOdalar.Text += oda.Numara + ",";
                        }
                    }
                    else
                    {
                        listBoxOdalar.Items.Add(oda);
                    }
                }
            }

            if (listBoxOdalar.Items.Count == 0)
            {
                MessageBox.Show("Uygun Oda Bulunamadı!");
            }

        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (listBoxOdalar.SelectedItem == null)
            {
                MessageBox.Show("Oda Seçiniz!");
            }
            else
            {
                var oda = listBoxOdalar.SelectedItem as Oda;

                //Rezervasyon Yap

                otel.RezervasyonYap(oda, new Rezervasyon()
                {
                    GirisTarihi = dateTimePickerBas.Value,
                    CikisTarihi = dateTimePickerBit.Value,
                    OdaNumarasi = oda.Numara,
                    Misafirler = new List<Misafir>()
                    {
                        new Misafir() { Ad = "John Doe " + oda.Numara, }
                    }
                });

                MessageBox.Show($"İşlem Tamamlandı! {oda.Numara} Numaralı Oda Rezerve edildi!");

                listBoxOdalar.Items.Remove(oda);
            }
        }

        private void btnRezervasyonList_Click(object sender, EventArgs e)
        {
            labelList.Text = "Seçili Tarih Rez. (Detay İçin Çift Tık!)";
            listBoxOdalar.Items.Clear();

            foreach (var oda in otel.Odalari)
            {
                if (oda.Rezervasyonlar != null && oda.Rezervasyonlar.Count > 0)
                {
                    foreach (var item in oda.Rezervasyonlar)
                    {
                        if (item.GirisTarihi.Date == dateTimePickerBas.Value.Date)
                        {
                            listBoxOdalar.Items.Add(oda);
                        }
                    }
                }
            }
        }

        private void listBoxOdalar_DoubleClick(object sender, EventArgs e)
        {
            if (labelList.Text == "Tüm Rezervasyonlar (Çift Tık: Sil)")
            {
                // Rezervasyon İptali
                var rez = listBoxOdalar.SelectedItem as Rezervasyon;

                var state = otel.RezervasyonIptal(rez);
                if (state)
                {
                    listBoxOdalar.Items.Remove(rez);
                }
            }
            else
            {
                if (listBoxOdalar.SelectedItem == null)
                {
                    MessageBox.Show("Oda Seçiniz!");
                }
                else
                {
                    var oda = listBoxOdalar.SelectedItem as Oda;

                    if (oda.Rezervasyonlar != null && oda.Rezervasyonlar.Count > 0)
                    {
                        var rezervasyon = oda.Rezervasyonlar.FirstOrDefault(x => x.GirisTarihi.Date == dateTimePickerBas.Value.Date);
                        if (rezervasyon != null)
                        {
                            MessageBox.Show($"Rezervasyon Bilgileri:" +
                                $"\n\nTarihler:\n{rezervasyon.GirisTarihi.ToString("dd.MM.yyyy")} - {rezervasyon.CikisTarihi.ToString("dd.MM.yyyy")}" +
                                $"\n\nMisafiler: {rezervasyon.misafiler}");
                        }
                        else
                        {
                            MessageBox.Show("Seçili Tarihe Ait Rezervasyon Bulunamadı!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seçili Tarihe Ait Rezervasyon Bulunamadı!");
                    }

                }
            }
        }

        private void dateTimePickerBas_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBit.Value = dateTimePickerBas.Value.AddDays(1);
        }

        private void btnTumRez_Click(object sender, EventArgs e)
        {
            labelList.Text = "Tüm Rezervasyonlar (Çift Tık: Sil)";
            listBoxOdalar.Items.Clear();

            var date1 = dateTimePickerBas.Value;
            foreach (var oda in otel.Odalari)
            {
                foreach (var item in oda.Rezervasyonlar)
                {
                    listBoxOdalar.Items.Add(item);
                }
            }

            var oran = otel.DolulukOrani(date1);

            labelOtelAdi.Text = otel.Adi + " (Doluluk Oranı : %" + oran + ")";
        }

        private void btnDoluluk_Click(object sender, EventArgs e)
        {
            var date1 = dateTimePickerBas.Value;

            var oran = otel.DolulukOrani(date1);

            MessageBox.Show("DOLULUK ORANI: %" + oran);
        }
    }
}
