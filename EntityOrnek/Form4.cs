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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Formlar arası geçiş
			Form3 frm3 = new Form3();
			frm3.Show();
			Close();
		}
		DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
		private void BtnLinqEntity_Click(object sender, EventArgs e)
		{
			var degerler = db.TBLOGRENCI.OrderBy(x => x.SEHIR).GroupBy(y => y.SEHIR).
				Select(z => new { Şehir = z.Key, Toplam = z.Count() });
			dataGridView1.DataSource = degerler.ToList();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label1.Text = db.TBLNOTLAR.Max(x => x.SINAV1).ToString();
			label2.Text = db.TBLNOTLAR.Min(x => x.SINAV1).ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var degerler = db.TBLNOTLAR.Where(x => x.DURUM == false).
				OrderByDescending(y => y.ORTALAMA).Take(1).
				SelectMany(z => db.TBLOGRENCI.Where(y => y.ID == z.OGR), (z, y) =>
				new
				{
					y.AD,
					y.SOYAD,
					z.ORTALAMA
				});

			dataGridView1.DataSource = degerler.ToList();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			//label1.Text = db.TBLURUN.Count().ToString();
			//label1.Text = db.TBLURUN.Count(x=>x.AD == "BUZDOLABI").ToString();
			//label1.Text = db.TBLURUN.Sum(x=>x.STOK).ToString();
			//label1.Text = db.TBLURUN.Average(x => x.FIYAT).ToString();
			//label1.Text = "Ortalma Buzdolabı Fiyatı" + db.TBLURUN.Where(x => x.AD == "BUZDOLABI").Average(x => x.FIYAT).ToString();
			/*
			label1.Text = (from x in db.TBLURUN
						   orderby x.STOK ascending
						   select x.AD).First();
			*****************************************************************************************
			
			label1.Text = db.TBLURUN.OrderByDescending(x => x.STOK).
				Select(x => x.AD).
				FirstOrDefault();
			*/
			dataGridView1.DataSource = db.Kulupler().ToList();
		}
	}
}
