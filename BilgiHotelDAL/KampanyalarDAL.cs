using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KampanyalarDAL
    {
        #region // Insert Kampanya
        public int getInsertKampanya(KampanyalarEntity EklenecekKampanya)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KampanyaBilgileri",
                    Value=EklenecekKampanya.KampanyaBilgileri
                },
                new SqlParameter
                {
                    ParameterName= "KampanyaIndirimOran",
                    Value=EklenecekKampanya.KampanyaIndirimOran
                },
                new SqlParameter
                {
                    ParameterName= "KampanyaBaslangicZaman",
                    Value=EklenecekKampanya.KampanyaBaslangicZaman
                },
                 new SqlParameter
                {
                    ParameterName= "KampanyaBitisTarihi",
                    Value=EklenecekKampanya.KampanyaBitisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "KampanyaTanim",
                    Value=EklenecekKampanya.KampanyaTanim
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_kampanyaekle", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // Update Kampanyalar
        public int getUpdateKampanya(KampanyalarEntity GüncellenecekKampanya)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KampanyaBilgileri",
                    Value=GüncellenecekKampanya.KampanyaBilgileri
                },
                new SqlParameter
                {
                    ParameterName= "KampanyaIndirimOran",
                    Value=GüncellenecekKampanya.KampanyaIndirimOran
                },
                new SqlParameter
                {
                    ParameterName= "KampanyaBaslangicZaman",
                    Value=GüncellenecekKampanya.KampanyaBaslangicZaman
                },
                 new SqlParameter
                {
                    ParameterName= "KampanyaBitisTarihi",
                    Value=GüncellenecekKampanya.KampanyaBitisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "KampanyaTanim",
                    Value=GüncellenecekKampanya.KampanyaTanim
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateKampanyalar", true, kmtprmtr);

            return deger;
        }
        #endregion
        #region // İki Tarih Aralığına Göre  Listele
        #endregion
        #region //Kampanyaların Hepsini Getir
        public KampanyalarEntity getKampanyalarinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_kampanyalarigetir", true, null);
            KampanyalarEntity kampanyalar = null;
            while (oku.Read())
            {
                kampanyalar.KampanyaId = Convert.ToInt32(oku["KampanyaId"]);
                kampanyalar.KampanyaBilgileri = oku["KampanyaBilgileri"].ToString();
                kampanyalar.KampanyaIndirimOran = Convert.ToInt32(oku["KampanyaIndirimOran"]);
                kampanyalar.KampanyaBaslangicZaman = Convert.ToDateTime(oku["KampanyaBaslangicZaman"]);
                kampanyalar.KampanyaBitisTarihi = Convert.ToDateTime(oku["KampanyaBitisTarihi"]);
                kampanyalar.KampanyaTanim = oku["KampanyaTanim"].ToString();
                
            }
            oku.Close();
            return kampanyalar;
        }
        #endregion
        #region //Delete Kampanya
        public int getKampanyaSil(KampanyalarEntity silinecekKampanya)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KampanyaId",
                    Value=silinecekKampanya.KampanyaId
                }
            };
            int etkilenenSatir = SQL.SqlexecuteNonQuerry("sp_DeleteMisafirler", true, kmtprmtr);
            return etkilenenSatir;
        }
        #endregion
    }
}
