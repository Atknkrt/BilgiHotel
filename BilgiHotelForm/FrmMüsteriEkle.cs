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
    public partial class FrmMüsteriEkle : Form
    {
        MüsterilerDAL müsteri = new MüsterilerDAL();
        MüsterilerEntity mymüsteri = new MüsterilerEntity();
        PersonellerEntity personel = new PersonellerEntity();
        Tools tool=new Tools();
        
        public FrmMüsteriEkle()
        {
            InitializeComponent();
        }

        private void FrmMüsteriEkle_Load(object sender, EventArgs e)
        {
            tool.ComboBoxDoldur(cmbMüsUlke, "sp_UlkelerinHepsinigetir",true);
            tool.ComboBoxDoldur(cmbMüsDil, "sp_DilerinHepsiniGetir", true);
            tool.ComboBoxDoldur(cmbMüsIl, "sp_IllerinHepsiniGetir", true);
            tool.ComboBoxDoldur(cmbMüsIlce, "sp_IlcelerinHepsiniGetir", true);
            MylistviewDoldurma();
        }

        private void cmbMüsUlke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tool.ComboBoxDoldur(cmbMüsIl, "select*from tbl_Il where UlkeId="+ (int)cmbMüsUlke.SelectedValue, false);
        }

        private void cmbMüsIl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tool.ComboBoxDoldur(cmbMüsIlce, "select*from tbl_Ilce where IlId=" + (int)cmbMüsIl.SelectedValue, false);
        }
        void formdaikileriEntityIleYazdır()
        {
            
            mymüsteri.MusteriAd = txtMüsAd.Text;
            mymüsteri.MusteriSoyad = txtMüsSoyad.Text;
            mymüsteri.MusteriTCKimlik = txtMüsTcNo.Text;
            mymüsteri.MusteriPasaportNo = txtMüsPasaport.Text;
            mymüsteri.MusteriUnvan = txtMüsUnvan.Text;
            mymüsteri.MusteriYetkiliAdSoyad = txtMüsYetkili.Text;
            mymüsteri.MusteriVergiNo = txtMüsVergiNo.Text;
            mymüsteri.MusteriVergiDairesi = txtMüsVergiDairesi.Text;
            mymüsteri.MusteriTelefon = txtMüsTelefon.Text;
            mymüsteri.MusteriPosta = txtMüsEposta.Text;
            mymüsteri.MusteriAdres = txtMüsAdres.Text;
            mymüsteri.IlID = Convert.ToInt32(cmbMüsIl.SelectedValue);
            mymüsteri.IlceID = Convert.ToInt32(cmbMüsIlce.SelectedValue);
            mymüsteri.UlkeID = Convert.ToInt32(cmbMüsUlke.SelectedValue);
            mymüsteri.MusteriAciklama = txtMüsAciklama.Text;
            mymüsteri.MusteriKurumsalOK = cbMüsKurumsal.Checked;
            mymüsteri.DilID = Convert.ToInt32(cmbMüsDil.SelectedValue);
            personel.PersonelId=Login.personelId;

        }
        private void btnMüsEkle_Click(object sender, EventArgs e)
        { 
            try
            {
                formdaikileriEntityIleYazdır();

                mymüsteri.MusteriID = (int)müsteri.getInsertMüsteri(mymüsteri, personel);

                if (txtMüsTcNo.Text == "")
                {
                    MessageBox.Show("TC KİMLİK NUMARASINI GİRİNİZ");
                }
                else if (mymüsteri.MusteriID == 0)
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
            MylistviewDoldurma();
        }
        void MylistviewDoldurma()
        { tool.ListViewDoldur(listViewMüsBilgileri, "sp_müsterilerigetir",false,null);}

        private void btnMüsGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikileriEntityIleYazdır();

                int a=müsteri.getUpdateMüsteri(mymüsteri);

                if (txtMüsTcNo.Text == "")
                {
                    MessageBox.Show("TC KİMLİK NUMARASINI GİRİNİZ");
                }
                else
                {
                    MessageBox.Show("KULLANICI BAŞARIYLA GÜNCELLENDİ"+a.ToString());
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Kisi Güncelleme Basarisiz" + HATA.Message);
            }
            MylistviewDoldurma();
        }

        private void btnMüsGetir_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp =
            {new SqlParameter
                {
                    ParameterName="MusteriTCKimlik",
                    Value=txtGetirTC.Text
                }
            };
            
            tool.ListViewDoldur(listViewMüsBilgileri, "sp_tcyegöremüsterigetir",true, sp);

        }

        private void listViewMüsBilgileri_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tool.FormTemizle(this);
            
        }

        private void listViewMüsBilgileri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tool.FormDoldur("select*from tbl_Musteriler where MusteriID=" + listViewMüsBilgileri.SelectedItems[0].SubItems[0].Text, null,this);
            txtGetirTC.Text = "";
            mymüsteri.MusteriID = Convert.ToInt32(listViewMüsBilgileri.SelectedItems[0].SubItems[0].Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MylistviewDoldurma();
        }
    }
}
