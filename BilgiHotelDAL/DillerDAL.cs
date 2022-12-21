using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class DillerDAL
    {
        #region // Insert Diller
        public int getInsertDiller(DillerEntity EklenecekDil)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "DilAd",
                    Value=EklenecekDil.DilAd
                },
                new SqlParameter
                {
                    ParameterName= "DilAciklama",
                    Value=EklenecekDil.DilAciklama
                },
                new SqlParameter
                {
                    ParameterName= "DilKod",
                    Value=EklenecekDil.DilKod
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertDiller", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Diller
        public int getUpdateDiller(DillerEntity GüncellenecekDil)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "DilAd",
                    Value=GüncellenecekDil.DilAd
                },
                new SqlParameter
                {
                    ParameterName= "DilAciklama",
                    Value=GüncellenecekDil.DilAciklama
                },
                new SqlParameter
                {
                    ParameterName= "DilKod",
                    Value=GüncellenecekDil.DilKod
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_güncelleDil", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre Il Getir
        public DillerEntity getIDyegöregetir(int DilId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "DilId",
                    Value=DilId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGöreDilGetir", true, kmtprmtr);
            DillerEntity myDil = new DillerEntity();
            while (oku.Read())
            {
                myDil.DilId = Convert.ToInt32(oku["DilId"]);
                myDil.DilAd = oku["DilAd"].ToString();
                myDil.DilAciklama = oku["DilAciklama"].ToString();
                myDil.DilKod = oku["DilKod"].ToString();

            }
            oku.Close();
            return myDil;
        }
        #endregion
        #region //Dillerin Hepsini Getir
        public DillerEntity getDillerinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_DilerinHepsiniGetir", true, null);
            DillerEntity Diller = null;
            while (oku.Read())
            {
                Diller.DilId = Convert.ToInt32(oku["DilId"]);
                Diller.DilAd = oku["DilAd"].ToString();
                Diller.DilAciklama = oku["DilAciklama"].ToString();
                Diller.DilKod = oku["DilKod"].ToString();
            }
            oku.Close();
            return Diller;
        }
        #endregion
    }
}
