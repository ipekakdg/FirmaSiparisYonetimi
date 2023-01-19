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
    }
}
