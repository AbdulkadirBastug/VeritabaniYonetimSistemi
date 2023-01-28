Uygulama:
 Şirketteki çalışanların bilgilerini tutmak. Şirkete çalışan ekleme çıkarma güncelleme ve çalışanları listeleme gibi işlemler yapabilen bir uygulama tasarlamak. 
İş Kuralları:
1)Her bir personel en az bir birimde yer alır.
2)Her bir personel en fazla bir birimde yer alır.
3)Her birimde en az bir personel vardır.
4)Her birimde birden fazla personel olabilir.
5)Bir personelin birden fazla çocuğu olabilir.
6)Bir çocuğun en fazla bir personel ailesi olabilir.
7)Bir ilçede birden fazla personel doğmuş olabilir.
8)Bir personel en fazla bir ilçede doğabilir.
9)Bir ilçede hiç personel doğmamış olabilir.
10)Bir ilde birçok ilçe olabilir.
11)Bir ilçenin en az bir ilde bulunur.
12)Bir ilde en az bir ilçe vardır.
13)Bir ilçe en çok bir ilde bulunur.
14)Bir personelin en az bir unvanı vardır.
15)Bir personelin en çok bir unvanı vardır.
16)Bir unvan birçok personele ait olabilir.
17)Bir unvan en az bir personele aittir.
18)Bir projede birçok görevlendirme olabilir.
19)Bir projede en az bir görevlendirme vardır.
20)Bir görev birçok projede olabilir.
21)Bir görev hiçbir projede olmayabilir.
22)Bir personel bir görevlendirmede yer alabilir.
23)Bir görevlendirmede birçok personel olabilir.
24)Bir personel en az bir görevlendirmede yer alır
25)Bir görevlendirmede hiç personel olmayabilir.
26)Bir personelin hiç çocuğu olmayabilir.
27)Bir çocuk en fazla bir ilçede doğabilir.
28)Bir ilçede birçok çocuk doğmuş olabilir.
29)Bir ilçede hiç çocuk doğamamış olabilir.
30)Bir çocuk en az bir ilçede doğmuştur.
31)Bir personel en az bir ilçede doğmuştur.
İlişkisel Şema:
Birim (birim_no:int, birim_ad: varchar)
Unvan (unvan_no:int , unvan_ad: varchar)
İl (il_no :char , il_ad :varchar)
İlce (ilce_no:int, ilce_ad:varchar, il_no :char)
Proje (proje_no:int, proje_ad:varchar, baslama_tarihi:date, planlanan_bitis_tarihi:date)
Personel (personel_no:int, ad:varchar, soyad:varchar, cinsiyet:char, dogum_tarihi:date, dogum_yeri:int, baslama_tarihi:date, birim_no:int, unvan_no:INT REFERENCES unvan(unvan_no), calisma_saati:tinyint, maas:money, prim:money)
Çocuk (cocuk_no:int, ad:varchar, soyad:varchar, cinsiyet:char, dogum_tarihi :date, dogu_yeri :int, personel_no:int)
Gorevlendirme (gorevlendirme_no:int, proje_no:int,personel_no:int)
 

SQL ifadeleri:
CREATE DATABASE sirket;


CREATE TABLE birim
(
birim_no SERIAL PRIMARY KEY,
birim_ad VARCHAR(20) UNIQUE NOT NULL
);

INSERT INTO birim(birim_ad) VALUES ('KALITE'),('IDARI'),('ARGE'),('TEKNIK');

CREATE TABLE unvan (
unvan_no SERIAL PRIMARY KEY,
unvan_ad VARCHAR(20) UNIQUE NOT NULL
);

INSERT INTO unvan(unvan_ad) VALUES ('MUHENDIS'),('IK UZMANI'),('TEKNISYEN');

CREATE TABLE il (
il_no CHAR(2) PRIMARY KEY,
il_ad VARCHAR(20) UNIQUE NOT NULL
);

