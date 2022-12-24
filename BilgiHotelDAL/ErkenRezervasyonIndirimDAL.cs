using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class ErkenRezervasyonIndirimDAL
    {
        #region // Insert ErkenRezervasyon
        public int getInsertErkenRezervasyon(ErkenRezervasyonIndirimEntity EklenecekErkenRezervasyon,RezervasyonTipEntity eklenecekreztip)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "ErkenRezervasyonGünSayisi",
                    Value=EklenecekErkenRezervasyon.ErkenRezervasyonGünSayisi
                },
                new SqlParameter
                {
                    ParameterName= "ErkenRezervasyonIndirimOrani",
                    Value=EklenecekErkenRezervasyon.ErkenRezervasyonIndirimOrani
                },
                new SqlParameter
                {
                    ParameterName= "ErkenRezervasyon",
                    Value=EklenecekErkenRezervasyon.ErkenRezervasyon
                },
                 new SqlParameter
                {
                    ParameterName= "ErkenRezervasyonAktifMi",
                    Value=EklenecekErkenRezervasyon.ErkenRezervasyonAktifMi
                },
                 new SqlParameter
                {
                    ParameterName= "RezervasyonTipId",
                    Value=eklenecekreztip.RezervasyonTipId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_ErkenRezervasyonIndirimiEkle", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // Update ErkenRezervasyon
        public int getUpdateErkenRezervasyon(ErkenRezervasyonIndirimEntity GüncellenecekErkenRezervasyon)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "ErkenRezervasyonId",
                    Value=GüncellenecekErkenRezervasyon.ErkenRezervasyonId
                },
                new SqlParameter
                {
                    ParameterName= "ErkenRezervasyonGünSayisi",
                    Value=GüncellenecekErkenRezervasyon.ErkenRezervasyonGünSayisi
                },
                new SqlParameter
                {
                    ParameterName= "ErkenRezervasyonIndirimOrani",
                    Value=GüncellenecekErkenRezervasyon.ErkenRezervasyonIndirimOrani
                },
                new SqlParameter
                {
                    ParameterName= "ErkenRezervasyon",
                    Value=GüncellenecekErkenRezervasyon.ErkenRezervasyon
                },
                 new SqlParameter
                {
                    ParameterName= "ErkenRezervasyonAktifMi",
                    Value=GüncellenecekErkenRezervasyon.ErkenRezervasyonAktifMi
                }
            };

            int deger = SQL.SqlexecuteNonQuerry("sp_ErkenRezervasyonGüncelle", true, kmtprmtr);

            return deger;
        }
        #endregion
        #region // İki Tarih Aralığına Göre  Listele
        #endregion
        #region //Erken Rezervasyon Hepsini Getir
        public ErkenRezervasyonIndirimEntity getErkenRezervasyonlarinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_erkenrezhepsinigetir", true, null);
            ErkenRezervasyonIndirimEntity erkenRezervasyonIndirimEntity = null;
            while (oku.Read())
            {
               erkenRezervasyonIndirimEntity.ErkenRezervasyonId = Convert.ToInt32(oku["ErkenRezervasyonId"]);
               erkenRezervasyonIndirimEntity.ErkenRezervasyonGünSayisi = Convert.ToInt32(oku["ErkenRezervasyonGünSayisi"]);
               erkenRezervasyonIndirimEntity.ErkenRezervasyonIndirimOrani = Convert.ToInt32(oku["ErkenRezervasyonIndirimOrani"]);
               erkenRezervasyonIndirimEntity.ErkenRezervasyon = oku["ErkenRezervasyon"].ToString();
               erkenRezervasyonIndirimEntity.ErkenRezervasyonAktifMi = Convert.ToBoolean(oku["ErkenRezervasyonAktifMi"]);
                

            }
            oku.Close();
            return erkenRezervasyonIndirimEntity;
        }
        #endregion
        
    }
}
