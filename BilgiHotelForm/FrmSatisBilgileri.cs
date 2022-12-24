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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BilgiHotelForm
{
    public partial class FrmSatisBilgileri : Form
    {
        Tools tools = new Tools();
        SatisEntity satisEntity = new SatisEntity();
        SatisDAL satisDAL = new SatisDAL();
        PersonellerEntity personellerEntity = new PersonellerEntity();
        MüsterilerEntity müsterilerEntity = new MüsterilerEntity();
        MisafirlerEntity misafirlerEntity = new MisafirlerEntity();
        OdalarEntity odalarEntity = new OdalarEntity();
        public FrmSatisBilgileri()
        {
            InitializeComponent();
        }

        private void FrmSatisBilgileri_Load(object sender, EventArgs e)
        {
            tools.ComboBoxDoldur(cmbstsbil, "sp_OdaSatisHepsiniGetir", true);
        }

        private void btnstsbilGetir_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp =
            {new SqlParameter
                {
                    ParameterName="gelenTcKimlikNo",
                Value=stsbiltcyegörestsgetir.Text
            }
            };

            tools.ListViewDoldur(LvstsBil, "sp_stsbilgileri", true, sp);
        }
        void formdaikibilgilerileriEntityIleYazdir()
        {
            müsterilerEntity.MusteriAd = stsbilgileriMüsAd.Text;
            müsterilerEntity.MusteriSoyad = stsBilgileriMüsSoyad.Text;
            müsterilerEntity.MusteriTCKimlik = stsbilmüstc.Text;
            satisEntity.SatisOdaGirisTarihi = stsbildtpodagiris.Value;
            satisEntity.SatisOdaCikisTarihi = stsbildtpodacikis.Value;
            satisEntity.SatisIndirim = Convert.ToInt32(stsbilindirim.Text);
            satisEntity.KartId = Convert.ToInt32(stsbilkartno.Text);
            satisEntity.OdaId = Convert.ToInt32(stsbilodano.Text);
            satisEntity.OdaSatisDurum = Convert.ToBoolean(cbodasatisdurum.Checked);
            satisEntity.OdaSatisTutar = Convert.ToDecimal(stsbilodasatistutar.Text);
            satisEntity.OdaSatisTip = Convert.ToInt32(cmbstsbil.SelectedValue);

        }
        void MylistviewDoldurma()
        { tools.ListViewDoldur(LvstsBil, "sp_stsbilgilerigetir", true, null); }

        private void btnstsbiltemizle_Click(object sender, EventArgs e)
        {
            tools.FormTemizle(this);
        }

        private void LvstsBil_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tools.FormDoldur("select*from satisbilgileri where SatisId=" + LvstsBil.SelectedItems[0].SubItems[0].Text, null, this);
            stsbiltcyegörestsgetir.Text = "";
            satisEntity.SatisId = Convert.ToInt32(LvstsBil.SelectedItems[0].SubItems[0].Text);
        }

        private void btnstsbilHepsiniGetir_Click(object sender, EventArgs e)
        {
            MylistviewDoldurma();
        }

        private void btnstsbilGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikibilgilerileriEntityIleYazdir();
                int a = satisDAL.getUpdateSatis(satisEntity);

                if (stsbilmüstc.Text == "")
                {
                    MessageBox.Show("TC KİMLİK NUMARASINI GİRİNİZ");
                }
                else
                {
                    MessageBox.Show("SATIŞ BAŞARIYLA GÜNCELLENDİ");
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("SATIŞ Güncelleme Basarisiz" + HATA.Message);
            }
            MylistviewDoldurma();
        }

        private void cmbstsbil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tools.ComboBoxDoldur(cmbstsbil, "select*from tbl_OdaSatisTip where OdaSatisTip=" + (int)cmbstsbil.SelectedValue, false);
        }
    }
}
