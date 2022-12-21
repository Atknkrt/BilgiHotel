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
    public partial class FrmSatisEkle : Form
    {
        Tools tools = new Tools();
        SatisEntity stsent = new SatisEntity();
        SatisDAL sadal = new SatisDAL();
        PersonellerEntity personel = new PersonellerEntity();
        MüsterilerEntity müsteri = new MüsterilerEntity();
        MisafirlerEntity misafir = new MisafirlerEntity();
        OdalarEntity odalar = new OdalarEntity();
        public FrmSatisEkle()
        {
            InitializeComponent();
        }
        void MylistviewMüsteriDoldurma()
        {
            SqlParameter[] sp =
            {new SqlParameter
                {
                    ParameterName="MusteriTCKimlik",
                    Value=ststcgoremusterigetir.Text
                }
            };
            tools.ListViewDoldur(StsMüsBilgileri, "sp_tcyegöremüsterigetir", true, sp);
        }
        void MylistviewMisafirDoldurma()
        {
            SqlParameter[] sp1 =
            {new SqlParameter
                {
                    ParameterName="MisafirTCKimlik",
                    Value=ststcyegörmisafirgetir.Text
                }
            };
            tools.ListViewDoldur(StsMisBilgileri, "sp_tcyegöremisafirgetir", true, sp1);
        }

        private void FrmSatisEkle_Load(object sender, EventArgs e)
        {
            tools.ComboBoxDoldur(ststipcmb, "sp_RezervasyonTipHepsiniGetir", true);
            tools.FormlaraTarihSaat(lblTarih,lblSaat);
            tools.günHesaplama(stsdtpodagiris.Value, DateTime.Now, label5);
        }

        private void stsmüsgetir_Click(object sender, EventArgs e)
        {
            MylistviewMüsteriDoldurma();
        }

        private void stsmisgetir_Click(object sender, EventArgs e)
        {
            MylistviewMisafirDoldurma();
        }
        public void erkensatissorgu()
        {
            if (ststipcmb.SelectedValue != null)
            {
                SqlParameter[] sp =
                            {new SqlParameter
            {
                    ParameterName="@GelenGünSayisi",
                    Value=label5.Text
                },new SqlParameter
                {
                    ParameterName="@GelenOdaSatisTipi",
                    Value=ststipcmb.SelectedValue,
                }
            };

                int erkensatisindirimorani = Convert.ToInt32(SQL.SqlexecuteScalar("sp_ErkenSatisIndirim", true, sp));

                if (erkensatisindirimorani != 0)
                {
                    ststxtindirim.Text = erkensatisindirimorani.ToString();
                }
                else
                {
                    ststxtindirim.Text = "0";
                }

            }



        }

        private void ststipcmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            erkensatissorgu();
            //SqlParameter[] sp2 =
            //{new SqlParameter
            //    {
            //        ParameterName="@GelenRezervasyonTipi",
            //        Value=reztipcmb.SelectedValue,
            //    }
            //};
            //tools.RezTipineGöreFiyatBelirleme(reztipcmb, reztxtsatistutar, "sp_reztipinegörefiyat", true, sp2);
            if (ststxtindirim.Text == "0")
            {
                decimal fiyat = Convert.ToDecimal(ststxtsatistutar.Text);
                int toplamgün = Convert.ToInt32(stslbltoplamgün.Text);
                stsodasatisoplamfiyat.Text = Convert.ToString(fiyat * toplamgün);
            }
            else
            {
                decimal fiyat = Convert.ToDecimal(ststxtsatistutar.Text);
                int tutar = Convert.ToInt32(ststxtsatistutar.Text);
                int toplamgün = Convert.ToInt32(stslbltoplamgün.Text);
                tutar *= Convert.ToInt32(ststxtindirim.Text);
                tutar /= 100;
                stsodasatisoplamfiyat.Text = Convert.ToString((fiyat - tutar) * toplamgün);
            }
        }
        void formdakiSatislarivePersonelientityileyazdırma()
        {
            stsent.SatisOdaGirisTarihi = stsdtpodagiris.Value;
            stsent.SatisOdaCikisTarihi = stsdtpodacikis.Value;
            stsent.SatisIndirim = Convert.ToInt32(ststxtindirim.Text);
            stsent.KartId = Convert.ToInt32(ststxtodakartno.Text);
            stsent.OdaId = Convert.ToInt32(ststxtodanumarası.Text);
            stsent.OdaSatisDurum = Convert.ToBoolean(stscbodadurum.Checked);
            stsent.OdaSatisTip = Convert.ToInt32(ststipcmb.SelectedValue);
            stsent.OdaSatisTutar = Convert.ToDecimal(stsodasatisoplamfiyat.Text);
            personel.PersonelId = Login.personelId;
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (ststxtodanumarası.Text != string.Empty && StsMüsBilgileri.Items.Count > 0 && StsMisBilgileri.Items.Count > 0)
            {
                formdakiSatislarivePersonelientityileyazdırma();
                stsent.SatisId = (int)sadal.getInsertSatis(stsent, personel);


                for (int i = 0; i < StsMisBilgileri.Items.Count; i++)
                {
                    int musteriId = Convert.ToInt32(StsMüsBilgileri.Items[0].SubItems[0].Text);
                    int misafirId = Convert.ToInt32(StsMisBilgileri.Items[i].SubItems[0].Text);
                    müsteri.MusteriID = musteriId;
                    misafir.MisafirId = misafirId;
                    odalar.OdaId = Convert.ToInt32(ststxtodanumarası.Text);

                    int etkilenensatir = (int)sadal.getInsertMüsteriSatis(müsteri, misafir,stsent, odalar);
                }
                MessageBox.Show("SATIŞ  Eklenmistir");
            }
            else
            {
                MessageBox.Show("Tekrar Deneyin");
            }
        }
    }
}