INSERT INTO il VALUES ('06','ANKARA'),('34','ISTANBUL'),('35','IZMIR');

CREATE TABLE ilce (
ilce_no SERIAL PRIMARY KEY,
ilce_ad VARCHAR(20) NOT NULL,
il_no CHAR(2) NOT NULL,
CONSTRAINT ilceTekil UNIQUE (ilce_ad,il_no)
);

ALTER TABLE ilce ADD CONSTRAINT Fk_ilno
FOREIGN KEY (il_no) REFERENCES il(il_no)

INSERT INTO ilce(ilce_ad,il_no) VALUES 
('CANKAYA','06'),('POLATLI','06'),('YENIMAHALLE','06'),('AVCILAR','34'),
('BEYLIKDUZU','34'),('ESENYURT','34'),('BUCA','35'),('KARSIYAKA','35'),('KONAK','35');

CREATE TABLE proje (
proje_no SERIAL PRIMARY KEY,
proje_ad VARCHAR(20) UNIQUE NOT NULL,
baslama_tarihi DATE NOT NULL,
planlanan_bitis_tarihi DATE NOT NULL
);

INSERT INTO proje(proje_ad,baslama_tarihi,planlanan_bitis_tarihi) VALUES
('TEMIZ DUNYA','2015.01.20','2017.01.11'),
('GUVENLI INTERNET','2017.05.15','2020.06.09'),
('UTOPİK DUNYA','2017.07.11','2019.11.29'),
('AKILLI EVLER','2018.02.10','2021.11.29'),
('VARLIK','2018.03.01','2019.11.29');

CREATE TABLE personel (
personel_no SERIAL PRIMARY KEY,
ad VARCHAR(25) NOT NULL, 
soyad VARCHAR(25) NOT NULL,
cinsiyet CHAR(1) NOT NULL,
dogum_tarihi DATE NOT NULL,
dogum_yeri INT NOT NULL,
baslama_tarihi date NOT NULL,
birim_no SMALLINT NOT NULL,
unvan_no SMALLINT NOT NULL,
calisma_saati SMALLINT NOT NULL,
maas INT NOT NULL,
prim INT DEFAULT 0
);

ALTER TABLE "personel" 
ADD CONSTRAINT Fk_birimno FOREIGN KEY (birim_no) REFERENCES birim(birim_no),
ADD CONSTRAINT Fk_unvanno FOREIGN KEY (unvan_no) REFERENCES unvan(unvan_no),
ADD CONSTRAINT Fk_dogumyeri FOREIGN KEY (dogum_yeri) REFERENCES ilce(ilce_no)

