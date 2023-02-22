using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOrnek
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

		
		private void BtnLinqEntity_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				//1.Sınav Notu 50'den Düşük Olanlar
				var degerler = db.TBLNOTLAR.Where(x => x.SINAV1 < 50);
				dataGridView1.DataSource = degerler.ToList();
			}
			if (radioButton2.Checked == true)
			{
				//Adı Ali Olanlar
				var degerler = db.TBLOGRENCI.Where(x => x.AD == "ali");
				dataGridView1.DataSource = degerler.ToList();
			}
			if (radioButton3.Checked == true)
			{
				//Adı ve soyadını texboxtan girilen değere göre sırala
				var degerler = db.TBLOGRENCI.Where(x => x.AD == textBox1.Text || x.SOYAD == textBox1.Text);
				dataGridView1.DataSource = degerler.ToList();
			}
			if (radioButton4.Checked == true)
			{
				//Soyadlarını listeler
				var degerler = db.TBLOGRENCI.Select(x => new { soyadı = x.SOYAD });
				dataGridView1.DataSource = degerler.ToList();
			}
			if (radioButton5.Checked == true)
			{
				//Adı büyük soyadı küçük listeler
				var degerler = db.TBLOGRENCI.Select(x =>
				new
				{
					Ad = x.AD.ToUpper(),
					Soyadı = x.SOYAD.ToLower()
				});
				dataGridView1.DataSource = degerler.ToList();
			}
			if (radioButton6.Checked == true)
			{
				//Seçilen degerlere şart uyguladık adı Ali olmayanları sıralar
				var degerler = db.TBLOGRENCI.Select(x =>
				new
				{
					Ad = x.AD.ToUpper(),
					Soyadı = x.SOYAD.ToLower()
				}).Where(x => x.Ad != "Ali");
				dataGridView1.DataSource = degerler.ToList(); 
			}
			if (radioButton7.Checked == true)
			{
				//Seçilen degerleri getirdik
				var degerler = db.TBLNOTLAR.Select(x => new
				{
					OgrenciAd = x.OGR,
					Ortalaması = x.ORTALAMA,
					Durumu = x.DURUM==true ? "Geçti" : "Kaldı"
				});
				dataGridView1.DataSource = degerler.ToList();
			}
			if (radioButton8.Checked == true)
			{
				// Birden fazla tablo kullanarak istediğimiz verileri çektik
				var degerler = db.TBLNOTLAR.SelectMany(x => db.TBLOGRENCI.Where(y => y.ID == x.OGR), (x, y) => new
				{
					y.AD,
					x.ORTALAMA,
					Durum = x.DURUM == true ? "Geçti" : "Kaldı"
				});
				dataGridView1.DataSource = degerler.ToList();
			}
			if (radioButton9.Checked == true)
			{
				//İlk 3 Değeri Alır
				var degerler = db.TBLOGRENCI.OrderBy(x => x.ID).Take(3);
				dataGridView1.DataSource = degerler.ToList();
			}
			if (radioButton10.Checked == true)
			{
				//Son 3 Değeri Alır
				var degerler = db.TBLOGRENCI.OrderByDescending(x => x.ID).Take(3);
				dataGridView1.DataSource = degerler.ToList();
			}
			if (radioButton11.Checked == true)
			{
				//Ada göre alfabetik sıralar
				var degerler = db.TBLOGRENCI.OrderBy(x => x.AD);
				dataGridView1.DataSource = degerler.ToList();
			}
			if (radioButton12.Checked == true)
			{
				//İlk 3 Değeri Alır
				var degerler = db.TBLOGRENCI.OrderBy(x => x.ID).Skip(5);
				dataGridView1.DataSource = degerler.ToList();
			}
		}



		private void button1_Click(object sender, EventArgs e)
		{
			//Sayfalar arası geçiş
			Form1 frm1 = new Form1();
			frm1.Show();
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//Sayfalar arası geçiş
			Form4 frm4 = new Form4();
			frm4.Show();
			Close();
		}

	}
}
