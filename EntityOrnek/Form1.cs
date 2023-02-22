using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntityOrnek
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
		private void button1_Click(object sender, EventArgs e)
		{
			//Entity ile Öğrenci verilerini listeleyebiliyoruz.
			dataGridView1.DataSource = db.TBLOGRENCI.ToList();

			//İstemediğimiz sütünları çıkartabiliyoruz
			dataGridView1.Columns[3].Visible = false;
			dataGridView1.Columns[4].Visible = false;
		}// Öğrenci Listesi

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void BtnDersListesi_Click(object sender, EventArgs e)
		{

			SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-F5NS8T2U\SQLEXPRESS;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
			SqlCommand komut = new SqlCommand("Select * From tbldersler", baglanti);
			SqlDataAdapter da = new SqlDataAdapter(komut);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void BtnNotListesi_Click(object sender, EventArgs e)
		{
			//foreach (var item in collection)
			//{

			//}
			var query = from item in db.TBLNOTLAR
						select new
						{
							item.NOTID,
							item.TBLOGRENCI.AD,
							item.TBLOGRENCI.SOYAD,
							item.TBLDERSLER.DERSAD,
							item.SINAV1,
							item.SINAV2,
							item.SINAV3,
							item.ORTALAMA,
							item.DURUM
						};
			dataGridView1.DataSource = query.ToList();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			//Öğrenci Ekleme işlemi
			TBLOGRENCI t = new TBLOGRENCI();
			t.AD = TxtAd.Text;
			t.SOYAD = TxtSoyad.Text;
			db.TBLOGRENCI.Add(t);
			db.SaveChanges();
			MessageBox.Show("Öğrenci Listeye Eklenmiştir");
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(TxtOgrenciId.Text);
			var x = db.TBLOGRENCI.Find(id);
			db.TBLOGRENCI.Remove(x);
			db.SaveChanges();
			MessageBox.Show("Öğrenci Sistemden Silindi");
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(TxtOgrenciId.Text);
			var x = db.TBLOGRENCI.Find(id);
			x.AD = TxtAd.Text;
			x.SOYAD = TxtSoyad.Text;
			x.FOTOGRAF = TxtFoto.Text;
			db.SaveChanges();
			MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellendi");
		}

		private void BtnProsedur_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.NOTLISTESI();
		}

		private void BtnBul_Click(object sender, EventArgs e)
		{
			//İstenilen ad ve soyada göre filtreliyor
			dataGridView1.DataSource = db.TBLOGRENCI.Where(x => x.AD == TxtAd.Text | x.SOYAD == TxtSoyad.Text).ToList();
		}

		private void TxtAd_TextChanged(object sender, EventArgs e)
		{
			//Ad kısmına yazdığımız harflere göre öğrenci listesini bize filtreliyecek
			string aranan = TxtAd.Text;
			var degerler = from item in db.TBLOGRENCI
						   where item.AD.Contains(aranan)
						   select item;
			dataGridView1.DataSource = degerler.ToList();
		}

		private void BtnLinqEntity_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				//A dan Z ye sıralar 
				//Asc - Ascending
				List<TBLOGRENCI> liste1 = db.TBLOGRENCI.OrderBy(p => p.AD).ToList();
				dataGridView1.DataSource = liste1;
			}
			if (radioButton2.Checked == true)
			{
				//Z den A ya sıralar
				//Desc - Descending
				List<TBLOGRENCI> liste2 = db.TBLOGRENCI.OrderByDescending(p => p.AD).ToList();
				dataGridView1.DataSource = liste2;
			}
			if (radioButton3.Checked == true)
			{
				//İlk 3 ismi sıralar
				List<TBLOGRENCI> liste3 = db.TBLOGRENCI.OrderBy(p => p.AD).Take(3).ToList();
				dataGridView1.DataSource = liste3;
			}
			if (radioButton4.Checked == true)
			{
				//ID'ye göre sıralar
				List<TBLOGRENCI> liste4 = db.TBLOGRENCI.Where(p => p.ID == 5).ToList();
				dataGridView1.DataSource = liste4;
			}
			if (radioButton5.Checked == true)
			{
				//Adı A ile başlayanları getirir
				List<TBLOGRENCI> liste5 = db.TBLOGRENCI.Where(p => p.AD.StartsWith("a")).ToList();
				dataGridView1.DataSource = liste5;
			}
			if (radioButton6.Checked == true)
			{
				//Adı A ile bitenleri getirir
				List<TBLOGRENCI> liste6 = db.TBLOGRENCI.Where(p => p.AD.EndsWith("a")).ToList();
				dataGridView1.DataSource = liste6;
			}
			if (radioButton7.Checked == true)
			{
				//Deger var mı yok mu onu getirir.
				bool deger = db.TBLOGRENCI.Any();
				MessageBox.Show(deger.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			if (radioButton8.Checked == true)
			{
				//Toplam Öğrenci Sayısını Getirir.
				int toplam = db.TBLOGRENCI.Count();
				MessageBox.Show(toplam.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			if (radioButton9.Checked == true)
			{
				//Sınav 1 in toplamını Getirir.
				var toplam = db.TBLNOTLAR.Sum(p => p.SINAV1);
				MessageBox.Show("1.Sınavın Toplamı:" + toplam.ToString());
			}
			if (radioButton10.Checked == true)
			{
				//Sınav 1 in Ortalamasını Getirir.
				var ortalama = db.TBLNOTLAR.Average(p => p.SINAV1);
				MessageBox.Show(" 1.Sınavın Ortalaması:" + ortalama.ToString());
			}
			if (radioButton11.Checked == true)
			{
				//Sınav 1 in Ortalamadan yüksek olanları Getirir.
				var ortalama = db.TBLNOTLAR.Average(p => p.SINAV1);
				List<NOTLISTESI_Result> liste11 = db.NOTLISTESI().Where(p => p.SINAV1 > ortalama).ToList();
				dataGridView1.DataSource = liste11;
			}
			if (radioButton12.Checked == true)
			{
				//Sınav notu en yüksek olanı getirir
				var enyuksek = db.TBLNOTLAR.Max(p => p.SINAV1);
				MessageBox.Show("1.Sınavın En Yüksek Notu: " + enyuksek);
			}
			if (radioButton13.Checked == true)
			{
				//Sınav notu en düşük olanı getirir
				var endusuk = db.TBLNOTLAR.Min(p => p.SINAV1);
				MessageBox.Show("1.Sınavın En Düşük Notu: " + endusuk);
			}
			if (radioButton14.Checked == true)
			{
				//Sınav notu en yüksek olanın ismini listeler
				var enyuksek = db.TBLNOTLAR.Max(p => p.SINAV1);
				List<NOTLISTESI_Result> liste14 = db.NOTLISTESI().Where(p => p.SINAV1 == enyuksek).ToList();
				dataGridView1.DataSource = liste14;
			}
		}

		private void BtnJoin_Click(object sender, EventArgs e)
		{
			//Join işlemiyle birleştirme methodu
			var sorgu = from d1 in db.TBLNOTLAR
						join d2 in db.TBLOGRENCI
						on d1.OGR equals d2.ID
						join d3 in db.TBLDERSLER
						on d1.DERS equals d3.DERSID
						select new
						{
							ÖĞRENCİ = d2.AD + " " + d2.SOYAD,
							//SOYAD = d2.SOYAD,
							DERS = d3.DERSAD,
							SINAV1 = d1.SINAV1,
							SINAV2 = d1.SINAV2,
							SINAV3 = d1.SINAV3,
							ORTALAMA = d1.ORTALAMA
						};
			dataGridView1.DataSource = sorgu.ToList();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			//Formlar arası geçiş
			Form3 frm3 = new Form3();
			frm3.Show();
			Hide();
		}
	}
}
