namespace ProjectOne
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxOdalar = new System.Windows.Forms.ListBox();
            this.labelList = new System.Windows.Forms.Label();
            this.labelOtelAdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBas = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBit = new System.Windows.Forms.DateTimePicker();
            this.btnOdaSorgula = new System.Windows.Forms.Button();
            this.groupBoxSecenekler = new System.Windows.Forms.GroupBox();
            this.labelDoluOdalar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxYatakTipi = new System.Windows.Forms.ComboBox();
            this.checkBoxHavuzManzarasi = new System.Windows.Forms.CheckBox();
            this.checkBoxDenizManzarasi = new System.Windows.Forms.CheckBox();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnRezervasyonList = new System.Windows.Forms.Button();
            this.btnTumRez = new System.Windows.Forms.Button();
            this.btnDoluluk = new System.Windows.Forms.Button();
            this.groupBoxSecenekler.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOdalar
            // 
            this.listBoxOdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxOdalar.FormattingEnabled = true;
            this.listBoxOdalar.ItemHeight = 20;
            this.listBoxOdalar.Location = new System.Drawing.Point(518, 57);
            this.listBoxOdalar.Name = "listBoxOdalar";
            this.listBoxOdalar.Size = new System.Drawing.Size(270, 404);
            this.listBoxOdalar.TabIndex = 0;
            this.listBoxOdalar.DoubleClick += new System.EventHandler(this.listBoxOdalar_DoubleClick);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelList.Location = new System.Drawing.Point(514, 15);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(168, 20);
            this.labelList.TabIndex = 1;
            this.labelList.Text = "Odalar (Çift Tık: Detay)";
            // 
            // labelOtelAdi
            // 
            this.labelOtelAdi.AutoSize = true;
            this.labelOtelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOtelAdi.Location = new System.Drawing.Point(105, 15);
            this.labelOtelAdi.Name = "labelOtelAdi";
            this.labelOtelAdi.Size = new System.Drawing.Size(42, 20);
            this.labelOtelAdi.TabIndex = 2;
            this.labelOtelAdi.Text = "XXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Otel Adı : ";
            // 
            // dateTimePickerBas
            // 
            this.dateTimePickerBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBas.Location = new System.Drawing.Point(20, 36);
            this.dateTimePickerBas.Name = "dateTimePickerBas";
            this.dateTimePickerBas.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerBas.TabIndex = 4;
            this.dateTimePickerBas.ValueChanged += new System.EventHandler(this.dateTimePickerBas_ValueChanged);
            // 
            // dateTimePickerBit
            // 
            this.dateTimePickerBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBit.Location = new System.Drawing.Point(237, 36);
            this.dateTimePickerBit.Name = "dateTimePickerBit";
            this.dateTimePickerBit.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerBit.TabIndex = 5;
            // 
            // btnOdaSorgula
            // 
            this.btnOdaSorgula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOdaSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaSorgula.ForeColor = System.Drawing.Color.White;
            this.btnOdaSorgula.Location = new System.Drawing.Point(22, 164);
            this.btnOdaSorgula.Name = "btnOdaSorgula";
            this.btnOdaSorgula.Size = new System.Drawing.Size(415, 46);
            this.btnOdaSorgula.TabIndex = 6;
            this.btnOdaSorgula.Text = "Oda Sorgula";
            this.btnOdaSorgula.UseVisualStyleBackColor = false;
            this.btnOdaSorgula.Click += new System.EventHandler(this.btnOdaSorgula_Click);
            // 
            // groupBoxSecenekler
            // 
            this.groupBoxSecenekler.Controls.Add(this.labelDoluOdalar);
            this.groupBoxSecenekler.Controls.Add(this.label2);
            this.groupBoxSecenekler.Controls.Add(this.comboBoxYatakTipi);
            this.groupBoxSecenekler.Controls.Add(this.checkBoxHavuzManzarasi);
            this.groupBoxSecenekler.Controls.Add(this.checkBoxDenizManzarasi);
            this.groupBoxSecenekler.Controls.Add(this.dateTimePickerBas);
            this.groupBoxSecenekler.Controls.Add(this.btnOdaSorgula);
            this.groupBoxSecenekler.Controls.Add(this.dateTimePickerBit);
            this.groupBoxSecenekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxSecenekler.Location = new System.Drawing.Point(26, 47);
            this.groupBoxSecenekler.Name = "groupBoxSecenekler";
            this.groupBoxSecenekler.Size = new System.Drawing.Size(465, 265);
            this.groupBoxSecenekler.TabIndex = 7;
            this.groupBoxSecenekler.TabStop = false;
            this.groupBoxSecenekler.Text = "Oda Seçenekleri";
            // 
            // labelDoluOdalar
            // 
            this.labelDoluOdalar.AutoSize = true;
            this.labelDoluOdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDoluOdalar.Location = new System.Drawing.Point(27, 223);
            this.labelDoluOdalar.Name = "labelDoluOdalar";
            this.labelDoluOdalar.Size = new System.Drawing.Size(0, 20);
            this.labelDoluOdalar.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yatak Tipi : ";
            // 
            // comboBoxYatakTipi
            // 
            this.comboBoxYatakTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYatakTipi.FormattingEnabled = true;
            this.comboBoxYatakTipi.Location = new System.Drawing.Point(115, 115);
            this.comboBoxYatakTipi.Name = "comboBoxYatakTipi";
            this.comboBoxYatakTipi.Size = new System.Drawing.Size(322, 28);
            this.comboBoxYatakTipi.TabIndex = 10;
            this.comboBoxYatakTipi.Tag = "";
            // 
            // checkBoxHavuzManzarasi
            // 
            this.checkBoxHavuzManzarasi.AutoSize = true;
            this.checkBoxHavuzManzarasi.Location = new System.Drawing.Point(237, 79);
            this.checkBoxHavuzManzarasi.Name = "checkBoxHavuzManzarasi";
            this.checkBoxHavuzManzarasi.Size = new System.Drawing.Size(150, 24);
            this.checkBoxHavuzManzarasi.TabIndex = 9;
            this.checkBoxHavuzManzarasi.Text = "Havuz Manzarası";
            this.checkBoxHavuzManzarasi.UseVisualStyleBackColor = true;
            // 
            // checkBoxDenizManzarasi
            // 
            this.checkBoxDenizManzarasi.AutoSize = true;
            this.checkBoxDenizManzarasi.Location = new System.Drawing.Point(20, 79);
            this.checkBoxDenizManzarasi.Name = "checkBoxDenizManzarasi";
            this.checkBoxDenizManzarasi.Size = new System.Drawing.Size(146, 24);
            this.checkBoxDenizManzarasi.TabIndex = 8;
            this.checkBoxDenizManzarasi.Text = "Deniz Manzarası";
            this.checkBoxDenizManzarasi.UseVisualStyleBackColor = true;
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(26, 318);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(166, 94);
            this.btnRezervasyonYap.TabIndex = 11;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // btnRezervasyonList
            // 
            this.btnRezervasyonList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRezervasyonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonList.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonList.Location = new System.Drawing.Point(206, 318);
            this.btnRezervasyonList.Name = "btnRezervasyonList";
            this.btnRezervasyonList.Size = new System.Drawing.Size(285, 46);
            this.btnRezervasyonList.TabIndex = 12;
            this.btnRezervasyonList.Text = "Seçili Tarih Rezervasyonları";
            this.btnRezervasyonList.UseVisualStyleBackColor = false;
            this.btnRezervasyonList.Click += new System.EventHandler(this.btnRezervasyonList_Click);
            // 
            // btnTumRez
            // 
            this.btnTumRez.BackColor = System.Drawing.Color.Green;
            this.btnTumRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumRez.ForeColor = System.Drawing.Color.White;
            this.btnTumRez.Location = new System.Drawing.Point(206, 370);
            this.btnTumRez.Name = "btnTumRez";
            this.btnTumRez.Size = new System.Drawing.Size(285, 42);
            this.btnTumRez.TabIndex = 13;
            this.btnTumRez.Text = "Tüm Rezervasyonlar";
            this.btnTumRez.UseVisualStyleBackColor = false;
            this.btnTumRez.Click += new System.EventHandler(this.btnTumRez_Click);
            // 
            // btnDoluluk
            // 
            this.btnDoluluk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDoluluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoluluk.ForeColor = System.Drawing.Color.White;
            this.btnDoluluk.Location = new System.Drawing.Point(26, 418);
            this.btnDoluluk.Name = "btnDoluluk";
            this.btnDoluluk.Size = new System.Drawing.Size(465, 43);
            this.btnDoluluk.TabIndex = 14;
            this.btnDoluluk.Text = "Doluluk Oranı";
            this.btnDoluluk.UseVisualStyleBackColor = false;
            this.btnDoluluk.Click += new System.EventHandler(this.btnDoluluk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 468);
            this.Controls.Add(this.btnDoluluk);
            this.Controls.Add(this.btnTumRez);
            this.Controls.Add(this.btnRezervasyonList);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.groupBoxSecenekler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOtelAdi);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listBoxOdalar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSecenekler.ResumeLayout(false);
            this.groupBoxSecenekler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoluluk;
        private System.Windows.Forms.Button btnTumRez;
        private System.Windows.Forms.Button btnRezervasyonList;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.GroupBox groupBoxSecenekler;
        private System.Windows.Forms.Label labelDoluOdalar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxYatakTipi;
        private System.Windows.Forms.CheckBox checkBoxHavuzManzarasi;
        private System.Windows.Forms.CheckBox checkBoxDenizManzarasi;
        private System.Windows.Forms.DateTimePicker dateTimePickerBas;
        private System.Windows.Forms.Button btnOdaSorgula;
        private System.Windows.Forms.DateTimePicker dateTimePickerBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOtelAdi;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.ListBox listBoxOdalar;
    }
}

