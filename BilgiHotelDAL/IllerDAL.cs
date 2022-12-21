using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class IllerDAL
    {
        #region // Insert Iller
        public int getInsertIller(IlEntity EklenecekIl)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "IlAd",
                    Value=EklenecekIl.IlAd
                },
                new SqlParameter
                {
                    ParameterName= "IlAciklama",
                    Value=EklenecekIl.IlAciklama
                },
                new SqlParameter
                {
                    ParameterName= "UlkeId",
                    Value=EklenecekIl.UlkeId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertIl", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Iller
        public int getUpdateIller(IlEntity GüncellenecekIl)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "IlAd",
                    Value=GüncellenecekIl.IlAd
                },
                new SqlParameter
                {
                    ParameterName= "IlAciklama",
                    Value=GüncellenecekIl.IlAciklama
                },
                new SqlParameter
                {
                    ParameterName= "UlkeId",
                    Value=GüncellenecekIl.UlkeId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_güncelleIl", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre Il Getir
        public IlEntity getIDyegöregetir(int IlId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "IlId",
                    Value=IlId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGöreIlGetir", true, kmtprmtr);
            IlEntity myil = new IlEntity();
            while (oku.Read())
            {
                myil.IlId = Convert.ToInt32(oku["IlId"]);
                myil.IlAd = oku["IlAd"].ToString();
                myil.IlAciklama = oku["IlAciklama"].ToString();
                myil.UlkeId = Convert.ToInt32(oku["UlkeId"]);

            }
            oku.Close();
            return myil;
        }
        #endregion
        #region //Illerin Hepsini Getir
        public IlEntity getIllerinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IllerinHepsiniGetir", true, null);
            IlEntity Iller = null;
            while (oku.Read())
            {
                Iller.IlId = Convert.ToInt32(oku["IlId"]);
                Iller.IlAd = oku["IlAd"].ToString();
                Iller.IlAciklama = oku["IlAciklama"].ToString();
                Iller.UlkeId = Convert.ToInt32(oku["UlkeId"]);
            }
            oku.Close();
            return Iller;
        }
        #endregion
    }
}
