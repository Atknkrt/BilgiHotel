using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class GörevDAL
    {
        #region // Insert Görevler
        public int getInsertGörevler(GörevlerEntity EklenecekGörevler)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "GorevAd",
                    Value=EklenecekGörevler.GorevAd
                },
                new SqlParameter
                {
                    ParameterName= "GorevAciklama",
                    Value=EklenecekGörevler.GorevAciklama
                },
                new SqlParameter
                {
                    ParameterName= "GorevIsTanimi",
                    Value=EklenecekGörevler.GorevIsTanimi
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertGorevler", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Görevler
        public int getUpdateGörevler(GörevlerEntity GüncellenecekGörevler)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "GorevAd",
                    Value=GüncellenecekGörevler.GorevAd
                },
                new SqlParameter
                {
                    ParameterName= "GorevAciklama",
                    Value=GüncellenecekGörevler.GorevAciklama
                },
                new SqlParameter
                {
                    ParameterName= "GorevIsTanimi",
                    Value=GüncellenecekGörevler.GorevIsTanimi
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateGorevler", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre Gorev Getir
        public GörevlerEntity getIDyegöregetir(int GorevId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "GorevId",
                    Value=GorevId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_ıdyegöregörevgetir", true, kmtprmtr);
            GörevlerEntity myGörev = new GörevlerEntity();
            while (oku.Read())
            {
                myGörev.GorevId = Convert.ToInt32(oku["GorevId"]);
                myGörev.GorevAd = oku["GorevAd"].ToString();
                myGörev.GorevAciklama = oku["GorevAciklama"].ToString();
                myGörev.GorevIsTanimi = oku["GorevIsTanimi"].ToString();

            }
            oku.Close();
            return myGörev;
        }
        #endregion
        #region //Gorevlerin Hepsini Getir
        public GörevlerEntity getGorevlerinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_görevlerhepsinigetir", true, null);
            GörevlerEntity görevler = null;
            while (oku.Read())
            {
                görevler.GorevId = Convert.ToInt32(oku["GorevId"]);
                görevler.GorevAd = oku["GorevAd"].ToString();
                görevler.GorevAciklama = oku["GorevAciklama"].ToString();
                görevler.GorevIsTanimi = oku["GorevIsTanimi"].ToString();
            }
            oku.Close();
            return görevler;
        }
        #endregion
    }
}
