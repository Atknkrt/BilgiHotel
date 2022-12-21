using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class RezervasyonTipDAL
    {
        #region // Insert RezervasyonTipi
        public int getInsertRezervasyonTipi(RezervasyonTipEntity EklenecekRezervasyonTipi)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "RezervasyonTanım",
                    Value=EklenecekRezervasyonTipi.RezervasyonTanım
                },
                new SqlParameter
                {
                    ParameterName= "RezervasyonAciklama",
                    Value=EklenecekRezervasyonTipi.RezervasyonAciklama
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertRezervasyonTip", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update RezervasyonTipi
        public int getUpdateRezervasyonTipi(RezervasyonTipEntity GüncellenecekRezervasyonTipi)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "RezervasyonTanım",
                    Value=GüncellenecekRezervasyonTipi.RezervasyonTanım
                },
                new SqlParameter
                {
                    ParameterName= "RezervasyonAciklama",
                    Value=GüncellenecekRezervasyonTipi.RezervasyonAciklama
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateRezervasyonTipi", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre RezervasyonTip Getir
        public RezervasyonTipEntity getIDyegöregetir(int RezervasyonTipId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "RezervasyonTipId",
                    Value=RezervasyonTipId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGörereztipGetir", true, kmtprmtr);
            RezervasyonTipEntity myRezervasyonTip = new RezervasyonTipEntity();
            while (oku.Read())
            {
                myRezervasyonTip.RezervasyonTipId = Convert.ToInt32(oku["RezervasyonTipId"]);
                myRezervasyonTip.RezervasyonTanım = oku["RezervasyonTanım"].ToString();
                myRezervasyonTip.RezervasyonAciklama = oku["RezervasyonAciklama"].ToString();
            }
            oku.Close();
            return myRezervasyonTip;
        }
        #endregion
        #region //RezervasyonTip Hepsini Getir
        public RezervasyonTipEntity getRezervasyonTipHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_RezervasyonTipHepsiniGetir", true, null);
            RezervasyonTipEntity reztipleri = null;
            while (oku.Read())
            {
                reztipleri.RezervasyonTipId = Convert.ToInt32(oku["RezervasyonTipId"]);
                reztipleri.RezervasyonTanım = oku["RezervasyonTanım"].ToString();
                reztipleri.RezervasyonAciklama = oku["RezervasyonAciklama"].ToString();
            }
            oku.Close();
            return reztipleri;
        }
        #endregion
    }
}
