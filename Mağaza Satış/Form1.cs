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
using System.ComponentModel.Design;

namespace Mağaza_Satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti =new SqlConnection(@"Data Source=KAAN\SQLEXPRESS;Initial Catalog=DbHareket;Integrated Security=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHareketDataSet.Hareket' table. You can move, or remove it, as needed.
            this.hareketTableAdapter.Fill(this.dbHareketDataSet.Hareket);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Hareket (ÜRÜN AD, Müşteri , Personel , Fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMusteri.Text);
            komut.Parameters.AddWithValue("@p3", txtPersonel.Text);
            komut.Parameters.AddWithValue("@p4", maskedTxtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("eklendi");
            this.hareketTableAdapter.Fill(this.dbHareketDataSet.Hareket);
        }
    }
}
