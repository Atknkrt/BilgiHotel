using BilgiHotelDAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiHotelForm
{
    public partial class FrmMisafirEkle : Form
    {
        MisafirlerDAL misafir = new MisafirlerDAL();
        MisafirlerEntity mymisafir = new MisafirlerEntity();
        PersonellerEntity personel = new PersonellerEntity();
        Tools tool = new Tools();
        public FrmMisafirEkle()
        {
            InitializeComponent();
        }

        private void FrmMisafirEkle_Load(object sender, EventArgs e)
        {
            tool.ComboBoxDoldur(cmbMisUlke, "sp_UlkelerinHepsinigetir", true);
            tool.ComboBoxDoldur(cmbMisDil, "sp_DilerinHepsiniGetir", true);
            tool.ComboBoxDoldur(cmbMisIl, "sp_IllerinHepsiniGetir", true);
            tool.ComboBoxDoldur(cmbMisIlce, "sp_IlcelerinHepsiniGetir", true);
            tool.ComboBoxDoldur(cmbMisCinsiyet, "sp_cinsiyetlerinhepsinigetir", true);
            tool.ComboBoxDoldur(cmbMisUyruk, "sp_UlkelerinHepsinigetir", true);
            MylistviewMisafirDoldurma();
        }

        private void cmbMisUlke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tool.ComboBoxDoldur(cmbMisIl, "select*from tbl_Il where UlkeId=" + (int)cmbMisUlke.SelectedValue, false);
        }

        private void cmbMisIl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tool.ComboBoxDoldur(cmbMisIlce, "select*from tbl_Ilce where IlId=" + (int)cmbMisIl.SelectedValue, false);
        }
        void formdaikiMisafirleriEntityIleYazdır()
        {
            mymisafir.MisafirAd = txtMisAd.Text;
            mymisafir.MisafirSoyad = txtMisSoyad.Text;
            mymisafir.MisafirTcKimlik = txtMisTcNo.Text;
            mymisafir.MisafirDogumTarihi = Convert.ToDateTime(dtpMisDTarihi.Value);
            mymisafir.MisafirUyrukId = Convert.ToInt32(cmbMisUyruk.SelectedValue);
            mymisafir.MisafirEposta = txtMisEposta.Text;
            mymisafir.MisafirTelefon = txtMisTel.Text;
            mymisafir.MisafirPasaportNo = txtMisPasaport.Text;
            mymisafir.CinsiyetId = Convert.ToInt32(cmbMisCinsiyet.SelectedValue);
            mymisafir.MisafirAdres = txtMisAdres.Text;
            mymisafir.IlID = Convert.ToInt32(cmbMisIl.SelectedValue);
            mymisafir.IlceID = Convert.ToInt32(cmbMisIlce.SelectedValue);
            mymisafir.UlkeID = Convert.ToInt32(cmbMisUlke.SelectedValue);
            mymisafir.MisafirAciklama = txtMisAciklama.Text;
            mymisafir.DilID = Convert.ToInt32(cmbMisDil.SelectedValue);
            personel.PersonelId = Login.personelId;

        }

        private void btnMisEkle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikiMisafirleriEntityIleYazdır();

                mymisafir.MisafirId = (int)misafir.getInsertMisafir(mymisafir, personel);

                if (txtMisTcNo.Text == "")
                {
                    MessageBox.Show("TC KİMLİK NUMARASINI GİRİNİZ");
                }
                else if (mymisafir.MisafirId == 0)
                {
                    MessageBox.Show("Girilen TC Kimlik Numarasında zaten Kullanici var. Tekrar Deneyiniz");
                }
                else
                {
                    MessageBox.Show("KULLANICI BAŞARIYLA EKLENDİ");
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Kisi Ekleme Basarisiz" + HATA.Message);
            }
            MylistviewMisafirDoldurma();
        }
        void MylistviewMisafirDoldurma()
        { tool.ListViewDoldur(listViewMisBilgileri, "sp_misafirlerigetir", false, null); }

        private void btnMisGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikiMisafirleriEntityIleYazdır();

                mymisafir.MisafirId = (int)misafir.getUpdateMisafir(mymisafir);

                if (txtMisTcNo.Text == "")
                {
                    MessageBox.Show("TC KİMLİK NUMARASINI GİRİNİZ");
                }
                else
                {
                    MessageBox.Show("KULLANICI BAŞARIYLA GÜNCELLENDİ");
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Kisi Güncelleme Basarisiz" + HATA.Message);
            }
            MylistviewMisafirDoldurma();
        }

        private void btnMisGetir_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp =
            {new SqlParameter
                {
                    ParameterName="MisafirTcKimlik",
                    Value=txtMisGetirTC.Text
                }
            };

            tool.ListViewDoldur(listViewMisBilgileri, "sp_tcyegöremisafirgetir", true, sp);
        }

        private void btnMisTemizle_Click(object sender, EventArgs e)
        {
            tool.FormTemizle(this);
        }

        private void listViewMisBilgileri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tool.FormDoldur("select*from tbl_Misafir where MisafirId=" + listViewMisBilgileri.SelectedItems[0].SubItems[0].Text, null, this);
            txtMisGetirTC.Text = "";
        }

        private void btnMisHepsiniGetir_Click(object sender, EventArgs e)
        {
            MylistviewMisafirDoldurma();
        }
    }
}
