using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class VardiyalarDAL
    {
        #region // Insert Vardiya
        public int getInsertVardiya(VardiyaEntity EklenecekVardiya)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "VardiyaTipi",
                    Value=EklenecekVardiya.VardiyaTipi
                },
                new SqlParameter
                {
                    ParameterName= "VardiyaBaslangicSaati",
                    Value=EklenecekVardiya.VardiyaBaslangicSaati
                },
                new SqlParameter
                {
                    ParameterName= "VardiyaBitisSaati",
                    Value=EklenecekVardiya.VardiyaBitisSaati
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_vardiyaekle", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Vardiya
        public int getUpdateVardiya(VardiyaEntity güncellenecekVardiya)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "VardiyaId",
                    Value=güncellenecekVardiya.VardiyaId
                },
                new SqlParameter
                {
                    ParameterName= "VardiyaTipi",
                    Value=güncellenecekVardiya.VardiyaTipi
                },
                new SqlParameter
                {
                    ParameterName= "VardiyaBaslangicSaati",
                    Value=güncellenecekVardiya.VardiyaBaslangicSaati
                },
                new SqlParameter
                {
                    ParameterName= "VardiyaBitisSaati",
                    Value=güncellenecekVardiya.VardiyaBitisSaati
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_vardiyagüncelle", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // ID'ye göre vardiya Getir
        public VardiyaEntity getIDyegöregetir(int VardiyaId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "VardiyaId",
                    Value=VardiyaId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IDyegöreVardiyagetir", true, kmtprmtr);
            VardiyaEntity myvardiya = new VardiyaEntity();
            while (oku.Read())
            {
                myvardiya.VardiyaId = Convert.ToInt32(oku["VardiyaId"]);
                myvardiya.VardiyaTipi = oku["VardiyaTipi"].ToString();
                myvardiya.VardiyaBaslangicSaati = Convert.ToDateTime(oku["VardiyaBaslangicSaati"]);
                myvardiya.VardiyaBitisSaati = Convert.ToDateTime(oku["VardiyaBitisSaati"]);
            }
            oku.Close();
            return myvardiya;
        }
        #endregion
        #region //Vardiyalarin Hepsini Getir
        public VardiyaEntity getVardiyalarinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_vardiyalarigetir", true, null);
            VardiyaEntity vardiyalar = null;
            while (oku.Read())
            {
                vardiyalar.VardiyaId = Convert.ToInt32(oku["VardiyaId"]);
                vardiyalar.VardiyaTipi = oku["VardiyaTipi"].ToString();
                vardiyalar.VardiyaBaslangicSaati = Convert.ToDateTime(oku["VardiyaBaslangicSaati"]);
                vardiyalar.VardiyaBitisSaati = Convert.ToDateTime(oku["VardiyaBitisSaati"]);
            }
            oku.Close();
            return vardiyalar;
        }
        #endregion
        #region //Delete Vardiyalar
        public int getVardiyaSil(VardiyaEntity silinecekVardiya)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "VardiyaId",
                    Value=silinecekVardiya.VardiyaId
                }
            };
            int etkilenenSatir = SQL.SqlexecuteNonQuerry("sp_DeleteVardiya", true, kmtprmtr);
            return etkilenenSatir;
        }
        #endregion
    }
}
