using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class ResimDAL
    {
        #region // Insert resimler
        public int getInsertresimler(ResimEntity Eklenecekresimler)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "ResimUrlAdres",
                    Value=Eklenecekresimler.ResimUrlAdres
                },
                new SqlParameter
                {
                    ParameterName= "ResimAciklama",
                    Value=Eklenecekresimler.ResimAciklama
                },
                new SqlParameter
                {
                    ParameterName= "ResimAktifOk",
                    Value=Eklenecekresimler.ResimAktifOk
                },
                new SqlParameter
                {
                    ParameterName= "ResimAlternatifText",
                    Value=Eklenecekresimler.ResimAlternatifText
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("InsertResimler", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update resimler
        public int getUpdateresimler(ResimEntity Güncellenecekresimler)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "ResimUrlAdres",
                    Value=Güncellenecekresimler.ResimUrlAdres
                },
                new SqlParameter
                {
                    ParameterName= "ResimAciklama",
                    Value=Güncellenecekresimler.ResimAciklama
                },
                new SqlParameter
                {
                    ParameterName= "ResimAktifOk",
                    Value=Güncellenecekresimler.ResimAktifOk
                },
                new SqlParameter
                {
                    ParameterName= "ResimAlternatifText",
                    Value=Güncellenecekresimler.ResimAlternatifText
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_Updateresimleri", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre Resim Getir
        public ResimEntity getIDyegöregetir(int ResimId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "ResimId",
                    Value=ResimId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGöreresimGetir", true, kmtprmtr);
            ResimEntity myresim = new ResimEntity();
            while (oku.Read())
            {
                myresim.ResimId = Convert.ToInt32(oku["ResimId"]);
                myresim.ResimUrlAdres = oku["ResimUrlAdres"].ToString();
                myresim.ResimAciklama = oku["ResimAciklama"].ToString();
                myresim.ResimAktifOk = Convert.ToBoolean(oku["ResimAktifOk"]);
                myresim.ResimAlternatifText = oku["ResimAlternatifText"].ToString();
            }
            oku.Close();
            return myresim;
        }
        #endregion
        #region //resimler Hepsini Getir
        public ResimEntity getresimHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_resimlerHepsiniGetir", true, null);
            ResimEntity resimler = null;
            while (oku.Read())
            {
                resimler.ResimId = Convert.ToInt32(oku["ResimId"]);
                resimler.ResimUrlAdres = oku["ResimUrlAdres"].ToString();
                resimler.ResimAciklama = oku["ResimAciklama"].ToString();
                resimler.ResimAktifOk = Convert.ToBoolean(oku["ResimAktifOk"]);
                resimler.ResimAlternatifText = oku["ResimAlternatifText"].ToString();
            }
            oku.Close();
            return resimler;
        }
        #endregion
    }
}
