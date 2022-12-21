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
	public partial class FrmRezervasyonBilgileri : Form
	{
		Tools tools = new Tools();
		RezervasyonlarEntity rezent = new RezervasyonlarEntity();
		RezervasyonDAL redal = new RezervasyonDAL();
		PersonellerEntity personel = new PersonellerEntity();
		MüsterilerEntity müsteri = new MüsterilerEntity();
		MisafirlerEntity misafir = new MisafirlerEntity();
		OdalarEntity odalar = new OdalarEntity();
		public FrmRezervasyonBilgileri()
		{
			InitializeComponent();
		}

		private void btnrezbilGetir_Click(object sender, EventArgs e)
		{
			SqlParameter[] sp =
			{new SqlParameter
				{
					ParameterName="gelenTcKimlikNo",
				Value=rezbilTCyeGöre.Text
			}
			};

			tools.ListViewDoldur(LvRezBil, "sp_rezbilgileri", true, sp);
		}
		void formdaikibilgilerileriEntityIleYazdir()
		{
			//müsteri.MusteriAd = rezbilgileriMüsAd.Text;
			//müsteri.MusteriSoyad = rezBilgileriMüsSoyad.Text;
			//müsteri.MusteriTCKimlik = rezbilmüstc.Text;
			rezent.RezervasyonGecerlilikSonTarihi = rezbildtpgecerlilik.Value;
			rezent.ErkenRezervasyonIndirim = Convert.ToInt32(rezbilindirim.Text);
			rezent.RezervasyonTipiId = Convert.ToInt32(rezbiltipcmb.SelectedValue);
			rezent.RezervasyonAciklama = rezbilaciklama.Text;
			rezent.RezervasyonIptalOk = Convert.ToBoolean(Rezcbrezbiliptalmi.Checked);
			rezent.RezervasyonGirisTarihi = dtprezbilgiris.Value;
			rezent.RezervasyonCikisTarihi = dtprezbilcikis.Value;
			rezent.RezervasyonTutari = Convert.ToDecimal(rezbilTutar.Text);
			rezent.OdaId = Convert.ToInt32(rezbilOdaNo.Text);
			rezent.KartId = Convert.ToInt32(rezbilkartno.Text);
			rezent.OdaTipiId = Convert.ToInt32(rezbilodatipi.Text);


		}

		void MylistviewDoldurma()
		{ tools.ListViewDoldur(LvRezBil, "sp_rezbilgilerigetir", true, null); }


		private void btnrezbiltemizle_Click(object sender, EventArgs e)
		{
			tools.FormTemizle(this);
		}

		private void LvRezBil_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tools.FormDoldur("select*from rezBilgileri where RezervasyonId=" + LvRezBil.SelectedItems[0].SubItems[0].Text, null, this);
			rezbilTCyeGöre.Text = "";
            rezent.RezervasyonId = Convert.ToInt32(LvRezBil.SelectedItems[0].SubItems[0].Text);
        }

		private void btnrezbilHepsiniGetir_Click(object sender, EventArgs e)
		{
			MylistviewDoldurma();
		}

		private void btnrezbilGüncelle_Click(object sender, EventArgs e)
		{
			try
			{
				formdaikibilgilerileriEntityIleYazdir();
                int a = redal.getUpdateRezervasyon(rezent);

                if (rezbilmüstc.Text == "")
				{
					MessageBox.Show("TC KİMLİK NUMARASINI GİRİNİZ");
				}
				else
				{
					MessageBox.Show("REZERVASYON BAŞARIYLA GÜNCELLENDİ");
				}
			}
			catch (Exception HATA)
			{
				MessageBox.Show("REZERVASYON Güncelleme Basarisiz" + HATA.Message);
			}
			MylistviewDoldurma();
		}

		private void FrmRezervasyonBilgileri_Load(object sender, EventArgs e)
		{
			tools.ComboBoxDoldur(rezbiltipcmb, "sp_RezervasyonTipHepsiniGetir", true);
		}

		private void rezbiltipcmb_SelectionChangeCommitted(object sender, EventArgs e)
		{
			tools.ComboBoxDoldur(rezbiltipcmb, "select*from tbl_RezervasyonTip where RezervasyonTipId=" + (int)rezbiltipcmb.SelectedValue, false);
		}
	}
}
