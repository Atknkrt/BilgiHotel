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
    

    public partial class FrmPersonelBilgileri : Form
    {
        PersonellerDAL personellerDAL = new PersonellerDAL();
        PersonellerEntity personellerEntity= new PersonellerEntity();
        VardiyaEntity vardiyaEntity= new VardiyaEntity();
        Tools tool = new Tools();
        public FrmPersonelBilgileri()
        {
            InitializeComponent();
        }

        private void FrmPersonelBilgileri_Load(object sender, EventArgs e)
        {
            tool.ComboBoxDoldur(cmbperulke, "sp_UlkelerinHepsinigetir", true);
            tool.ComboBoxDoldur(cmbcinsiyet, "sp_cinsiyetlerinHepsiniGetir", true);
            tool.ComboBoxDoldur(cmbperil, "sp_IllerinHepsiniGetir", true);
            tool.ComboBoxDoldur(cmbperilce, "sp_IlcelerinHepsiniGetir", true);
            tool.ComboBoxDoldur(cmbpergörev, "sp_görevlerinhepsinigetir", true);
            tool.ComboBoxDoldur(cmbperkategori, "sp_kategorilerinhepsinigetir", true);
            tool.ComboBoxDoldur(cmbpervardiya, "sp_vardiyalarigetir", true);
            tool.ComboBoxDoldur(cmbuyruk, "sp_UlkelerinHepsinigetir", true);
            MylistviewDoldurma();
        }

        private void cmbperulke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tool.ComboBoxDoldur(cmbperil, "select*from tbl_Il where UlkeId=" + (int)cmbperulke.SelectedValue, false);
        }

        private void cmbperil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tool.ComboBoxDoldur(cmbperilce, "select*from tbl_Ilce where IlId=" + (int)cmbperil.SelectedValue, false);
        }
        void formdaikileriEntityIleYazdır()
        {

            personellerEntity.PersonelAd = perad.Text;
            personellerEntity.PersonelSoyad = persoyad.Text;
            personellerEntity.PersonelTcKimlik = pertckimlik.Text;
            personellerEntity.PersonelDogumTarihi = Convert.ToDateTime(dtpperdogtar.Value);
            personellerEntity.PersonelUyrukId = Convert.ToInt32(cmbuyruk.SelectedValue);
            personellerEntity.PersonelEposta = pereposta.Text;
            personellerEntity.PersonelTelefon = pertel.Text;
            personellerEntity.PersonelPasaportNo = perpasaport.Text;
            personellerEntity.CinsiyetId = Convert.ToInt32(cmbcinsiyet.SelectedValue);
            personellerEntity.PersonelIseGirisTarihi = Convert.ToDateTime(dtpisegiris.Value);
            personellerEntity.PersonelIstenCikisTarihi = Convert.ToDateTime(dtpistencikis.Value);
            personellerEntity.PersonelSaatlikUcret = Convert.ToDecimal(persaatlikucret.Text);
            personellerEntity.PersonelMaas = Convert.ToDecimal(permaas.Text);
            personellerEntity.PersonelSicilNo=persicilno.Text;
            personellerEntity.GorevId=Convert.ToInt32(cmbpergörev.SelectedValue);
            personellerEntity.PersonelKategoriID= Convert.ToInt32(cmbperkategori.SelectedValue);
            personellerEntity.PersonelEngelDurumu = Convert.ToBoolean(cbengel.Checked);
            personellerEntity.IlID = Convert.ToInt32(cmbperil.SelectedValue);
            personellerEntity.IlceID = Convert.ToInt32(cmbperilce.SelectedValue);
            personellerEntity.UlkeID = Convert.ToInt32(cmbperulke.SelectedValue);
            personellerEntity.PersonelAdres = peradres.Text;
            personellerEntity.PersonelAcilDurumKisiAd = peracildurumadsoyad.Text;
            personellerEntity.PersonelAcilDurumKisiTelefon = peracildurumtel.Text;
            personellerEntity.ResimId = Convert.ToInt32(perresim.Text);
            vardiyaEntity.VardiyaId=Convert.ToInt32(cmbpervardiya.SelectedValue);

        }
        void MylistviewDoldurma()
        { tool.ListViewDoldur(lvpersonelbilgileri, "sp_personelbilgilerigetir", false, null); }

        private void btnperEkle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikileriEntityIleYazdır();

                personellerEntity.PersonelId = (int)personellerDAL.getInsertPersonel(personellerEntity, vardiyaEntity);

                if (pertckimlik.Text == "")
                {
                    MessageBox.Show("TC KİMLİK NUMARASINI GİRİNİZ");
                }
                else if (personellerEntity.PersonelId == 0)
                {
                    MessageBox.Show("Girilen TC Kimlik Numarasında zaten Personel var. Tekrar Deneyiniz");
                }
                else
                {
                    MessageBox.Show("PERSONEL BAŞARIYLA EKLENDİ");
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Personel Ekleme Basarisiz" + HATA.Message);
            }
            MylistviewDoldurma();
        }

        private void btnperGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikileriEntityIleYazdır();

                int a = personellerDAL.getUpdatePersonel(personellerEntity,vardiyaEntity);

                if (pertckimlik.Text == "")
                {
                    MessageBox.Show("TC KİMLİK NUMARASINI GİRİNİZ");
                }
                else
                {
                    MessageBox.Show("PERSONEL BAŞARIYLA GÜNCELLENDİ" + a.ToString());
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Personel Güncelleme Basarisiz" + HATA.Message);
            }
            MylistviewDoldurma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp =
            {new SqlParameter
                {
                    ParameterName="PersonelTcKimlik",
                    Value=pertcyegöregetir.Text
                }
            };

            tool.ListViewDoldur(lvpersonelbilgileri, "sp_tcyegörepersonelgetir", true, sp);
        }

        private void btnperTemizle_Click(object sender, EventArgs e)
        {
            tool.FormTemizle(this);
        }

        private void lvpersonelbilgileri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tool.FormDoldur("select*from Personelbilgileri where PersonelId=" + lvpersonelbilgileri.SelectedItems[0].SubItems[0].Text, null, this);
            pertcyegöregetir.Text = "";
            personellerEntity.PersonelId = Convert.ToInt32(lvpersonelbilgileri.SelectedItems[0].SubItems[0].Text);
        }

        private void btnperHepsiniGetir_Click(object sender, EventArgs e)
        {
            MylistviewDoldurma();
        }
    }
}
