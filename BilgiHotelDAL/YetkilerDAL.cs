using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class YetkilerDAL
    {
        #region // Insert Yetkiler
        public int getInsertYetkiler(YetkilerEntity EklenecekYetki)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "YetkiAd",
                    Value=EklenecekYetki.YetkiAd
                },
                new SqlParameter
                {
                    ParameterName= "YetkiAciklama",
                    Value=EklenecekYetki.YetkiAciklama
                },
                new SqlParameter
                {
                    ParameterName= "YetkiGüvenlikKod",
                    Value=EklenecekYetki.YetkiGuvenlikKod
                },
                new SqlParameter
                {
                    ParameterName = "YetkiAccesKod",
                    Value = EklenecekYetki.YetkiAccessKod
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertYetki", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Vardiya
        public int getUpdateYetkiler(YetkilerEntity güncellenecekYetki)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "YetkiId",
                    Value=güncellenecekYetki.YetkiId
                },
                new SqlParameter
                {
                    ParameterName= "YetkiAd",
                    Value=güncellenecekYetki.YetkiAd
                },
                new SqlParameter
                {
                    ParameterName= "YetkiAciklama",
                    Value=güncellenecekYetki.YetkiAciklama
                },
                new SqlParameter
                {
                    ParameterName= "YetkiGuvenlikKod",
                    Value=güncellenecekYetki.YetkiGuvenlikKod
                },
                new SqlParameter
                {
                    ParameterName = "YetkiAccessKod",
                    Value = güncellenecekYetki.YetkiAccessKod
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateYetkiler", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre yetki Getir
        public YetkilerEntity getIDyegöregetir(int YetkiId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "YetkiId",
                    Value=YetkiId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IDyeGöreYetkiGetir", true, kmtprmtr);
            YetkilerEntity myyetki = new YetkilerEntity();
            while (oku.Read())
            {
                myyetki.YetkiId = Convert.ToInt32(oku["YetkiId"]);
                myyetki.YetkiAd = oku["YetkiAd"].ToString();
                myyetki.YetkiAciklama = oku["YetkiAciklama"].ToString();
                myyetki.YetkiGuvenlikKod = oku["YetkiGuvenlikKod"].ToString();
                myyetki.YetkiAccessKod = oku["YetkiAccessKod"].ToString();
            }
            oku.Close();
            return myyetki;
        }
        #endregion
        #region //Yetkilerin Hepsini Getir
        public YetkilerEntity getYetkilerinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_bütünYetkileriGetir", true, null);
            YetkilerEntity yetkiler = null;
            while (oku.Read())
            {
                yetkiler.YetkiId = Convert.ToInt32(oku["YetkiId"]);
                yetkiler.YetkiAd = oku["YetkiAd"].ToString();
                yetkiler.YetkiAciklama = oku["YetkiAciklama"].ToString();
                yetkiler.YetkiGuvenlikKod = oku["YetkiGuvenlikKod"].ToString();
                yetkiler.YetkiAccessKod = oku["YetkiAccessKod"].ToString();
            }
            oku.Close();
            return yetkiler;
        }
        #endregion
        #region //Delete Yetkiler
        public int getYetkiSil(YetkilerEntity silinecekYetki)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "YetkiId",
                    Value=silinecekYetki.YetkiId
                }
            };
            int etkilenenSatir = SQL.SqlexecuteNonQuerry("sp_DeleteYetkiler", true, kmtprmtr);
            return etkilenenSatir;
        }
        #endregion
    }
}
