using FirmaSiparisYonetimEntity;
using FirmaSiparisYonetimi.Business.Abstract;
using FirmaSiparisYonetimi.Business.Concrete;
using FirmaSiparisYonetimi.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaSiparisYonetimi.WebFormsUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            _firmaService = new FirmaManager(new FirmaDal());
            _urunService = new UrunManager(new UrunDal());
            _siparisService = new SiparisManager(new SiparisDal());
        }
        private IFirmaService _firmaService;
        private IUrunService _urunService;
        private ISiparisService _siparisService;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_firmaekle_Click(object sender, EventArgs e)
        {
            try
            {
                _firmaService.Add(new Firma
                {

                    firma_adi = txtfirmaadi.Text,
                    onay_durumu = txtonaydurumu.Text,
                    siparis_izin_baslangic_saati = dateTimePicker1.Value,
                    siparis_izin_bitis_saati = dateTimePicker2.Value
                } );
                MessageBox.Show("Firma eklendi...");
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_firmaguncelle_Click(object sender, EventArgs e)
        {
            _firmaService.Update(new Firma
            {
                firma_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                onay_durumu = txtonaydurumuguncelleme.SelectedText,
                siparis_izin_baslangic_saati = baslangicguncelle.Value,
                siparis_izin_bitis_saati = bitisguncelle.Value
                
            });

            MessageBox.Show("Firma Güncellendi...");
        }

        private void btnurunekleme_Click(object sender, EventArgs e)
        {
            try
            {
                _urunService.Add(new Urun
                {

                    firma_id = Convert.ToInt16(txturunadi.Text),
                    urun_adi = txtonaydurumu.Text,
                    urun_stok = Convert.ToInt32(txturunstok.Text),
                    urun_fiyati = Convert.ToInt32(txturunfiyati.Text)
                });
                MessageBox.Show("Ürün eklendi...");


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btn_firmalistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _firmaService.GetAll();
        }

        private void btn_siparisolusturma_Click(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToLongDateString();
            label17.Text = DateTime.Now.ToLongTimeString(); 
            try
            {
                _siparisService.Add(new Siparis
                {

                    firma_id = Convert.ToInt16(txturunadi.Text),
                    urun_id = Convert.ToInt16(txtsiparisurunid.Text),
                    siparis_kisi_adi = txtsiparisverenkisininadi.Text,
                    siparis_tarih = siparistarih.Value
                });
                MessageBox.Show("Sipariş eklendi...");


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
