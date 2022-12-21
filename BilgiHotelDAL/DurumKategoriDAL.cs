using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class DurumKategoriDAL
    {
        #region // Insert DurumKategoriler
        public int getInsertDurumKategoriler(DurumKategoriEntity EklenecekDurumKategoriler)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "DurumKategoriAd",
                    Value=EklenecekDurumKategoriler.DurumKategoriAd
                },
                new SqlParameter
                {
                    ParameterName= "DurumKategoriAciklama",
                    Value=EklenecekDurumKategoriler.DurumKategoriAciklama
                }
            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertDurumKategori", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update DurumKategoriler
        public int getUpdateDurumKategoriler(DurumKategoriEntity GüncellenecekDurumKategoriler)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "DurumKategoriAd",
                    Value=GüncellenecekDurumKategoriler.DurumKategoriAd
                },
                new SqlParameter
                {
                    ParameterName= "DurumKategoriAciklama",
                    Value=GüncellenecekDurumKategoriler.DurumKategoriAciklama
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateDurumKategori", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre DurumKategori Getir
        public DurumKategoriEntity getIDyegöregetir(int DurumKategoriId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "DurumKategoriId",
                    Value=DurumKategoriId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_ıdyegöredurumkategori", true, kmtprmtr);
            DurumKategoriEntity myDk = new DurumKategoriEntity();
            while (oku.Read())
            {
                myDk.DurumKategoriId = Convert.ToInt32(oku["DurumKategoriId"]);
                myDk.DurumKategoriAd = oku["DurumKategoriAd"].ToString();
                myDk.DurumKategoriAciklama = oku["DurumKategoriAciklama"].ToString();
                

            }
            oku.Close();
            return myDk;
        }
        #endregion
        #region //DurumKategori Hepsini Getir
        public DurumKategoriEntity getDurumKategoriHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_durumkategorihepsinigetir", true, null);
            DurumKategoriEntity Dkler = null;
            while (oku.Read())
            {
                Dkler.DurumKategoriId = Convert.ToInt32(oku["DurumKategoriId"]);
                Dkler.DurumKategoriAd = oku["DurumKategoriAd"].ToString();
                Dkler.DurumKategoriAciklama = oku["DurumKategoriAciklama"].ToString();
            }
            oku.Close();
            return Dkler;
        }
        #endregion
    }
}
