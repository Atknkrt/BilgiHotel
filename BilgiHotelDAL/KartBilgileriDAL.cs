using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KartBilgileriDAL
    {
        #region // Insert KartBilgileri
        public int getInsertKartlar(KartBilgileriEntity EklenecekKart)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaId",
                    Value=EklenecekKart.OdaId
                },
                new SqlParameter
                {
                    ParameterName= "KartAktifMi",
                    Value=EklenecekKart.KartAktifMi
                },
                new SqlParameter
                {
                    ParameterName= "PersonelId",
                    Value=EklenecekKart.PersonelId
                },
                new SqlParameter
                {
                    ParameterName= "MisafirId",
                    Value=EklenecekKart.MisafirId
                },
                new SqlParameter
                {
                    ParameterName= "KartVerilisTarihi",
                    Value=EklenecekKart.KartVerilisTarihi
                },
                new SqlParameter
                {
                    ParameterName= "KartAlisTarihi",
                    Value=EklenecekKart.KartAlisTarihi
                },
                new SqlParameter
                {
                    ParameterName= "KartIslemAciklama",
                    Value=EklenecekKart.KartIslemAciklama
                }


            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertKartBilgileri", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update KartBilgileri
        public int getUpdateKartBilgileri(KartBilgileriEntity GüncellenecekKartBilgileri)
        {

            SqlParameter[] kmtprmtr =
     {
                new SqlParameter
                {
                    ParameterName= "OdaId",
                    Value=GüncellenecekKartBilgileri.OdaId
                },
                new SqlParameter
                {
                    ParameterName= "KartAktifMi",
                    Value=GüncellenecekKartBilgileri.KartAktifMi
                },
                new SqlParameter
                {
                    ParameterName= "PersonelId",
                    Value=GüncellenecekKartBilgileri.PersonelId
                },
                new SqlParameter
                {
                    ParameterName= "MisafirId",
                    Value=GüncellenecekKartBilgileri.MisafirId
                },
                new SqlParameter
                {
                    ParameterName= "KartVerilisTarihi",
                    Value=GüncellenecekKartBilgileri.KartVerilisTarihi
                },
                new SqlParameter
                {
                    ParameterName= "KartAlisTarihi",
                    Value=GüncellenecekKartBilgileri.KartAlisTarihi
                },
                new SqlParameter
                {
                    ParameterName= "KartIslemAciklama",
                    Value=GüncellenecekKartBilgileri.KartIslemAciklama
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_GüncelleKartlar", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre kart Getir
        public KartBilgileriEntity getIDyegöregetir(int KartId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KartId",
                    Value=KartId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGöreKartGetir", true, kmtprmtr);
            KartBilgileriEntity mykart = new KartBilgileriEntity();
            while (oku.Read())
            {
                mykart.KartId = Convert.ToInt32(oku["KartId"]);
                mykart.OdaId = Convert.ToInt32(oku["OdaId"]);
                mykart.KartAktifMi = Convert.ToBoolean(oku["KartAktifMi"]);
                mykart.PersonelId = Convert.ToInt32(oku["PersonelId"]);
                mykart.MisafirId = Convert.ToInt32(oku["MisafirId"]);
                mykart.KartVerilisTarihi = Convert.ToDateTime(oku["KartVerilisTarihi"]);
                mykart.KartAlisTarihi = Convert.ToDateTime(oku["KartAlisTarihi"]);
                mykart.KartIslemAciklama =oku["KartIslemAciklama"].ToString();

            }
            oku.Close();
            return mykart;
        }
        #endregion
        #region //Kartlarin Hepsini Getir
        public KartBilgileriEntity getkartlarinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IllerinHepsiniGetir", true, null);
            KartBilgileriEntity kartlar = null;
            while (oku.Read())
            {
                kartlar.KartId = Convert.ToInt32(oku["KartId"]);
                kartlar.OdaId = Convert.ToInt32(oku["OdaId"]);
                kartlar.KartAktifMi = Convert.ToBoolean(oku["KartAktifMi"]);
                kartlar.PersonelId = Convert.ToInt32(oku["PersonelId"]);
                kartlar.MisafirId = Convert.ToInt32(oku["MisafirId"]);
                kartlar.KartVerilisTarihi = Convert.ToDateTime(oku["KartVerilisTarihi"]);
                kartlar.KartAlisTarihi = Convert.ToDateTime(oku["KartAlisTarihi"]);
                kartlar.KartIslemAciklama = oku["KartIslemAciklama"].ToString();
            }
            oku.Close();
            return kartlar;
        }
        #endregion
    }
}
