using BilgiHotelDAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiHotelForm
{
    public partial class OdaDurumBilgileri : Form
    {
        OdaDAL ODA = new OdaDAL();
        OdalarEntity MYODA= new OdalarEntity();
        SatisEntity satis= new SatisEntity();
        Tools tools= new Tools();
        public OdaDurumBilgileri()
        {
            InitializeComponent();
        }
        public void entityegöreodabilgilerigetirme()
        {
            txtodatipi.Text = MYODA.OdaTipiId.ToString();
            txtOdaFiyat.Text=MYODA.OdaFiyat.ToString();
            txtOdaYatak.Text = MYODA.OdaYatakTipi;
            OdacbMinibar.Checked = Convert.ToBoolean(MYODA.OdaMiniBarOk);
            OdacbKlima.Checked = Convert.ToBoolean(MYODA.OdaKlimaOk);
            OdacbKurutma.Checked = Convert.ToBoolean(MYODA.OdaKurutmaOk);
            OdacbWifi.Checked = Convert.ToBoolean(MYODA.OdaWifiOk);
            OdacbKasa.Checked = Convert.ToBoolean(MYODA.OdaKasaOk);
            OdacbBalkon.Checked = Convert.ToBoolean(MYODA.OdaBalkonOk);
            OdacbTv.Checked = Convert.ToBoolean(MYODA.OdaTvOk);
            txtOdaAciklama.Text = MYODA.OdaAciklama;
            OdatxtEbat.Text = MYODA.OdaEbatBoyut;
            txtOdaNo.Text = MYODA.OdaNo;
            txtOdaKat.Text = MYODA.OdaKat;
            txtOdaKisi.Text = MYODA.OdaKisiSayisi.ToString();

        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp =
            {new SqlParameter
                {
                    ParameterName="@ilkTarih",
                    Value=dtpOdaGiris.Value
                },new SqlParameter
                {
                    ParameterName="@ikincitarih",
                    Value=dtpOdaCikis.Value
                }
            };
            tools.gbodalar(gbOdalar, "sp_TarihlereGoreOdaSorgu", true, sp);
        }

        private void odasec(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MYODA = ODA.getODANoyaGöreOdaGetir(Convert.ToInt32(btn.Text));
            entityegöreodabilgilerigetirme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tools.FormTemizle(this);
        }

        private void btnRezervasyonaGit_Click(object sender, EventArgs e)
        {
            

            
            
            
            
            FrmRezervasyonEkle re = new FrmRezervasyonEkle();
            re.MdiParent = FrmAnasayfa.ActiveForm;
            re.Show();
            if (txtOdaNo.Text != "" && txtOdaFiyat.Text != "")
            {
                re.reztxtodanumarası.Text = txtOdaNo.Text;
                re.reztxtodakartno.Text = txtOdaNo.Text;
                re.reztxtsatistutar.Text = txtOdaFiyat.Text;
                re.txtRezOdaTipi.Text = txtodatipi.Text;
                re.rezdtpodagiris.Value = dtpOdaGiris.Value;
                re.rezdtpodacikis.Value = dtpOdaCikis.Value;
                tools.günHesaplama(dtpOdaGiris.Value, dtpOdaCikis.Value, re.rezlbltoplamgün);
                tools.günHesaplama(DateTime.Now, re.rezdtpodagiris.Value, re.label8);
            }
            this.Close();



        }

        private void OdaDurumBilgileri_Load(object sender, EventArgs e)
        {
            //tools.ComboBoxDoldur(cmbOdaTipi, "sp_OdaTipiHepsiniGetir", true);
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            FrmSatisEkle sa = new FrmSatisEkle();
            sa.MdiParent = FrmAnasayfa.ActiveForm;
            sa.Show();
            if (txtOdaNo.Text != "" && txtOdaFiyat.Text != "")
            {
                sa.ststxtodanumarası.Text = txtOdaNo.Text;
                sa.ststxtodakartno.Text = txtOdaNo.Text;
                sa.ststxtsatistutar.Text = txtOdaFiyat.Text;
                sa.stsdtpodagiris.Value = dtpOdaGiris.Value;
                sa.stsdtpodacikis.Value = dtpOdaCikis.Value;
                tools.günHesaplama(dtpOdaGiris.Value, dtpOdaCikis.Value, sa.stslbltoplamgün);
                tools.günHesaplama(DateTime.Now, sa.stsdtpodagiris.Value, sa.label5);
            }
            this.Close();
        }
    }
}
