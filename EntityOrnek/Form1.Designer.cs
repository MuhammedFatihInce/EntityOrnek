﻿namespace EntityOrnek
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.BtnOgrenciListele = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtFoto = new System.Windows.Forms.TextBox();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.TxtOgrenciId = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.TxtDersAd = new System.Windows.Forms.TextBox();
			this.TxtDersId = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.BtnJoin = new System.Windows.Forms.Button();
			this.BtnNotHesapla = new System.Windows.Forms.Button();
			this.TxtDurum = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.TxtOrtalama = new System.Windows.Forms.TextBox();
			this.TxtSinav3 = new System.Windows.Forms.TextBox();
			this.TxtSinav2 = new System.Windows.Forms.TextBox();
			this.TxtSinav1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.BtnDersListesi = new System.Windows.Forms.Button();
			this.BtnNotListesi = new System.Windows.Forms.Button();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.BtnSil = new System.Windows.Forms.Button();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.BtnProsedur = new System.Windows.Forms.Button();
			this.BtnBul = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.BtnLinqEntity = new System.Windows.Forms.Button();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.radioButton10 = new System.Windows.Forms.RadioButton();
			this.radioButton11 = new System.Windows.Forms.RadioButton();
			this.radioButton12 = new System.Windows.Forms.RadioButton();
			this.radioButton13 = new System.Windows.Forms.RadioButton();
			this.radioButton14 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1305, 275);
			this.dataGridView1.TabIndex = 0;
			// 
			// BtnOgrenciListele
			// 
			this.BtnOgrenciListele.Location = new System.Drawing.Point(0, 281);
			this.BtnOgrenciListele.Name = "BtnOgrenciListele";
			this.BtnOgrenciListele.Size = new System.Drawing.Size(232, 49);
			this.BtnOgrenciListele.TabIndex = 1;
			this.BtnOgrenciListele.Text = "Öğrenci Listele";
			this.BtnOgrenciListele.UseVisualStyleBackColor = true;
			this.BtnOgrenciListele.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtFoto);
			this.groupBox1.Controls.Add(this.TxtSoyad);
			this.groupBox1.Controls.Add(this.TxtAd);
			this.groupBox1.Controls.Add(this.TxtOgrenciId);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(390, 281);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(439, 243);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Öğrenci";
			// 
			// TxtFoto
			// 
			this.TxtFoto.Location = new System.Drawing.Point(184, 190);
			this.TxtFoto.Name = "TxtFoto";
			this.TxtFoto.Size = new System.Drawing.Size(201, 30);
			this.TxtFoto.TabIndex = 8;
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Location = new System.Drawing.Point(184, 145);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(201, 30);
			this.TxtSoyad.TabIndex = 9;
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(184, 102);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(201, 30);
			this.TxtAd.TabIndex = 10;
			this.TxtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
			// 
			// TxtOgrenciId
			// 
			this.TxtOgrenciId.Location = new System.Drawing.Point(184, 59);
			this.TxtOgrenciId.Name = "TxtOgrenciId";
			this.TxtOgrenciId.Size = new System.Drawing.Size(201, 30);
			this.TxtOgrenciId.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "FOTOĞRAF:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(93, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "SOYAD:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(136, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "AD:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(145, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "ID:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.TxtDersAd);
			this.groupBox2.Controls.Add(this.TxtDersId);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Location = new System.Drawing.Point(390, 530);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(439, 159);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dersler";
			// 
			// TxtDersAd
			// 
			this.TxtDersAd.Location = new System.Drawing.Point(184, 102);
			this.TxtDersAd.Name = "TxtDersAd";
			this.TxtDersAd.Size = new System.Drawing.Size(201, 30);
			this.TxtDersAd.TabIndex = 10;
			// 
			// TxtDersId
			// 
			this.TxtDersId.Location = new System.Drawing.Point(184, 59);
			this.TxtDersId.Name = "TxtDersId";
			this.TxtDersId.Size = new System.Drawing.Size(201, 30);
			this.TxtDersId.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(136, 107);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 25);
			this.label11.TabIndex = 6;
			this.label11.Text = "AD:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(145, 64);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(37, 25);
			this.label12.TabIndex = 7;
			this.label12.Text = "ID:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.BtnJoin);
			this.groupBox3.Controls.Add(this.BtnNotHesapla);
			this.groupBox3.Controls.Add(this.TxtDurum);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.TxtOrtalama);
			this.groupBox3.Controls.Add(this.TxtSinav3);
			this.groupBox3.Controls.Add(this.TxtSinav2);
			this.groupBox3.Controls.Add(this.TxtSinav1);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Location = new System.Drawing.Point(861, 281);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(439, 408);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Notlar";
			// 
			// BtnJoin
			// 
			this.BtnJoin.Location = new System.Drawing.Point(95, 338);
			this.BtnJoin.Name = "BtnJoin";
			this.BtnJoin.Size = new System.Drawing.Size(290, 41);
			this.BtnJoin.TabIndex = 15;
			this.BtnJoin.Text = "Join ile getir";
			this.BtnJoin.UseVisualStyleBackColor = true;
			this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
			// 
			// BtnNotHesapla
			// 
			this.BtnNotHesapla.Location = new System.Drawing.Point(95, 283);
			this.BtnNotHesapla.Name = "BtnNotHesapla";
			this.BtnNotHesapla.Size = new System.Drawing.Size(290, 41);
			this.BtnNotHesapla.TabIndex = 14;
			this.BtnNotHesapla.Text = "Hesapla";
			this.BtnNotHesapla.UseVisualStyleBackColor = true;
			// 
			// TxtDurum
			// 
			this.TxtDurum.Location = new System.Drawing.Point(184, 239);
			this.TxtDurum.Name = "TxtDurum";
			this.TxtDurum.Size = new System.Drawing.Size(201, 30);
			this.TxtDurum.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(90, 242);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(90, 25);
			this.label9.TabIndex = 12;
			this.label9.Text = "DURUM:";
			// 
			// TxtOrtalama
			// 
			this.TxtOrtalama.Location = new System.Drawing.Point(184, 190);
			this.TxtOrtalama.Name = "TxtOrtalama";
			this.TxtOrtalama.Size = new System.Drawing.Size(201, 30);
			this.TxtOrtalama.TabIndex = 8;
			// 
			// TxtSinav3
			// 
			this.TxtSinav3.Location = new System.Drawing.Point(184, 145);
			this.TxtSinav3.Name = "TxtSinav3";
			this.TxtSinav3.Size = new System.Drawing.Size(201, 30);
			this.TxtSinav3.TabIndex = 9;
			// 
			// TxtSinav2
			// 
			this.TxtSinav2.Location = new System.Drawing.Point(184, 102);
			this.TxtSinav2.Name = "TxtSinav2";
			this.TxtSinav2.Size = new System.Drawing.Size(201, 30);
			this.TxtSinav2.TabIndex = 10;
			// 
			// TxtSinav1
			// 
			this.TxtSinav1.Location = new System.Drawing.Point(184, 59);
			this.TxtSinav1.Name = "TxtSinav1";
			this.TxtSinav1.Size = new System.Drawing.Size(201, 30);
			this.TxtSinav1.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(50, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "ORTALAMA:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(85, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 25);
			this.label6.TabIndex = 5;
			this.label6.Text = "SINAV 3:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(85, 107);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 25);
			this.label7.TabIndex = 6;
			this.label7.Text = "SINAV 2:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(85, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 25);
			this.label8.TabIndex = 7;
			this.label8.Text = "SINAV 1:";
			// 
			// BtnDersListesi
			// 
			this.BtnDersListesi.Location = new System.Drawing.Point(0, 556);
			this.BtnDersListesi.Name = "BtnDersListesi";
			this.BtnDersListesi.Size = new System.Drawing.Size(232, 49);
			this.BtnDersListesi.TabIndex = 5;
			this.BtnDersListesi.Text = "Ders Listesi";
			this.BtnDersListesi.UseVisualStyleBackColor = true;
			this.BtnDersListesi.Click += new System.EventHandler(this.BtnDersListesi_Click);
			// 
			// BtnNotListesi
			// 
			this.BtnNotListesi.Location = new System.Drawing.Point(0, 611);
			this.BtnNotListesi.Name = "BtnNotListesi";
			this.BtnNotListesi.Size = new System.Drawing.Size(232, 49);
			this.BtnNotListesi.TabIndex = 6;
			this.BtnNotListesi.Text = "Not Listesi";
			this.BtnNotListesi.UseVisualStyleBackColor = true;
			this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(0, 336);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(232, 49);
			this.BtnKaydet.TabIndex = 7;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.Location = new System.Drawing.Point(0, 391);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(232, 49);
			this.BtnSil.TabIndex = 8;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.Location = new System.Drawing.Point(0, 446);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(232, 49);
			this.BtnGuncelle.TabIndex = 9;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = true;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// BtnProsedur
			// 
			this.BtnProsedur.Location = new System.Drawing.Point(0, 666);
			this.BtnProsedur.Name = "BtnProsedur";
			this.BtnProsedur.Size = new System.Drawing.Size(232, 49);
			this.BtnProsedur.TabIndex = 10;
			this.BtnProsedur.Text = "Prosedür";
			this.BtnProsedur.UseVisualStyleBackColor = true;
			this.BtnProsedur.Click += new System.EventHandler(this.BtnProsedur_Click);
			// 
			// BtnBul
			// 
			this.BtnBul.Location = new System.Drawing.Point(0, 501);
			this.BtnBul.Name = "BtnBul";
			this.BtnBul.Size = new System.Drawing.Size(232, 49);
			this.BtnBul.TabIndex = 11;
			this.BtnBul.Text = "Bul";
			this.BtnBul.UseVisualStyleBackColor = true;
			this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(1311, 30);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(243, 29);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Ada Göre Sırala (A-->Z)";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// BtnLinqEntity
			// 
			this.BtnLinqEntity.Location = new System.Drawing.Point(1306, 489);
			this.BtnLinqEntity.Name = "BtnLinqEntity";
			this.BtnLinqEntity.Size = new System.Drawing.Size(177, 35);
			this.BtnLinqEntity.TabIndex = 13;
			this.BtnLinqEntity.Text = "Linq Entity";
			this.BtnLinqEntity.UseVisualStyleBackColor = true;
			this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(1311, 60);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(244, 29);
			this.radioButton2.TabIndex = 14;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Ada Göre SIrala (Z-->A)";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(1311, 90);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(117, 29);
			this.radioButton3.TabIndex = 15;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "İlk 3 Kayıt";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(1311, 120);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(211, 29);
			this.radioButton4.TabIndex = 16;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "ID\'ye Göre Veri Getir";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(1311, 150);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(212, 29);
			this.radioButton5.TabIndex = 17;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Adı A ile Başlayanlar";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(1311, 180);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(175, 29);
			this.radioButton6.TabIndex = 18;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "Adı A ile Bitenler";
			this.radioButton6.UseVisualStyleBackColor = true;
			// 
			// radioButton7
			// 
			this.radioButton7.AutoSize = true;
			this.radioButton7.Location = new System.Drawing.Point(1311, 210);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(147, 29);
			this.radioButton7.TabIndex = 19;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "Değer Var mı";
			this.radioButton7.UseVisualStyleBackColor = true;
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Location = new System.Drawing.Point(1311, 245);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(231, 29);
			this.radioButton8.TabIndex = 20;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "Toplam Öğrenci Sayısı";
			this.radioButton8.UseVisualStyleBackColor = true;
			// 
			// radioButton9
			// 
			this.radioButton9.AutoSize = true;
			this.radioButton9.Location = new System.Drawing.Point(1311, 280);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(221, 29);
			this.radioButton9.TabIndex = 21;
			this.radioButton9.TabStop = true;
			this.radioButton9.Text = "Sınav 1 Toplam Puan";
			this.radioButton9.UseVisualStyleBackColor = true;
			// 
			// radioButton10
			// 
			this.radioButton10.AutoSize = true;
			this.radioButton10.Location = new System.Drawing.Point(1311, 315);
			this.radioButton10.Name = "radioButton10";
			this.radioButton10.Size = new System.Drawing.Size(239, 29);
			this.radioButton10.TabIndex = 22;
			this.radioButton10.TabStop = true;
			this.radioButton10.Text = "Sınav 1 Ortalama Puanı";
			this.radioButton10.UseVisualStyleBackColor = true;
			// 
			// radioButton11
			// 
			this.radioButton11.AutoSize = true;
			this.radioButton11.Location = new System.Drawing.Point(1311, 350);
			this.radioButton11.Name = "radioButton11";
			this.radioButton11.Size = new System.Drawing.Size(385, 29);
			this.radioButton11.TabIndex = 23;
			this.radioButton11.TabStop = true;
			this.radioButton11.Text = "Sınav 1 notu ortalamadan yüksek olanlar";
			this.radioButton11.UseVisualStyleBackColor = true;
			// 
			// radioButton12
			// 
			this.radioButton12.AutoSize = true;
			this.radioButton12.Location = new System.Drawing.Point(1311, 383);
			this.radioButton12.Name = "radioButton12";
			this.radioButton12.Size = new System.Drawing.Size(193, 29);
			this.radioButton12.TabIndex = 24;
			this.radioButton12.TabStop = true;
			this.radioButton12.Text = "En Yüksek Sınav1";
			this.radioButton12.UseVisualStyleBackColor = true;
			// 
			// radioButton13
			// 
			this.radioButton13.AutoSize = true;
			this.radioButton13.Location = new System.Drawing.Point(1311, 418);
			this.radioButton13.Name = "radioButton13";
			this.radioButton13.Size = new System.Drawing.Size(184, 29);
			this.radioButton13.TabIndex = 25;
			this.radioButton13.TabStop = true;
			this.radioButton13.Text = "En Düşük Sınav1";
			this.radioButton13.UseVisualStyleBackColor = true;
			// 
			// radioButton14
			// 
			this.radioButton14.AutoSize = true;
			this.radioButton14.Location = new System.Drawing.Point(1311, 453);
			this.radioButton14.Name = "radioButton14";
			this.radioButton14.Size = new System.Drawing.Size(306, 29);
			this.radioButton14.TabIndex = 26;
			this.radioButton14.TabStop = true;
			this.radioButton14.Text = "En Yüksek Sınav Notu Kime Ait";
			this.radioButton14.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1306, 579);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(169, 51);
			this.button1.TabIndex = 27;
			this.button1.Text = "2.Sayfa";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1588, 727);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton14);
			this.Controls.Add(this.radioButton13);
			this.Controls.Add(this.radioButton12);
			this.Controls.Add(this.radioButton11);
			this.Controls.Add(this.radioButton10);
			this.Controls.Add(this.radioButton9);
			this.Controls.Add(this.radioButton8);
			this.Controls.Add(this.radioButton7);
			this.Controls.Add(this.radioButton6);
			this.Controls.Add(this.radioButton5);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.BtnLinqEntity);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.BtnBul);
			this.Controls.Add(this.BtnProsedur);
			this.Controls.Add(this.BtnGuncelle);
			this.Controls.Add(this.BtnSil);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.BtnNotListesi);
			this.Controls.Add(this.BtnDersListesi);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BtnOgrenciListele);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button BtnOgrenciListele;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TxtFoto;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.TextBox TxtOgrenciId;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox TxtDersAd;
		private System.Windows.Forms.TextBox TxtDersId;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox TxtOrtalama;
		private System.Windows.Forms.TextBox TxtSinav3;
		private System.Windows.Forms.TextBox TxtSinav2;
		private System.Windows.Forms.TextBox TxtSinav1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button BtnDersListesi;
		private System.Windows.Forms.Button BtnNotListesi;
		private System.Windows.Forms.Button BtnJoin;
		private System.Windows.Forms.Button BtnNotHesapla;
		private System.Windows.Forms.TextBox TxtDurum;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Button BtnSil;
		private System.Windows.Forms.Button BtnGuncelle;
		private System.Windows.Forms.Button BtnProsedur;
		private System.Windows.Forms.Button BtnBul;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button BtnLinqEntity;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.RadioButton radioButton10;
		private System.Windows.Forms.RadioButton radioButton11;
		private System.Windows.Forms.RadioButton radioButton12;
		private System.Windows.Forms.RadioButton radioButton13;
		private System.Windows.Forms.RadioButton radioButton14;
		private System.Windows.Forms.Button button1;
	}
}

