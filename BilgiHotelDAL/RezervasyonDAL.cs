using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{ //levent
    public class RezervasyonDAL
    {
        #region//insert Rezervasyonn ve Rezervasyon-Personel tablolarina
        public object getInsertRezervasyon(RezervasyonlarEntity EklenecekRezervasyon, PersonellerEntity personel)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "RezervasyonGecerlilikSonTarihi",
                    Value=EklenecekRezervasyon.RezervasyonGecerlilikSonTarihi
                },
                new SqlParameter
                {
                    ParameterName= "ErkenRezervasyonIndirim",
                    Value=EklenecekRezervasyon.ErkenRezervasyonIndirim
                },
                new SqlParameter
                {
                    ParameterName= "RezervasyonTipiId",
                    Value=EklenecekRezervasyon.RezervasyonTipiId
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonAciklama",
                    Value=EklenecekRezervasyon.RezervasyonAciklama
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonIptalOk",
                    Value=EklenecekRezervasyon.RezervasyonIptalOk
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonGirisTarihi",
                    Value=EklenecekRezervasyon.RezervasyonGirisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonCikisTarihi",
                    Value=EklenecekRezervasyon.RezervasyonCikisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonTutari",
                    Value=EklenecekRezervasyon.RezervasyonTutari
                },
                 new SqlParameter
                {
                    ParameterName= "OdaId",
                    Value=EklenecekRezervasyon.OdaId
                },
                 new SqlParameter
                {
                    ParameterName= "KartId",
                    Value=EklenecekRezervasyon.KartId
                },
                 new SqlParameter
                {
                    ParameterName= "OdaTipiId",
                    Value=EklenecekRezervasyon.OdaTipiId
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelId",
                    Value=personel.PersonelId
                }

            };

            object deger = SQL.SqlexecuteScalar("sp_InsertRezervasyon", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//insert Müsteri-Rezervasyon tablosuna
        public int getInsertMüsteriRezervasyon(MüsterilerEntity müsteri,RezervasyonlarEntity Rezervasyon,MisafirlerEntity misafir,OdalarEntity oda)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "MusteriID",
                    Value=müsteri.MusteriID
                },
                new SqlParameter
                {
                    ParameterName= "RezervasyonId",
                    Value=Rezervasyon.RezervasyonId
                },
                new SqlParameter
                {
                    ParameterName= "MisafirId",
                    Value=misafir.MisafirId
                },
                 new SqlParameter
                {
                    ParameterName= "OdaId",
                    Value=oda.OdaId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertMüsteriRezervasyon", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Rezervasyonlar
        public int getUpdateRezervasyon(RezervasyonlarEntity DüzenelenecekRezervasyon)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "RezervasyonGecerlilikSonTarihi",
                    Value=DüzenelenecekRezervasyon.RezervasyonGecerlilikSonTarihi
                },
                new SqlParameter
                {
                    ParameterName= "ErkenRezervasyonIndirim",
                    Value=DüzenelenecekRezervasyon.ErkenRezervasyonIndirim
                },
                new SqlParameter
                {
                    ParameterName= "RezervasyonTipiId",
                    Value=DüzenelenecekRezervasyon.RezervasyonTipiId
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonAciklama",
                    Value=DüzenelenecekRezervasyon.RezervasyonAciklama
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonIptalOk",
                    Value=DüzenelenecekRezervasyon.RezervasyonIptalOk
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonGirisTarihi",
                    Value=DüzenelenecekRezervasyon.RezervasyonGirisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonCikisTarihi",
                    Value=DüzenelenecekRezervasyon.RezervasyonCikisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonTutari",
                    Value=DüzenelenecekRezervasyon.RezervasyonTutari
                },
                 new SqlParameter
                {
                    ParameterName= "OdaId",
                    Value=DüzenelenecekRezervasyon.OdaId
                },
                 new SqlParameter
                {
                    ParameterName= "KartId",
                    Value=DüzenelenecekRezervasyon.KartId
                },
                 new SqlParameter
                {
                    ParameterName= "OdaTipiId",
                    Value=DüzenelenecekRezervasyon.OdaTipiId
                }

            };
            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateRezervasyon", true, kmtprmtr);
            return deger;
        }
		#endregion
		#region//Update RezervasyonBilgileri
		public int getUpdateRezervasyonBilgileri(RezervasyonlarEntity DüzenelenecekRezervasyon,MüsterilerEntity müsteri)
		{
			SqlParameter[] kmtprmtr =
			{
				new SqlParameter
				{
					ParameterName= "RezervasyonId",
					Value=DüzenelenecekRezervasyon.RezervasyonId
				},
                new SqlParameter
				{
					ParameterName= "MusteriAd",
					Value=müsteri.MusteriAd
				},new SqlParameter
				{
					ParameterName= "MusteriSoyad",
					Value=müsteri.MusteriSoyad
				},
                new SqlParameter
				{
					ParameterName= "MusteriTCKimlik",
					Value=müsteri.MusteriTCKimlik
				},
				new SqlParameter
				{
					ParameterName= "RezervasyonGecerlilikSonTarihi",
					Value=DüzenelenecekRezervasyon.RezervasyonGecerlilikSonTarihi
				},
				new SqlParameter
				{
					ParameterName= "ErkenRezervasyonIndirim",
					Value=DüzenelenecekRezervasyon.ErkenRezervasyonIndirim
				},
				new SqlParameter
				{
					ParameterName= "RezervasyonTipiId",
					Value=DüzenelenecekRezervasyon.RezervasyonTipiId
				},
				 new SqlParameter
				{
					ParameterName= "RezervasyonAciklama",
					Value=DüzenelenecekRezervasyon.RezervasyonAciklama
				},
				 new SqlParameter
				{
					ParameterName= "RezervasyonIptalOk",
					Value=DüzenelenecekRezervasyon.RezervasyonIptalOk
				},
				 new SqlParameter
				{
					ParameterName= "RezervasyonGirisTarihi",
					Value=DüzenelenecekRezervasyon.RezervasyonGirisTarihi
				},
				 new SqlParameter
				{
					ParameterName= "RezervasyonCikisTarihi",
					Value=DüzenelenecekRezervasyon.RezervasyonCikisTarihi
				},
				 new SqlParameter
				{
					ParameterName= "RezervasyonTutari",
					Value=DüzenelenecekRezervasyon.RezervasyonTutari
				},
				 new SqlParameter
				{
					ParameterName= "OdaId",
					Value=DüzenelenecekRezervasyon.OdaId
				},
				 new SqlParameter
				{
					ParameterName= "KartId",
					Value=DüzenelenecekRezervasyon.KartId
				},
				 new SqlParameter
				{
					ParameterName= "OdaTipiId",
					Value=DüzenelenecekRezervasyon.OdaTipiId
				}

			};
			int deger = SQL.SqlexecuteNonQuerry("sp_UpdateRezervasyonBilgileri", true, kmtprmtr);
			return deger;
		}
		#endregion
		#region //Id'ye Göre Rezervasyon Getir
		public RezervasyonlarEntity getTCyeGöreRezervasyonGetir(int RezervasyonId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "RezervasyonId ",
                    Value=RezervasyonId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGöreRezervasyonGetir", true, kmtprmtr);
            RezervasyonlarEntity myrezervasyon = new RezervasyonlarEntity();
            while (oku.Read())
            {
                myrezervasyon.RezervasyonId = Convert.ToInt32(oku["RezervasyonId"]);
                myrezervasyon.RezervasyonGecerlilikSonTarihi = Convert.ToDateTime(oku["RezervasyonGecerlilikSonTarihi"]);
                myrezervasyon.ErkenRezervasyonIndirim = Convert.ToInt32(oku["ErkenRezervasyonIndirim"]);
                myrezervasyon.RezervasyonTipiId = Convert.ToInt32(oku["RezervasyonTipiId"]);
                myrezervasyon.RezervasyonAciklama = oku["RezervasyonAciklama"].ToString();
                myrezervasyon.RezervasyonIptalOk = Convert.ToBoolean(oku["RezervasyonIptalOk"]);
                myrezervasyon.RezervasyonGirisTarihi = Convert.ToDateTime(oku["RezervasyonGirisTarihi"]);
                myrezervasyon.RezervasyonCikisTarihi = Convert.ToDateTime(oku["RezervasyonCikisTarihi"]);
                myrezervasyon.RezervasyonTutari = Convert.ToDecimal(oku["RezervasyonTutari"]);
                myrezervasyon.OdaId = Convert.ToInt32(oku["OdaId"]);
                myrezervasyon.KartId = Convert.ToInt32(oku["KartId"]);
                myrezervasyon.OdaTipiId = Convert.ToInt32(oku["OdaTipiId"]);
            }
            oku.Close();
            return myrezervasyon;
        }
        #endregion
        #region //Rezervasyonlarin Hepsini Getir
        public RezervasyonlarEntity getRezervasyonlarinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_BütünRezervasyonlariGetir", true, null);
            RezervasyonlarEntity rezler = null;
            while (oku.Read())
            {
                rezler.RezervasyonId = Convert.ToInt32(oku["RezervasyonId"]);
                rezler.RezervasyonGecerlilikSonTarihi = Convert.ToDateTime(oku["RezervasyonGecerlilikSonTarihi"]);
                rezler.ErkenRezervasyonIndirim = Convert.ToInt32(oku["ErkenRezervasyonIndirim"]);
                rezler.RezervasyonTipiId = Convert.ToInt32(oku["RezervasyonTipiId"]);
                rezler.RezervasyonAciklama = oku["RezervasyonAciklama"].ToString();
                rezler.RezervasyonIptalOk = Convert.ToBoolean(oku["RezervasyonIptalOk"]);
                rezler.RezervasyonGirisTarihi = Convert.ToDateTime(oku["RezervasyonGirisTarihi"]);
                rezler.RezervasyonCikisTarihi = Convert.ToDateTime(oku["RezervasyonCikisTarihi"]);
                rezler.RezervasyonTutari = Convert.ToDecimal(oku["RezervasyonTutari"]);
                rezler.OdaId = Convert.ToInt32(oku["OdaId"]);
                rezler.KartId = Convert.ToInt32(oku["KartId"]);
                rezler.OdaTipiId = Convert.ToInt32(oku["OdaTipiId"]);
            }
            return rezler;
        }
        #endregion
        #region //Delete Rezerasyon
        public int getRezerasyonSil(RezervasyonlarEntity silinecekRez)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "RezervasyonId",
                    Value=silinecekRez.RezervasyonId
                }
            };
            int etkilenenSatir = SQL.SqlexecuteNonQuerry("sp_DeleteRezervasyon", true, kmtprmtr);
            return etkilenenSatir;
        }
        #endregion
    }
}
