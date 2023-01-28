namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_listele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.text_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.text_soyad = new System.Windows.Forms.TextBox();
            this.text_prim = new System.Windows.Forms.TextBox();
            this.text_maas = new System.Windows.Forms.TextBox();
            this.text_calisma = new System.Windows.Forms.TextBox();
            this.text_unvan = new System.Windows.Forms.TextBox();
            this.text_birim = new System.Windows.Forms.TextBox();
            this.text_basla = new System.Windows.Forms.TextBox();
            this.text_ilce = new System.Windows.Forms.TextBox();
            this.text_dogum = new System.Windows.Forms.TextBox();
            this.text_cins = new System.Windows.Forms.TextBox();
            this.text_no = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(363, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(661, 81);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(117, 42);
            this.btn_listele.TabIndex = 1;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(225, 284);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(117, 42);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(661, 23);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(117, 42);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(225, 231);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(117, 42);
            this.btn_ara.TabIndex = 5;
            this.btn_ara.Text = "Arama";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(661, 144);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(117, 42);
            this.btn_guncelle.TabIndex = 6;
            this.btn_guncelle.Text = "Güncelleme";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // text_ad
            // 
            this.text_ad.Location = new System.Drawing.Point(477, 14);
            this.text_ad.Name = "text_ad";
            this.text_ad.Size = new System.Drawing.Size(100, 22);
            this.text_ad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Maaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dogum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "İlce No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unvan No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Başlama Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Çalışma Saati";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Birim No";
            // 
            // text_soyad
            // 
            this.text_soyad.Location = new System.Drawing.Point(477, 46);
            this.text_soyad.Name = "text_soyad";
            this.text_soyad.Size = new System.Drawing.Size(100, 22);
            this.text_soyad.TabIndex = 18;
            // 
            // text_prim
            // 
            this.text_prim.Location = new System.Drawing.Point(477, 373);
            this.text_prim.Name = "text_prim";
            this.text_prim.Size = new System.Drawing.Size(100, 22);
            this.text_prim.TabIndex = 19;
            // 
            // text_maas
            // 
            this.text_maas.Location = new System.Drawing.Point(477, 330);
            this.text_maas.Name = "text_maas";
            this.text_maas.Size = new System.Drawing.Size(100, 22);
            this.text_maas.TabIndex = 20;
            // 
            // text_calisma
            // 
            this.text_calisma.Location = new System.Drawing.Point(477, 294);
            this.text_calisma.Name = "text_calisma";
            this.text_calisma.Size = new System.Drawing.Size(100, 22);
            this.text_calisma.TabIndex = 21;
            // 
            // text_unvan
            // 
            this.text_unvan.Location = new System.Drawing.Point(477, 256);
            this.text_unvan.Name = "text_unvan";
            this.text_unvan.Size = new System.Drawing.Size(100, 22);
            this.text_unvan.TabIndex = 22;
            // 
            // text_birim
            // 
            this.text_birim.Location = new System.Drawing.Point(477, 218);
            this.text_birim.Name = "text_birim";
            this.text_birim.Size = new System.Drawing.Size(100, 22);
            this.text_birim.TabIndex = 23;
            // 
            // text_basla
            // 
            this.text_basla.Location = new System.Drawing.Point(477, 176);
            this.text_basla.Name = "text_basla";
            this.text_basla.Size = new System.Drawing.Size(100, 22);
            this.text_basla.TabIndex = 24;
            // 
            // text_ilce
            // 
            this.text_ilce.Location = new System.Drawing.Point(477, 144);
            this.text_ilce.Name = "text_ilce";
            this.text_ilce.Size = new System.Drawing.Size(100, 22);
            this.text_ilce.TabIndex = 25;
            // 
            // text_dogum
            // 
            this.text_dogum.Location = new System.Drawing.Point(477, 108);
            this.text_dogum.Name = "text_dogum";
            this.text_dogum.Size = new System.Drawing.Size(100, 22);
            this.text_dogum.TabIndex = 26;
            // 
            // text_cins
            // 
            this.text_cins.Location = new System.Drawing.Point(477, 75);
            this.text_cins.Name = "text_cins";
            this.text_cins.Size = new System.Drawing.Size(100, 22);
            this.text_cins.TabIndex = 27;
            // 
            // text_no
            // 
            this.text_no.Location = new System.Drawing.Point(103, 228);
            this.text_no.Name = "text_no";
            this.text_no.Size = new System.Drawing.Size(100, 22);
            this.text_no.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Personel No";
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(661, 208);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(117, 42);
            this.btn_cikis.TabIndex = 30;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.text_no);
            this.Controls.Add(this.text_cins);
            this.Controls.Add(this.text_dogum);
            this.Controls.Add(this.text_ilce);
            this.Controls.Add(this.text_basla);
            this.Controls.Add(this.text_birim);
            this.Controls.Add(this.text_unvan);
            this.Controls.Add(this.text_calisma);
            this.Controls.Add(this.text_maas);
            this.Controls.Add(this.text_prim);
            this.Controls.Add(this.text_soyad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_ad);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TextBox text_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_soyad;
        private System.Windows.Forms.TextBox text_prim;
        private System.Windows.Forms.TextBox text_maas;
        private System.Windows.Forms.TextBox text_calisma;
        private System.Windows.Forms.TextBox text_unvan;
        private System.Windows.Forms.TextBox text_birim;
        private System.Windows.Forms.TextBox text_basla;
        private System.Windows.Forms.TextBox text_ilce;
        private System.Windows.Forms.TextBox text_dogum;
        private System.Windows.Forms.TextBox text_cins;
        private System.Windows.Forms.TextBox text_no;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_cikis;
    }
}

