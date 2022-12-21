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
    public partial class FrmRezervasyonEkle : Form
    {
        Tools tools = new Tools();
        RezervasyonlarEntity rezent = new RezervasyonlarEntity();
        RezervasyonDAL redal = new RezervasyonDAL();
        PersonellerEntity personel = new PersonellerEntity();
        MüsterilerEntity müsteri = new MüsterilerEntity();
        MisafirlerEntity misafir = new MisafirlerEntity();
        OdalarEntity odalar= new OdalarEntity();


        public FrmRezervasyonEkle()
        {
            InitializeComponent();
        }
        void MylistviewMüsteriDoldurma()
        {
            SqlParameter[] sp =
            {new SqlParameter
                {
                    ParameterName="MusteriTCKimlik",
                    Value=reztcgoremusterigetir.Text
                }
            };
            tools.ListViewDoldur(REZMüsBilgileri, "sp_tcyegöremüsterigetir", true, sp);
        }
        void MylistviewMisafirDoldurma()
        {
            SqlParameter[] sp1 =
            {new SqlParameter
                {
                    ParameterName="MisafirTCKimlik",
                    Value=reztcyegörmisafirgetir.Text
                }
            };
            tools.ListViewDoldur(REZMisBilgileri, "sp_tcyegöremisafirgetir", true, sp1);
        }
        private void rezmüsgetir_Click(object sender, EventArgs e)
        {
            MylistviewMüsteriDoldurma();
        }

        private void rezmisgetir_Click(object sender, EventArgs e)
        {
            MylistviewMisafirDoldurma();
        }

        private void FrmRezervasyonEkle_Load(object sender, EventArgs e)
        {
            tools.ComboBoxDoldur(reztipcmb, "sp_RezervasyonTipHepsiniGetir", true);
            tools.FormlaraTarihSaat(lblTarih, lblSaat);
            tools.günHesaplama(rezdtpodagiris.Value, DateTime.Now, label8);
            
        }
        public void erkenrezsorgu()
        {
            if (reztipcmb.SelectedValue!= null)
            {
                SqlParameter[] sp =
                            {new SqlParameter
            {
                    ParameterName="@GelenGünSayisi",
                    Value=label8.Text
                },new SqlParameter
                {
                    ParameterName="@GelenRezervasyonTipi",
                    Value=reztipcmb.SelectedValue,
                }
            };

                int erkenrezervasyonindirimorani = Convert.ToInt32(SQL.SqlexecuteScalar("sp_ErkenRezervasyonIndirim", true, sp));

                if (erkenrezervasyonindirimorani != 0)
                {
                    rezindirimcb.Text = erkenrezervasyonindirimorani.ToString();
                }
                else
                {
                    rezindirimcb.Text = "0";
                }

            }



        }

        private void reztipcmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            erkenrezsorgu();
            //SqlParameter[] sp2 =
            //{new SqlParameter
            //    {
            //        ParameterName="@GelenRezervasyonTipi",
            //        Value=reztipcmb.SelectedValue,
            //    }
            //};
            //tools.RezTipineGöreFiyatBelirleme(reztipcmb, reztxtsatistutar, "sp_reztipinegörefiyat", true, sp2);
            if (rezindirimcb.Text=="0")
            {
                decimal fiyat = Convert.ToDecimal(reztxtsatistutar.Text);
                int toplamgün = Convert.ToInt32(rezlbltoplamgün.Text);
                rezlblfiyat.Text = Convert.ToString(fiyat * toplamgün);
            }
            else
            {
                decimal fiyat = Convert.ToDecimal(reztxtsatistutar.Text);
                int tutar = Convert.ToInt32(reztxtsatistutar.Text);
                int toplamgün = Convert.ToInt32(rezlbltoplamgün.Text);
                tutar *= Convert.ToInt32(rezindirimcb.Text);
                tutar /= 100;
                rezlblfiyat.Text = Convert.ToString((fiyat - tutar) * toplamgün);
            }
        }
        void formdakiRezervasyonlarivePersonelientityileyazdırma()
        {
            rezent.RezervasyonGecerlilikSonTarihi = rezdtpsongecerlilik.Value;
            rezent.ErkenRezervasyonIndirim = Convert.ToInt32(rezindirimcb.Text);
            rezent.RezervasyonTipiId = Convert.ToInt32(reztipcmb.SelectedValue);
            rezent.RezervasyonAciklama = reztxtaciklama.Text;
            rezent.RezervasyonIptalOk = Convert.ToBoolean(Rezcbreziptalmi.Checked);
            rezent.RezervasyonGirisTarihi = rezdtpodagiris.Value;
            rezent.RezervasyonCikisTarihi = rezdtpodacikis.Value;
            rezent.RezervasyonTutari = Convert.ToDecimal(rezlblfiyat.Text);
            rezent.OdaId = Convert.ToInt32(reztxtodanumarası.Text);
            rezent.KartId = Convert.ToInt32(reztxtodakartno.Text);
            rezent.OdaTipiId = Convert.ToInt32(txtRezOdaTipi.Text);
            personel.PersonelId = Login.personelId;
        }
        

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            if (reztxtodanumarası.Text!=string.Empty && REZMüsBilgileri.Items.Count>0 && REZMisBilgileri.Items.Count>0)
            {
                formdakiRezervasyonlarivePersonelientityileyazdırma();
                rezent.RezervasyonId = (int)redal.getInsertRezervasyon(rezent, personel);


                for (int i = 0; i < REZMisBilgileri.Items.Count; i++)
                {
                    int musteriId = Convert.ToInt32(REZMüsBilgileri.Items[0].SubItems[0].Text);
                    int misafirId = Convert.ToInt32(REZMisBilgileri.Items[i].SubItems[0].Text);
                    müsteri.MusteriID = musteriId;
                    misafir.MisafirId = misafirId;
                    odalar.OdaId = Convert.ToInt32(reztxtodanumarası.Text);
                   
                  int etkilenensatir = (int)redal.getInsertMüsteriRezervasyon(müsteri, rezent, misafir, odalar);
                }
                MessageBox.Show("Rezervasyon  Eklenmistir");
            }
            else
            {
                MessageBox.Show("Tekrar Deneyin");
            }
        }

        private void reztipcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
