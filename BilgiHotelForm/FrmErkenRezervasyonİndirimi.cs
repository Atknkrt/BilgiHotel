using BilgiHotelDAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiHotelForm
{
    public partial class FrmErkenRezervasyonİndirimi : Form
    {
        ErkenRezervasyonIndirimDAL erkenRezervasyonIndirimDAL = new ErkenRezervasyonIndirimDAL();
        ErkenRezervasyonIndirimEntity erkenRezervasyonIndirimEntity = new ErkenRezervasyonIndirimEntity();
        RezervasyonTipEntity rezervasyonTipEntity = new RezervasyonTipEntity();
        Tools tool = new Tools();
        public FrmErkenRezervasyonİndirimi()
        {
            InitializeComponent();
        }
        void formdaikileriEntityIleYazdır()
        {
            erkenRezervasyonIndirimEntity.ErkenRezervasyonGünSayisi = Convert.ToInt32(erkrezGünSayisi.Text);
            erkenRezervasyonIndirimEntity.ErkenRezervasyonIndirimOrani = Convert.ToInt32(erkrezIndirimOrani.Text);
            erkenRezervasyonIndirimEntity.ErkenRezervasyon = erkrezTanim.Text;
            erkenRezervasyonIndirimEntity.ErkenRezervasyonAktifMi = Convert.ToBoolean(cberkenrezaktifmi.Checked);
        }
        void MylistviewDoldurma()
        { tool.ListViewDoldur(lverkenrez, "sp_erkenrezhepsinigetir", false, null); }
        private void FrmErkenRezervasyonİndirimi_Load(object sender, EventArgs e)
        {
            MylistviewDoldurma();
        }

        private void btnerkrezekle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikileriEntityIleYazdır();

                erkenRezervasyonIndirimEntity.ErkenRezervasyonId = (int)erkenRezervasyonIndirimDAL.getInsertErkenRezervasyon(erkenRezervasyonIndirimEntity, rezervasyonTipEntity);

                if (erkrezGünSayisi.Text == "" || erkrezIndirimOrani.Text=="" || erkrezTanim.Text=="")
                {
                    MessageBox.Show("Boş Bilgileri GİRİNİZ");
                }
                else if (erkenRezervasyonIndirimEntity.ErkenRezervasyonId == 0)
                {
                    MessageBox.Show("Girilen Tanımda erken rezervasyon var. Tekrar Deneyiniz");
                }
                else
                {
                    MessageBox.Show("ERKEN REZERVASYON İNDİRİMİ BAŞARIYLA EKLENDİ");
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Erken Rezervasyon İndirimi Ekleme Basarisiz" + HATA.Message);
            }
            MylistviewDoldurma();
        }

        private void btnerkrezgüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikileriEntityIleYazdır();

                int a = erkenRezervasyonIndirimDAL.getUpdateErkenRezervasyon(erkenRezervasyonIndirimEntity);

                if (erkrezGünSayisi.Text == "" || erkrezIndirimOrani.Text == "" || erkrezTanim.Text == "")
                {
                    MessageBox.Show("Boş Bilgileri GİRİNİZ");
                }
                else
                {
                    MessageBox.Show("ERKEN REZERVASYON İNDİRİMİ BAŞARIYLA GÜNCELLENDİ" + a.ToString());
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Erken Rezervasyon İndirimi Güncelleme Basarisiz" + HATA.Message);
            }
            MylistviewDoldurma();
        }

        private void btnerkreztemizle_Click(object sender, EventArgs e)
        {
            tool.FormTemizle(this);
        }

        private void lverkenrez_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tool.FormDoldur("select * from tbl_ErkenRezervasyon where ErkenRezervasyonId=" + lverkenrez.SelectedItems[0].SubItems[0].Text, null, this);
            erkenRezervasyonIndirimEntity.ErkenRezervasyonId = Convert.ToInt32(lverkenrez.SelectedItems[0].SubItems[0].Text);
        }

        private void btnerkrezhepsinigetir_Click(object sender, EventArgs e)
        {
            MylistviewDoldurma();
        }
    }
}
