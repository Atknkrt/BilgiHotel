using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class IlcelerDAL
    {
        #region // Insert Ilceler
        public int getInsertIlceler(IlceEntity EklenecekIlce)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "IlceAd",
                    Value=EklenecekIlce.IlceAd
                },
                new SqlParameter
                {
                    ParameterName= "IlceAciklama",
                    Value=EklenecekIlce.IlceAciklama
                },
                new SqlParameter
                {
                    ParameterName= "IlId",
                    Value=EklenecekIlce.IlId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertIlce", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Iller
        public int getUpdateIller(IlceEntity GüncellenecekIlce)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "IlceAd",
                    Value=GüncellenecekIlce.IlceAd
                },
                new SqlParameter
                {
                    ParameterName= "IlceAciklama",
                    Value=GüncellenecekIlce.IlceAciklama
                },
                new SqlParameter
                {
                    ParameterName= "IlId",
                    Value=GüncellenecekIlce.IlId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_güncelleIlce", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre Il Getir
        public IlceEntity getIDyegöregetir(int IlceId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "IlceId",
                    Value=IlceId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGöreIlceGetir", true, kmtprmtr);
            IlceEntity myilce = new IlceEntity();
            while (oku.Read())
            {
                myilce.IlceId = Convert.ToInt32(oku["IlceId"]);
                myilce.IlceAd = oku["IlceAd"].ToString();
                myilce.IlceAciklama = oku["IlceAciklama"].ToString();
                myilce.IlId = Convert.ToInt32(oku["IlId"]);

            }
            oku.Close();
            return myilce;
        }
        #endregion
        #region //Illerin Hepsini Getir
        public IlceEntity getIlcelerinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IlcelerinHepsiniGetir", true, null);
            IlceEntity Ilceler = null;
            while (oku.Read())
            {
                Ilceler.IlceId = Convert.ToInt32(oku["IlceId"]);
                Ilceler.IlceAd = oku["IlceAd"].ToString();
                Ilceler.IlceAciklama = oku["IlceAciklama"].ToString();
                Ilceler.IlId = Convert.ToInt32(oku["IlId"]);
            }
            oku.Close();
            return Ilceler;
        }
        #endregion
    }
}
