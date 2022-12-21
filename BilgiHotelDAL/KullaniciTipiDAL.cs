using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KullaniciTipiDAL
    {
        #region // Insert KullaniciTipi
        public int getInsertKullaniciTipi(KullaniciTipiEntity EklenecekKullaniciTipi)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KullaniciTipiTanim",
                    Value=EklenecekKullaniciTipi.KullaniciTipiTanim
                },
                new SqlParameter
                {
                    ParameterName= "KullaniciTipiAciklama",
                    Value=EklenecekKullaniciTipi.KullaniciTipiAciklama
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertKullaniciTipi", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update KullaniciTipi
        public int getUpdateKullaniciTipi(KullaniciTipiEntity GüncellenecekKullaniciTipi)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KullaniciTipiTanim",
                    Value=GüncellenecekKullaniciTipi.KullaniciTipiTanim
                },
                new SqlParameter
                {
                    ParameterName= "KullaniciTipiAciklama",
                    Value=GüncellenecekKullaniciTipi.KullaniciTipiAciklama
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateKullanicitipi", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre kullanicitipi Getir
        public KullaniciTipiEntity getIDyegöregetir(int KullaniciTipiId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KullaniciTipiId",
                    Value=KullaniciTipiId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGörekullanicitipiGetir", true, kmtprmtr);
            KullaniciTipiEntity mykullanicitipi = new KullaniciTipiEntity();
            while (oku.Read())
            {
                mykullanicitipi.KullaniciTipiId = Convert.ToInt32(oku["KullaniciTipiId"]);
                mykullanicitipi.KullaniciTipiTanim = oku["KullaniciTipiTanim"].ToString();
                mykullanicitipi.KullaniciTipiAciklama = oku["KullaniciTipiAciklama"].ToString();
            }
            oku.Close();
            return mykullanicitipi;
        }
        #endregion
        #region //kullanicitipleri Hepsini Getir
        public KullaniciTipiEntity getkullaniciHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_kullanicitipiHepsiniGetir", true, null);
            KullaniciTipiEntity kullanicitipleri = null;
            while (oku.Read())
            {
                kullanicitipleri.KullaniciTipiId = Convert.ToInt32(oku["KullaniciTipiId"]);
                kullanicitipleri.KullaniciTipiTanim = oku["KullaniciTipiTanim"].ToString();
                kullanicitipleri.KullaniciTipiAciklama = oku["KullaniciTipiAciklama"].ToString();
            }
            oku.Close();
            return kullanicitipleri;
        }
        #endregion
    }
}
