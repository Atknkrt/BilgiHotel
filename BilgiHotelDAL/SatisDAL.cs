using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class SatisDAL
    {
        #region//insert Satis ve Satis-Personel tablolarina
        public object getInsertSatis(SatisEntity EklenecekSatis, PersonellerEntity personel)
        {
            SqlParameter[] kmtprmtr =
            {
                
                new SqlParameter
                {
                    ParameterName= "SatisOdaGirisTarihi",
                    Value=EklenecekSatis.SatisOdaGirisTarihi
                },
                new SqlParameter
                {
                    ParameterName= "SatisOdaCikisTarihi",
                    Value=EklenecekSatis.SatisOdaCikisTarihi
                },
                new SqlParameter
                {
                    ParameterName= "SatisIndirim",
                    Value=EklenecekSatis.SatisIndirim
                },
                 new SqlParameter
                {
                    ParameterName= "KartId",
                    Value=EklenecekSatis.KartId
                },
                 new SqlParameter
                {
                    ParameterName= "OdaId",
                    Value=EklenecekSatis.OdaId
                },
                 new SqlParameter
                {
                    ParameterName= "OdaSatisDurum",
                    Value=EklenecekSatis.OdaSatisDurum
                },
                 new SqlParameter
                {
                    ParameterName= "OdaSatisTutar",
                    Value=EklenecekSatis.OdaSatisTutar
                },
                 new SqlParameter
                {
                    ParameterName= "OdaSatisTip",
                    Value=EklenecekSatis.OdaSatisTip
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelId",
                    Value=personel.PersonelId
                }

            };

            object deger = SQL.SqlexecuteScalar("sp_InsertSatis", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//insert Müsteri-Satis tablosuna
        public int getInsertMüsteriSatis(MüsterilerEntity müsteri, MisafirlerEntity misafir, SatisEntity satis, OdalarEntity oda)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "MusteriID",
                    Value=müsteri.MusteriID
                },
                new SqlParameter
                {
                    ParameterName= "MisafirId",
                    Value=misafir.MisafirId
                },
                new SqlParameter
                {
                    ParameterName= "SatisId",
                    Value=satis.SatisId
                },
                 new SqlParameter
                {
                    ParameterName= "OdaId",
                    Value=oda.OdaId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertMüsteriMisafirSatis", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Satis
        public int getUpdateSatis(SatisEntity DüzenelenecekSatis)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "SatisOdaGirisTarihi",
                    Value=DüzenelenecekSatis.SatisOdaGirisTarihi
                },
                new SqlParameter
                {
                    ParameterName= "SatisOdaCikisTarihi",
                    Value=DüzenelenecekSatis.SatisOdaCikisTarihi
                },
                new SqlParameter
                {
                    ParameterName= "SatisIndirim",
                    Value=DüzenelenecekSatis.SatisIndirim
                },
                 new SqlParameter
                {
                    ParameterName= "KartId",
                    Value=DüzenelenecekSatis.KartId
                },
                 new SqlParameter
                {
                    ParameterName= "OdaId",
                    Value=DüzenelenecekSatis.OdaId
                },
                 new SqlParameter
                {
                    ParameterName= "OdaSatisDurum",
                    Value=DüzenelenecekSatis.OdaSatisDurum
                },
                 new SqlParameter
                {
                    ParameterName= "OdaSatisTip",
                    Value=DüzenelenecekSatis.OdaSatisTip
                },
                 new SqlParameter
                {
                    ParameterName= "OdaSatisTutar",
                    Value=DüzenelenecekSatis.OdaSatisTutar
                }

            };
            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateSatis", true, kmtprmtr);
            return deger;
        }
        #endregion
        #region //Id'ye Göre Satis Getir
        public SatisEntity getTCyeGöreSatisGetir(int SatisId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "SatisId ",
                    Value=SatisId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGöreSatisGetir", true, kmtprmtr);
            SatisEntity mysatis = new SatisEntity();
            while (oku.Read())
            {
                mysatis.SatisId = Convert.ToInt32(oku["SatisId"]);
                mysatis.SatisOdaGirisTarihi = Convert.ToDateTime(oku["SatisOdaGirisTarihi"]);
                mysatis.SatisOdaCikisTarihi = Convert.ToDateTime(oku["SatisOdaCikisTarihi"]);
                mysatis.SatisIndirim = Convert.ToInt32(oku["SatisIndirim"]);
                mysatis.KartId = Convert.ToInt32(oku["KartId"]);
                mysatis.OdaId = Convert.ToInt32(oku["OdaId"]);
                mysatis.OdaSatisDurum = Convert.ToBoolean(oku["OdaSatisDurum"]);
                mysatis.OdaSatisTip = Convert.ToInt32(oku["OdaSatisTip"]); ;
                mysatis.OdaSatisTutar = Convert.ToDecimal(oku["OdaSatisTutar"]);
                
            }
            oku.Close();
            return mysatis;
        }
        #endregion
        #region //Satislarin Hepsini Getir
        public SatisEntity getSatislarinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_SatislarinHepsiniGetir", true, null);
            SatisEntity satislar = null;
            while (oku.Read())
            {
                satislar.SatisId = Convert.ToInt32(oku["SatisId"]);
                satislar.SatisOdaGirisTarihi = Convert.ToDateTime(oku["SatisOdaGirisTarihi"]);
                satislar.SatisOdaCikisTarihi = Convert.ToDateTime(oku["SatisOdaCikisTarihi"]);
                satislar.SatisIndirim = Convert.ToInt32(oku["SatisIndirim"]);
                satislar.KartId = Convert.ToInt32(oku["KartId"]);
                satislar.OdaId = Convert.ToInt32(oku["OdaId"]);
                satislar.OdaSatisDurum = Convert.ToBoolean(oku["OdaSatisDurum"]);
                satislar.OdaSatisTip = Convert.ToInt32(oku["OdaSatisTip"]); ;
                satislar.OdaSatisTutar = Convert.ToDecimal(oku["OdaSatisTutar"]);
            }
            return satislar;
        }
        #endregion
        #region //Delete Satis
        public int getSatisSil(SatisEntity silinecekSatis)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "SatisId",
                    Value=silinecekSatis.SatisId
                }
            };
            int etkilenenSatir = SQL.SqlexecuteNonQuerry("sp_DeleteSatis", true, kmtprmtr);
            return etkilenenSatir;
        }
        #endregion
    }
}
