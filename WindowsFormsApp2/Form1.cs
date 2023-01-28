/*
 * @file        WindowsFormsApp2
 * @description Veritabanı yönetim sistemi uygulaması
 * @course      1.Oğretim C Grubu
 * @assignment  1.Proje
 * @date        20.12.2021
 * @author      Abdulkadir Baştuğ abdulkadir.bastug@ogr.sakarya.edu.tr 
 */
using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;database=vb;user Id=postgres;password=postgres;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            connection.Open();
            string sorgu = "select * from personel";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

           

            connection.Open();
            
            NpgsqlCommand command = new NpgsqlCommand("insert into personel(ad,soyad,cinsiyet,dogum_tarihi,dogum_yeri,baslama_tarihi,birim_no,unvan_no,calisma_saati,maas,prim) VALUES " +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",connection);
            command.Parameters.AddWithValue("@p1", text_ad.Text);
            command.Parameters.AddWithValue("@p2", text_soyad.Text);
            command.Parameters.AddWithValue("@p3", text_cins.Text);
            command.Parameters.AddWithValue("@p4", Convert.ToDateTime(text_dogum.Text));
            command.Parameters.AddWithValue("@p5", int.Parse(text_ilce.Text));
            command.Parameters.AddWithValue("@p6", Convert.ToDateTime(text_basla.Text));
            command.Parameters.AddWithValue("@p7", int.Parse(text_birim.Text));
            command.Parameters.AddWithValue("@p8", int.Parse(text_unvan.Text));
            command.Parameters.AddWithValue("@p9", int.Parse(text_calisma.Text));
            command.Parameters.AddWithValue("@p10", int.Parse(text_maas.Text));
            command.Parameters.AddWithValue("@p11", int.Parse(text_prim.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personel ekleme işlemi başarıyla gerçekleşti.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;database=vb;user Id=postgres;password=postgres;");


            baglanti.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("delete from personel where personel_no=@p1", baglanti);
            command2.Parameters.AddWithValue("@p1", int.Parse(text_no.Text));
            command2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personel silme işlemi başarıyla gerçekleşti","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            
            connection.Open();
            NpgsqlCommand komut4=new NpgsqlCommand("select * from personel where personel_no=@p1",connection);
            komut4.Parameters.AddWithValue("p1",int.Parse(text_no.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            connection.Close();
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("update personel set ad=@p1,soyad=@p2,cinsiyet=@p3,dogum_tarihi=@p4,dogum_yeri=@p5,baslama_tarihi=@p6,birim_no=@p7,unvan_no=@p8,calisma_saati=@p9,maas=@p10,prim=@p11 where personel_no=@p12", connection);
            command3.Parameters.AddWithValue("@p1", text_ad.Text);
            command3.Parameters.AddWithValue("@p2", text_soyad.Text);
            command3.Parameters.AddWithValue("@p3", text_cins.Text);
            command3.Parameters.AddWithValue("@p4", Convert.ToDateTime(text_dogum.Text));
            command3.Parameters.AddWithValue("@p5", int.Parse(text_ilce.Text));
            command3.Parameters.AddWithValue("@p6", Convert.ToDateTime(text_basla.Text));
            command3.Parameters.AddWithValue("@p7", int.Parse(text_birim.Text));
            command3.Parameters.AddWithValue("@p8", int.Parse(text_unvan.Text));
            command3.Parameters.AddWithValue("@p9", int.Parse(text_calisma.Text));
            command3.Parameters.AddWithValue("@p10", int.Parse(text_maas.Text));
            command3.Parameters.AddWithValue("@p11", int.Parse(text_prim.Text));
            command3.Parameters.AddWithValue("@p12",int.Parse(text_no.Text));
            command3.ExecuteNonQuery();
            connection.Close(); 
            MessageBox.Show("Ürün başarıyla güncelleştirildi.");
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