INSERT INTO personel(ad,soyad,cinsiyet,dogum_tarihi,dogum_yeri,baslama_tarihi,birim_no,unvan_no,calisma_saati,maas,prim) VALUES
('Ahmet','EKINCI','E','1985.03.25',2,'2002.03.01',1,1,35,2500,350),
('Burak','TURHAN','E','1980.04.15',3,'2002.05.03',2,2,30,2800,250),
('Ceyda','SAKARYA','K','1983.03.23',7,'2005.05.12',2,3,30,3000,250),
('Demet','COLAK','K','1982.05.05',5,'2005.06.17',3,3,40,2800,350),
('Evrim','CITAK','K','1987.12.05',1,'2000.01.12',2,1,30,4500,500),
('Figen','ESMER','K','1982.10.22',4,'1998.05.07',1,2,35,4000,250),
('Galip','TANAR','E','1983.02.28',9,'1997.05.07',1,2,35,5200,450),
('Emir','YANIK','E','1975.05.07',2,'2010.07.17',2,2,45,4500,450),
('Ilgın','ACI','E','1974.05.01',2,'2000.08.18',3,2,40,4200,400),
('Iskender','TAS','E','1974.07.02',7,'1995.09.05',4,1,40,4400,400),
('Jale','CAN','K','1976.09.18',	5,'1998.10.12',2,2,45,3250,450),
('Kamil','ALBAYRAK','E','1976.08.19',9,'2000.11.25',1,2,30,5200,250),
('Leman','HASKIRIS','K','1978.09.20',6,'1999.10.27',1,2,35,4200,350),
('Meltem','UYSAL','K','1985.08.04',6,'2000.05.27',1,2,30,2500,100),
('Necati','UYSAL','E','1990.12.01',4,'2000.03.06',2,1,30,2000,150),
('Osman','UYSAL','E','1982.02.15',6,'1995.05.12',4,3,30,4800,150),
('Omer','BUZDAG','E','1980.10.30',5,'2001.08.10',1,2,40,4800,400),
('Perihan','KANAT','K','1980.10.28',4,'2001.07.11',4,1,30,2200,300),
('Ramiz','CAKIR','E','1981.11.19',7,'2001.07.30',4,3,30,2700,300),
('Sertaç','KOSEDAG','E','1981.12.20',9,'2002.12.20',3,2,30,2900,350),
('Sefik','CAPANOGLU','E','1982.02.20',6,'1998.05.25',3,3,30,4800,200),
('Taner','BOZOKLU','E','1983.07.21',5,'2005.09.05',1,2,30,3000,200),
('Utku','DUMAN','E','1975.06.13',6,'2005.03.05',1,3,30,2800,200),
('Umit','SIRIN','E','1978.04.02',7,'1998.04.04',2,2,35,3300,250),
('Veysel','ERTUZUN','E','1980.07.03',3,'2002.07.18',4,3,35,3100,300),
('Yakup','GOKCE','E','1975.06.18',2,'2002.03.25',4,3,35,3100,450),
('Zeliha','CANIS','K','1978.03.03',5,'2005.08.13',1,3,40,2500,500)

CREATE TABLE cocuk (
cocuk_no SERIAL PRIMARY KEY,
ad VARCHAR(25) NOT NULL, 
soyad VARCHAR(25) NOT NULL,
cinsiyet CHAR(1),
dogum_tarihi DATE UNIQUE NOT NULL,
dogum_yeri INT NOT NULL,
personel_no INT NOT NULL
);

ALTER TABLE cocuk 
ADD CONSTRAINT Fk_dogumyeri FOREIGN KEY (dogum_yeri) REFERENCES ilce(ilce_no);
ALTER TABLE "public"."cocuk"
	ADD CONSTRAINT "fkpoersınlno" FOREIGN KEY ( "personel_no" )
	REFERENCES "public"."personel" ( "personel_no" ) MATCH FULL
	ON DELETE Cascade
	ON UPDATE Cascade;

INSERT INTO cocuk(ad,soyad,cinsiyet,dogum_tarihi,dogum_yeri,personel_no) VALUES
('Emin','ESMER','E','2016.05.21',5,6),
('Selen','BUZDAG','K','2015.09.11',1,17),
('Akif','CAKIR','E','2018.01.05',1,19),
('Halide','ESMER','K','2017.12.10',8,6),
('Juide','BUZDAG','K','2016.03.03',6,17),
('Elif','BUZDAG','K','2013.11.11',2,17);

CREATE TABLE gorevlendirme (
gorevlendirme_no SERIAL PRIMARY KEY,
proje_no INT NOT NULL,
personel_no INT NOT NULL,
CONSTRAINT projePersonelTekil UNIQUE (proje_no,personel_no)
);

ALTER TABLE gorevlendirme 
ADD CONSTRAINT Fk_personelno FOREIGN KEY (personel_no) REFERENCES personel(personel_no),
ADD CONSTRAINT Fk_projeno FOREIGN KEY (proje_no) REFERENCES proje(proje_no)

