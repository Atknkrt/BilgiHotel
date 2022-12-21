using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class UlkelerDAL
    {
        #region // Insert Ulkeler
        public int getInsertUlkeler(UlkeEntity EklenecekUlke)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "UlkeAd",
                    Value=EklenecekUlke.UlkeAd
                },
                new SqlParameter
                {
                    ParameterName= "UlkeKisaKod",
                    Value=EklenecekUlke.UlkeKisaKod
                },
                new SqlParameter
                {
                    ParameterName= "UlkeTelefonKod",
                    Value=EklenecekUlke.UlkeTelefonKod
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertUlke", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Ulkeler
        public int getUpdateUlkeler(UlkeEntity GüncellenecekUlke)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "UlkeAd",
                    Value=GüncellenecekUlke.UlkeAd
                },
                new SqlParameter
                {
                    ParameterName= "UlkeKisaKod",
                    Value=GüncellenecekUlke.UlkeKisaKod
                },
                new SqlParameter
                {
                    ParameterName= "UlkeTelefonKod",
                    Value=GüncellenecekUlke.UlkeTelefonKod
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_güncelleUlke", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre Ulke Getir
        public UlkeEntity getIDyegöregetir(int UlkeId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "UlkeId",
                    Value=UlkeId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGöreUlkeGetir", true, kmtprmtr);
            UlkeEntity myülke = new UlkeEntity();
            while (oku.Read())
            {
                myülke.UlkeId = Convert.ToInt32(oku["UlkeId"]);
                myülke.UlkeAd = oku["UlkeAd"].ToString();
                myülke.UlkeKisaKod = oku["UlkeKisaKod"].ToString();
                myülke.UlkeTelefonKod = oku["UlkeTelefonKod"].ToString();
         
            }
            oku.Close();
            return myülke;
        }
        #endregion
        #region //Ulkelrin Hepsini Getir
        public UlkeEntity getUlkelerinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_UlkelerinHepsinigetir", true, null);
            UlkeEntity Ulkeler = null;
            while (oku.Read())
            {
                Ulkeler.UlkeId = Convert.ToInt32(oku["UlkeId"]);
                Ulkeler.UlkeAd = oku["UlkeAd"].ToString();
                Ulkeler.UlkeKisaKod = oku["UlkeKisaKod"].ToString();
                Ulkeler.UlkeTelefonKod = oku["UlkeTelefonKod"].ToString();
            }
            oku.Close();
            return Ulkeler;
        }
        #endregion
    }
}
