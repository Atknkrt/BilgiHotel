using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdaSatisTipDAL
    {
        #region // Insert OdaSatis
        public int getInsertOdaSatis(OdaSatisTipEntity EklenecekOdaSatis)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaSatisTipAd",
                    Value=EklenecekOdaSatis.OdaSatisTipAd
                },
                new SqlParameter
                {
                    ParameterName= "OdaSatisTipAciklama",
                    Value=EklenecekOdaSatis.OdaSatisTipAciklama
                },
                new SqlParameter
                {
                    ParameterName= "OdaSatisTipKatsayi",
                    Value=EklenecekOdaSatis.OdaSatisTipKatsayi
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertOdaSatisTip", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update OdaSatis
        public int getUpdateGörevler(OdaSatisTipEntity GüncellenecekOdaSatis)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaSatisTipAd",
                    Value=GüncellenecekOdaSatis.OdaSatisTipAd
                },
                new SqlParameter
                {
                    ParameterName= "OdaSatisTipAciklama",
                    Value=GüncellenecekOdaSatis.OdaSatisTipAciklama
                },
                new SqlParameter
                {
                    ParameterName= "OdaSatisTipKatsayi",
                    Value=GüncellenecekOdaSatis.OdaSatisTipKatsayi
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateOdaSatis", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre OdaSatis Getir
        public OdaSatisTipEntity getIDyegöregetir(int OdaSatisTip)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaSatisTip",
                    Value=OdaSatisTip
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGöreOdaSatisGetir", true, kmtprmtr);
            OdaSatisTipEntity myOdaSatisTip = new OdaSatisTipEntity();
            while (oku.Read())
            {
                myOdaSatisTip.OdaSatisTip = Convert.ToInt32(oku["OdaSatisTip"]);
                myOdaSatisTip.OdaSatisTipAd = oku["OdaSatisTipAd"].ToString();
                myOdaSatisTip.OdaSatisTipAciklama = oku["OdaSatisTipAciklama"].ToString();
                myOdaSatisTip.OdaSatisTipKatsayi = Convert.ToInt32(oku["OdaSatisTipKatsayi"]);

            }
            oku.Close();
            return myOdaSatisTip;
        }
        #endregion
        #region //OdaSatis Hepsini Getir
        public OdaSatisTipEntity getOdaSatisHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_OdaSatisHepsiniGetir", true, null);
            OdaSatisTipEntity OdaSatislar = null;
            while (oku.Read())
            {
                OdaSatislar.OdaSatisTip = Convert.ToInt32(oku["OdaSatisTip"]);
                OdaSatislar.OdaSatisTipAd = oku["OdaSatisTipAd"].ToString();
                OdaSatislar.OdaSatisTipAciklama = oku["OdaSatisTipAciklama"].ToString();
                OdaSatislar.OdaSatisTipKatsayi = Convert.ToInt32(oku["OdaSatisTipKatsayi"]);
            }
            oku.Close();
            return OdaSatislar;
        }
        #endregion
    }
}