INSERT INTO gorevlendirme(proje_no,personel_no) VALUES 
(1,3),(1,5),(1,7),(1,8),(1,11),(2,1),
(2,3),(2,5),(2,10),(2,12),(2,13),(3,3)
Saklı yordam ve Tetikleyiciler:
CREATE OR REPLACE FUNCTION personelAra(personelNo INT)
RETURNS TABLE(numara INT, adi VARCHAR(40), soyadi VARCHAR(40)) 
AS 
$$
BEGIN
    RETURN QUERY SELECT "personel_no", "ad", "soyad" FROM personel
                 WHERE "personel_no" = personelNo;
END;
$$
LANGUAGE "plpgsql";

CREATE OR REPLACE FUNCTION tarih_getir()
RETURNS table("Bugun_Tarih" DATE)
AS 
$$
BEGIN
    RETURN QUERY SELECT CURRENT_DATE;
END;
$$
LANGUAGE "plpgsql"

CREATE OR REPLACE FUNCTION toplam_maas(personelNo INT)
RETURNS TABLE("No" INT,toplam_maas int) 
AS 
$$
BEGIN
    RETURN QUERY SELECT "personel_no", maas + prim FROM personel
                 WHERE  "personel_no" = personelNo;
END;
$$
LANGUAGE "plpgsql";

CREATE TABLE "public"."personelmaasdegisiklikleriizle" (
	"kayitNo" serial,
	"personel_no" SmallInt NOT NULL,
	"eskimaas" Real NOT NULL,
	"yenimaas" Real NOT NULL,
	"degisiklikTarihi" TIMESTAMP NOT NULL,
	CONSTRAINT "PK" PRIMARY KEY ("kayitNo")
);


CREATE OR REPLACE FUNCTION "personelmaasdegisikligi"()
RETURNS TRIGGER 
AS
$$
BEGIN
    IF NEW."maas" <> OLD."maas" THEN
        INSERT INTO "personelmaasdegisiklikleriizle"("personel_no", "eskimaas", "yenimaas", "degisiklikTarihi")
        VALUES(OLD."personel_no", OLD."maas", NEW."maas", CURRENT_TIMESTAMP::TIMESTAMP);
    END IF;

    RETURN NEW;
END;
$$
LANGUAGE "plpgsql";


CREATE TRIGGER "personelmaasdegistiginde"
BEFORE UPDATE ON "personel"
FOR EACH ROW
EXECUTE PROCEDURE "personelmaasdegisikligi"();

CREATE OR REPLACE FUNCTION "personelekle"()
RETURNS TRIGGER 
AS
$$
BEGIN 
    NEW."soyad" = UPPER(NEW."soyad");
   
    RETURN NEW;
END;
$$
LANGUAGE "plpgsql";


CREATE TRIGGER "kayitKontrol"
BEFORE INSERT OR UPDATE ON "personel"  
FOR EACH ROW
EXECUTE PROCEDURE "personelekle"();

CREATE OR REPLACE FUNCTION "personel_cinsiyet_guncelleme"()
RETURNS TRIGGER 
AS
$$
BEGIN
    IF NEW."cinsiyet" <> OLD."cinsiyet" THEN
      RAISE EXCEPTION 'Cinsiyet Degistirilemez';
    END IF;

    RETURN NEW;
END;
$$
LANGUAGE "plpgsql";


CREATE TRIGGER "personelcinsiyetdegistiginde"
after UPDATE ON "personel"
FOR EACH ROW
EXECUTE PROCEDURE "personel_cinsiyet_guncelleme"();

CREATE OR REPLACE FUNCTION "birim_sil"()
RETURNS TRIGGER 
AS
$$
BEGIN

RAISE EXCEPTION 'Birim Silinemez';
END;
$$
LANGUAGE "plpgsql";

CREATE TRIGGER "birimsilindiginde"
BEFORE DELETE ON "birim"
FOR EACH ROW
EXECUTE PROCEDURE "birim_sil"();
 

 

 




C# Uygulama Kodları:
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

