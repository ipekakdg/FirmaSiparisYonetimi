namespace FirmaSiparisYonetimi.WebFormsUI
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
            this.btn_firmaekle = new System.Windows.Forms.Button();
            this.btn_firmaguncelle = new System.Windows.Forms.Button();
            this.btn_firmalistele = new System.Windows.Forms.Button();
            this.btnurunekleme = new System.Windows.Forms.Button();
            this.btn_siparisolusturma = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtfirmaadi = new System.Windows.Forms.TextBox();
            this.txtonaydurumu = new System.Windows.Forms.TextBox();
            this.txtsiparisizinbaslangicsaati = new System.Windows.Forms.TextBox();
            this.tctsiparisizinbitissaati = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtonaydurumuguncelleme = new System.Windows.Forms.TextBox();
            this.txtsiparisizinsaatiguncelleme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txturunfiyati = new System.Windows.Forms.TextBox();
            this.txturunstok = new System.Windows.Forms.TextBox();
            this.txtfirmaid = new System.Windows.Forms.TextBox();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtsiparistarihi = new System.Windows.Forms.TextBox();
            this.txtsiparisverenkisininadi = new System.Windows.Forms.TextBox();
            this.txtsiparisurunid = new System.Windows.Forms.TextBox();
            this.txtsiparisfirmaid = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_firmaekle
            // 
            this.btn_firmaekle.Location = new System.Drawing.Point(127, 146);
            this.btn_firmaekle.Name = "btn_firmaekle";
            this.btn_firmaekle.Size = new System.Drawing.Size(106, 54);
            this.btn_firmaekle.TabIndex = 0;
            this.btn_firmaekle.Text = "Firma Ekle ";
            this.btn_firmaekle.UseVisualStyleBackColor = true;
            this.btn_firmaekle.Click += new System.EventHandler(this.btn_firmaekle_Click);
            // 
            // btn_firmaguncelle
            // 
            this.btn_firmaguncelle.Location = new System.Drawing.Point(127, 146);
            this.btn_firmaguncelle.Name = "btn_firmaguncelle";
            this.btn_firmaguncelle.Size = new System.Drawing.Size(106, 54);
            this.btn_firmaguncelle.TabIndex = 1;
            this.btn_firmaguncelle.Text = "Firma Güncelleme";
            this.btn_firmaguncelle.UseVisualStyleBackColor = true;
            // 
            // btn_firmalistele
            // 
            this.btn_firmalistele.Location = new System.Drawing.Point(127, 146);
            this.btn_firmalistele.Name = "btn_firmalistele";
            this.btn_firmalistele.Size = new System.Drawing.Size(106, 54);
            this.btn_firmalistele.TabIndex = 2;
            this.btn_firmalistele.Text = "Firma Listeleme";
            this.btn_firmalistele.UseVisualStyleBackColor = true;
            // 
            // btnurunekleme
            // 
            this.btnurunekleme.Location = new System.Drawing.Point(127, 146);
            this.btnurunekleme.Name = "btnurunekleme";
            this.btnurunekleme.Size = new System.Drawing.Size(106, 54);
            this.btnurunekleme.TabIndex = 3;
            this.btnurunekleme.Text = "Ürün Ekleme";
            this.btnurunekleme.UseVisualStyleBackColor = true;
            // 
            // btn_siparisolusturma
            // 
            this.btn_siparisolusturma.Location = new System.Drawing.Point(127, 146);
            this.btn_siparisolusturma.Name = "btn_siparisolusturma";
            this.btn_siparisolusturma.Size = new System.Drawing.Size(106, 54);
            this.btn_siparisolusturma.TabIndex = 4;
            this.btn_siparisolusturma.Text = "Sipariş Oluşturma";
            this.btn_siparisolusturma.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(521, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(239, 206);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtonaydurumu);
            this.groupBox1.Controls.Add(this.txtfirmaadi);
            this.groupBox1.Controls.Add(this.btn_firmaekle);
            this.groupBox1.Location = new System.Drawing.Point(30, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Ekleme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtonaydurumuguncelleme);
            this.groupBox2.Controls.Add(this.txtsiparisizinsaatiguncelleme);
            this.groupBox2.Controls.Add(this.tctsiparisizinbitissaati);
            this.groupBox2.Controls.Add(this.btn_firmaguncelle);
            this.groupBox2.Controls.Add(this.txtsiparisizinbaslangicsaati);
            this.groupBox2.Location = new System.Drawing.Point(275, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 206);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firma Güncelleme";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txturunfiyati);
            this.groupBox3.Controls.Add(this.txturunstok);
            this.groupBox3.Controls.Add(this.txtfirmaid);
            this.groupBox3.Controls.Add(this.txturunadi);
            this.groupBox3.Controls.Add(this.btnurunekleme);
            this.groupBox3.Location = new System.Drawing.Point(521, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 206);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Ekleme";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btn_firmalistele);
            this.groupBox4.Location = new System.Drawing.Point(30, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 206);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Firma Listeleme";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtsiparistarihi);
            this.groupBox5.Controls.Add(this.txtsiparisverenkisininadi);
            this.groupBox5.Controls.Add(this.txtsiparisurunid);
            this.groupBox5.Controls.Add(this.txtsiparisfirmaid);
            this.groupBox5.Controls.Add(this.btn_siparisolusturma);
            this.groupBox5.Location = new System.Drawing.Point(276, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 211);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sipariş Oluşturma";
            // 
            // txtfirmaadi
            // 
            this.txtfirmaadi.Location = new System.Drawing.Point(127, 20);
            this.txtfirmaadi.Name = "txtfirmaadi";
            this.txtfirmaadi.Size = new System.Drawing.Size(100, 20);
            this.txtfirmaadi.TabIndex = 1;
            // 
            // txtonaydurumu
            // 
            this.txtonaydurumu.Location = new System.Drawing.Point(127, 50);
            this.txtonaydurumu.Name = "txtonaydurumu";
            this.txtonaydurumu.Size = new System.Drawing.Size(100, 20);
            this.txtonaydurumu.TabIndex = 2;
            // 
            // txtsiparisizinbaslangicsaati
            // 
            this.txtsiparisizinbaslangicsaati.Location = new System.Drawing.Point(-19, 120);
            this.txtsiparisizinbaslangicsaati.Name = "txtsiparisizinbaslangicsaati";
            this.txtsiparisizinbaslangicsaati.Size = new System.Drawing.Size(83, 20);
            this.txtsiparisizinbaslangicsaati.TabIndex = 3;
            // 
            // tctsiparisizinbitissaati
            // 
            this.tctsiparisizinbitissaati.Location = new System.Drawing.Point(-3, 120);
            this.tctsiparisizinbitissaati.Name = "tctsiparisizinbitissaati";
            this.tctsiparisizinbitissaati.Size = new System.Drawing.Size(83, 20);
            this.tctsiparisizinbitissaati.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firma Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Onay Durumu :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sipariş İzin Başlangıç Saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sipariş İzin Bitiş Saati : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Onay Durumu Güncelleme :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sipariş İzin Saati Güncelleme :";
            // 
            // txtonaydurumuguncelleme
            // 
            this.txtonaydurumuguncelleme.Location = new System.Drawing.Point(127, 105);
            this.txtonaydurumuguncelleme.Name = "txtonaydurumuguncelleme";
            this.txtonaydurumuguncelleme.Size = new System.Drawing.Size(100, 20);
            this.txtonaydurumuguncelleme.TabIndex = 10;
            // 
            // txtsiparisizinsaatiguncelleme
            // 
            this.txtsiparisizinsaatiguncelleme.Location = new System.Drawing.Point(127, 46);
            this.txtsiparisizinsaatiguncelleme.Name = "txtsiparisizinsaatiguncelleme";
            this.txtsiparisizinsaatiguncelleme.Size = new System.Drawing.Size(100, 20);
            this.txtsiparisizinsaatiguncelleme.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ürün Fiyatı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ürün Stok :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Firma ID :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ürün Adı : ";
            // 
            // txturunfiyati
            // 
            this.txturunfiyati.Location = new System.Drawing.Point(126, 108);
            this.txturunfiyati.Name = "txturunfiyati";
            this.txturunfiyati.Size = new System.Drawing.Size(100, 20);
            this.txturunfiyati.TabIndex = 12;
            // 
            // txturunstok
            // 
            this.txturunstok.Location = new System.Drawing.Point(126, 78);
            this.txturunstok.Name = "txturunstok";
            this.txturunstok.Size = new System.Drawing.Size(100, 20);
            this.txturunstok.TabIndex = 11;
            // 
            // txtfirmaid
            // 
            this.txtfirmaid.Location = new System.Drawing.Point(126, 49);
            this.txtfirmaid.Name = "txtfirmaid";
            this.txtfirmaid.Size = new System.Drawing.Size(100, 20);
            this.txtfirmaid.TabIndex = 10;
            // 
            // txturunadi
            // 
            this.txturunadi.Location = new System.Drawing.Point(126, 19);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(100, 20);
            this.txturunadi.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Firmaları Listelemek İçin Lütfen Tıklayınız : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Sipariş Tarihi :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Sipariş Veren Kişi Adı : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Firma ID :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Ürün Adı : ";
            // 
            // txtsiparistarihi
            // 
            this.txtsiparistarihi.Location = new System.Drawing.Point(126, 115);
            this.txtsiparistarihi.Name = "txtsiparistarihi";
            this.txtsiparistarihi.Size = new System.Drawing.Size(100, 20);
            this.txtsiparistarihi.TabIndex = 20;
            // 
            // txtsiparisverenkisininadi
            // 
            this.txtsiparisverenkisininadi.Location = new System.Drawing.Point(126, 85);
            this.txtsiparisverenkisininadi.Name = "txtsiparisverenkisininadi";
            this.txtsiparisverenkisininadi.Size = new System.Drawing.Size(100, 20);
            this.txtsiparisverenkisininadi.TabIndex = 19;
            // 
            // txtsiparisurunid
            // 
            this.txtsiparisurunid.Location = new System.Drawing.Point(126, 56);
            this.txtsiparisurunid.Name = "txtsiparisurunid";
            this.txtsiparisurunid.Size = new System.Drawing.Size(100, 20);
            this.txtsiparisurunid.TabIndex = 18;
            // 
            // txtsiparisfirmaid
            // 
            this.txtsiparisfirmaid.Location = new System.Drawing.Point(126, 26);
            this.txtsiparisfirmaid.Name = "txtsiparisfirmaid";
            this.txtsiparisfirmaid.Size = new System.Drawing.Size(100, 20);
            this.txtsiparisfirmaid.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(27, 128);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_firmaekle;
        private System.Windows.Forms.Button btn_firmaguncelle;
        private System.Windows.Forms.Button btn_firmalistele;
        private System.Windows.Forms.Button btnurunekleme;
        private System.Windows.Forms.Button btn_siparisolusturma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tctsiparisizinbitissaati;
        private System.Windows.Forms.TextBox txtsiparisizinbaslangicsaati;
        private System.Windows.Forms.TextBox txtonaydurumu;
        private System.Windows.Forms.TextBox txtfirmaadi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtonaydurumuguncelleme;
        private System.Windows.Forms.TextBox txtsiparisizinsaatiguncelleme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txturunfiyati;
        private System.Windows.Forms.TextBox txturunstok;
        private System.Windows.Forms.TextBox txtfirmaid;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtsiparistarihi;
        private System.Windows.Forms.TextBox txtsiparisverenkisininadi;
        private System.Windows.Forms.TextBox txtsiparisurunid;
        private System.Windows.Forms.TextBox txtsiparisfirmaid;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

