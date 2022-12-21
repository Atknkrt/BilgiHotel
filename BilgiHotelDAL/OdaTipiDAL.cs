using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdaTipiDAL
    {
        #region // Insert OdaTipi
        public int getInsertOdaTipi(OdaTipiEntity EklenecekOdaTipi)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaTipiAd",
                    Value=EklenecekOdaTipi.OdaTipiAd
                },
                new SqlParameter
                {
                    ParameterName= "OdaTipiAciklama",
                    Value=EklenecekOdaTipi.OdaTipiAciklama
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertOdaTipi", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update OdaTipi
        public int getUpdateOdaTipi(OdaTipiEntity GüncellenecekOdaTipi)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaTipiAd",
                    Value=GüncellenecekOdaTipi.OdaTipiAd
                },
                new SqlParameter
                {
                    ParameterName= "OdaTipiAciklama",
                    Value=GüncellenecekOdaTipi.OdaTipiAciklama
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateOdaTipleri", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre odatipleri Getir
        public OdaTipiEntity getIDyegöregetir(int OdaTipiId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaTipiId",
                    Value=OdaTipiId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGöreOdaTipiGetir", true, kmtprmtr);
            OdaTipiEntity myOdaTipi = new OdaTipiEntity();
            while (oku.Read())
            {
                myOdaTipi.OdaTipiId = Convert.ToInt32(oku["OdaTipiId"]);
                myOdaTipi.OdaTipiAd = oku["OdaTipiAd"].ToString();
                myOdaTipi.OdaTipiAciklama = oku["OdaTipiAciklama"].ToString();
            }
            oku.Close();
            return myOdaTipi;
        }
        #endregion
        #region //odatipleri Hepsini Getir
        public OdaTipiEntity getOdaTipiHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_OdaTipiHepsiniGetir", true, null);
            OdaTipiEntity odatipleri = null;
            while (oku.Read())
            {
                odatipleri.OdaTipiId = Convert.ToInt32(oku["OdaTipiId"]);
                odatipleri.OdaTipiAd = oku["OdaTipiAd"].ToString();
                odatipleri.OdaTipiAciklama = oku["OdaTipiAciklama"].ToString();
            }
            oku.Close();
            return odatipleri;
        }
        #endregion
    }
}
