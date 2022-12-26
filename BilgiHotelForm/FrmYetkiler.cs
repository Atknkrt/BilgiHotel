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
    public partial class FrmYetkiler : Form
    {
        YetkilerDAL yetkilerDAL = new YetkilerDAL();
        YetkilerEntity yetkilerEntity = new YetkilerEntity();
        Tools tool = new Tools();
        public FrmYetkiler()
        {
            InitializeComponent();
        }
        void formdaikileriEntityIleYazdır()
        {
            yetkilerEntity.YetkiAd = txtYetkiAd.Text;
            yetkilerEntity.YetkiAciklama = txtYetkiAciklama.Text;
            yetkilerEntity.YetkiGuvenlikKod = txtYetkiGüvenlikKod.Text;
            yetkilerEntity.YetkiAccessKod = txtYetkiAccesKod.Text;
        }
        void MylistviewDoldurma()
        { tool.ListViewDoldur(lvyetki, "sp_bütünYetkileriGetir", false, null); }

        private void FrmYetkiler_Load(object sender, EventArgs e)
        {
            MylistviewDoldurma();
        }

        private void btnyetkiekle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikileriEntityIleYazdır();

                yetkilerEntity.YetkiId = (int)yetkilerDAL.getInsertYetkiler(yetkilerEntity);

                if (txtYetkiAd.Text == " " || txtYetkiAciklama.Text == " " || txtYetkiGüvenlikKod.Text == " " || txtYetkiAccesKod.Text == " ")
                {
                    MessageBox.Show("Yetki Tanimi GİRİNİZ");
                }
                else if (yetkilerEntity.YetkiId == 0)
                {
                    MessageBox.Show("Girilen Tanımda Yetki var. Tekrar Deneyiniz");
                }
                else
                {
                    MessageBox.Show("YETKİ BAŞARIYLA EKLENDİ");
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Yetki Ekleme Basarisiz" + HATA.Message);
            }
            MylistviewDoldurma();
        }

        private void btnyetkigüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikileriEntityIleYazdır();

                int a = yetkilerDAL.getUpdateYetkiler(yetkilerEntity);

                if (txtYetkiAd.Text == "" || txtYetkiAciklama.Text == "" || txtYetkiGüvenlikKod.Text == "" || txtYetkiAccesKod.Text == "")
                {
                    MessageBox.Show("Boş Bilgileri GİRİNİZ");
                }
                else
                {
                    MessageBox.Show("YETKİ BAŞARIYLA GÜNCELLENDİ" + a.ToString());
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Yetki Güncelleme Basarisiz" + HATA.Message);
            }
            MylistviewDoldurma();
        }

        private void btnyetkitemizle_Click(object sender, EventArgs e)
        {
            tool.FormTemizle(this);
        }

        private void lvyetki_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tool.FormDoldur("SELECT*FROM tbl_Yetkiler where YetkiId=" + lvyetki.SelectedItems[0].SubItems[0].Text, null, this);
            yetkilerEntity.YetkiId = Convert.ToInt32(lvyetki.SelectedItems[0].SubItems[0].Text);
        }

        private void btnyetkihepsinigetir_Click(object sender, EventArgs e)
        {
            MylistviewDoldurma();
        }
    }
}
