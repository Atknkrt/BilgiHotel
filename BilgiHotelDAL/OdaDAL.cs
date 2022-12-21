using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class OdaDAL
    {
        #region//insert Odalar
        public int getInsertOda(OdalarEntity EklenecekOda, DurumKategoriEntity durumkategori,OdaSatisTipEntity odasatistip)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaTipiId",
                    Value=EklenecekOda.OdaTipiId
                },
                new SqlParameter
                {
                    ParameterName= "OdaFiyat",
                    Value=EklenecekOda.OdaFiyat
                },
                new SqlParameter
                {
                    ParameterName= "OdaYatakTipi",
                    Value=EklenecekOda.OdaYatakTipi
                },
                 new SqlParameter
                {
                    ParameterName= "OdaMiniBarOk",
                    Value=EklenecekOda.OdaMiniBarOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaKlimaOk",
                    Value=EklenecekOda.OdaKlimaOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaKurutmaOk",
                    Value=EklenecekOda.OdaKurutmaOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaWifiOk",
                    Value=EklenecekOda.OdaWifiOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaKasaOk",
                    Value=EklenecekOda.OdaKasaOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaBalkonOk",
                    Value=EklenecekOda.OdaBalkonOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaTvOk",
                    Value=EklenecekOda.OdaTvOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaEbatBoyut",
                    Value=EklenecekOda.OdaEbatBoyut
                },
                 new SqlParameter
                {
                    ParameterName= "OdaNo",
                    Value=EklenecekOda.OdaNo
                },
                 new SqlParameter
                {
                    ParameterName= "OdaKat",
                    Value=EklenecekOda.OdaKat
                },
                 new SqlParameter
                {
                    ParameterName= "OdaKisiSayisi",
                    Value=EklenecekOda.OdaKisiSayisi
                },
                 new SqlParameter
                {
                    ParameterName= "DurumKategoriId",
                    Value=durumkategori.DurumKategoriId
                }, new SqlParameter
                {
                    ParameterName= "OdaSatisTip",
                    Value=odasatistip.OdaSatisTip
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_odaekle", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Odalar
        public int getUpdateOda(OdalarEntity DüzenelenecekOdalar)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaId",
                    Value=DüzenelenecekOdalar.OdaId
                },
                new SqlParameter
                {
                    ParameterName= "OdaTipiId",
                    Value=DüzenelenecekOdalar.OdaTipiId
                },
                new SqlParameter
                {
                    ParameterName= "OdaFiyat",
                    Value=DüzenelenecekOdalar.OdaFiyat
                },
                new SqlParameter
                {
                    ParameterName= "OdaYatakTipi",
                    Value=DüzenelenecekOdalar.OdaYatakTipi
                },
                 new SqlParameter
                {
                    ParameterName= "OdaMiniBarOk",
                    Value=DüzenelenecekOdalar.OdaMiniBarOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaKlimaOk",
                    Value=DüzenelenecekOdalar.OdaKlimaOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaKurutmaOk",
                    Value=DüzenelenecekOdalar.OdaKurutmaOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaWifiOk",
                    Value=DüzenelenecekOdalar.OdaWifiOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaKasaOk",
                    Value=DüzenelenecekOdalar.OdaKasaOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaBalkonOk",
                    Value=DüzenelenecekOdalar.OdaBalkonOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaTvOk",
                    Value=DüzenelenecekOdalar.OdaTvOk
                },
                 new SqlParameter
                {
                    ParameterName= "OdaEbatBoyut",
                    Value=DüzenelenecekOdalar.OdaEbatBoyut
                },
                 new SqlParameter
                {
                    ParameterName= "OdaNo",
                    Value=DüzenelenecekOdalar.OdaNo
                },
                 new SqlParameter
                {
                    ParameterName= "OdaKat",
                    Value=DüzenelenecekOdalar.OdaKat
                },
                 new SqlParameter
                {
                    ParameterName= "OdaKisiSayisi",
                    Value=DüzenelenecekOdalar.OdaKisiSayisi
                }

            };
            int deger = SQL.SqlexecuteNonQuerry("sp_güncelleOdalar", true, kmtprmtr);
            return deger; 
        }
        #endregion
        #region //ODANo'ya Göre Oda Getir
        public OdalarEntity getODANoyaGöreOdaGetir(int OdaId)
        {
            
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaId",
                    Value=OdaId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_OdaNoyaGöreOdaGetir", true, kmtprmtr);
            OdalarEntity myoda = new OdalarEntity();
            OdaTipiEntity myod = new OdaTipiEntity();
            while (oku.Read())
            {
                myoda.OdaId = Convert.ToInt32(oku["OdaId"]);
                myoda.OdaTipiId = Convert.ToInt32(oku["OdaTipiId"]);
                myoda.OdaFiyat = Convert.ToDecimal(oku["OdaFiyat"]);
                myoda.OdaYatakTipi = oku["OdaYatakTipi"].ToString();
                myoda.OdaMiniBarOk = Convert.ToBoolean(oku["OdaMiniBarOk"]);
                myoda.OdaKlimaOk = Convert.ToBoolean(oku["OdaKlimaOk"]);
                myoda.OdaKurutmaOk = Convert.ToBoolean(oku["OdaKurutmaOk"]);
                myoda.OdaWifiOk = Convert.ToBoolean(oku["OdaWifiOk"]);
                myoda.OdaKasaOk = Convert.ToBoolean(oku["OdaKasaOk"]);
                myoda.OdaBalkonOk = Convert.ToBoolean(oku["OdaBalkonOk"]);
                myoda.OdaTvOk = Convert.ToBoolean(oku["OdaTvOk"]);
                myoda.OdaAciklama = oku["OdaAciklama"].ToString();
                myoda.OdaEbatBoyut = oku["OdaEbatBoyut"].ToString();
                myoda.OdaNo = oku["OdaNo"].ToString();
                myoda.OdaKat = oku["OdaKat"].ToString();
                myoda.OdaKisiSayisi = Convert.ToInt32(oku["OdaKisiSayisi"]);
            }
            oku.Close();
            return myoda;
        }
        #endregion
        #region //Odalar Hepsini Getir
        public OdalarEntity getOdalarHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_OdaNoyaGöreHepsiniGetir", true, null);
            OdalarEntity Odalar = null;
            while (oku.Read())
            {
                Odalar.OdaId = Convert.ToInt32(oku["OdaId"]);
                Odalar.OdaTipiId = Convert.ToInt32(oku["OdaTipiId"]);
                Odalar.OdaFiyat = Convert.ToDecimal(oku["OdaFiyat"]);
                Odalar.OdaYatakTipi = oku["OdaYatakTipi"].ToString();
                Odalar.OdaMiniBarOk = Convert.ToBoolean(oku["OdaMiniBarOk"]);
                Odalar.OdaKlimaOk = Convert.ToBoolean(oku["OdaKlimaOk"]);
                Odalar.OdaKurutmaOk = Convert.ToBoolean(oku["OdaKurutmaOk"]);
                Odalar.OdaWifiOk = Convert.ToBoolean(oku["OdaWifiOk"]);
                Odalar.OdaKasaOk = Convert.ToBoolean(oku["OdaKasaOk"]);
                Odalar.OdaBalkonOk = Convert.ToBoolean(oku["OdaBalkonOk"]);
                Odalar.OdaTvOk = Convert.ToBoolean(oku["OdaTvOk"]);
                Odalar.OdaAciklama = oku["OdaAciklama"].ToString();
                Odalar.OdaEbatBoyut = oku["OdaEbatBoyut"].ToString();
                Odalar.OdaNo = oku["OdaNo"].ToString();
                Odalar.OdaKat = oku["OdaKat"].ToString();
                Odalar.OdaKisiSayisi = Convert.ToInt32(oku["OdaKisiSayisi"]);
            }
            return Odalar;
        }
        #endregion
        #region //Odalar Delete
        public int getOdaSil(OdalarEntity silinecekOda)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "OdaNo",
                    Value=silinecekOda.OdaNo
                }
            };
            int etkilenenSatir = SQL.SqlexecuteNonQuerry("sp_DeleteOdalar", true, kmtprmtr);
            return etkilenenSatir;
        }
        #endregion


    }
}
