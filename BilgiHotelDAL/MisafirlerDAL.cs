using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MisafirlerDAL
    {
        #region // Insert Misafirler
        public int getInsertMisafir(MisafirlerEntity EklenecekMisafir,PersonellerEntity personel)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "MisafirAd",
                    Value=EklenecekMisafir.MisafirAd
                },
                new SqlParameter
                {
                    ParameterName= "MisafirSoyad",
                    Value=EklenecekMisafir.MisafirSoyad
                },
                new SqlParameter
                {
                    ParameterName= "MisafirTcKimlik",
                    Value=EklenecekMisafir.MisafirTcKimlik
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirDogumTarihi",
                    Value=EklenecekMisafir.MisafirDogumTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirUyrukId",
                    Value=EklenecekMisafir.MisafirUyrukId
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirEposta",
                    Value=EklenecekMisafir.MisafirEposta
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirTelefon",
                    Value=EklenecekMisafir.MisafirTelefon
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirPasaportNo",
                    Value=EklenecekMisafir.MisafirPasaportNo
                },
                 new SqlParameter
                {
                    ParameterName= "CinsiyetId",
                    Value=EklenecekMisafir.CinsiyetId
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirAdres",
                    Value=EklenecekMisafir.MisafirAdres
                },
                 new SqlParameter
                {
                    ParameterName= "IlID",
                    Value=EklenecekMisafir.IlID
                },
                 new SqlParameter
                {
                    ParameterName= "IlceID",
                    Value=EklenecekMisafir.IlceID
                },
                 new SqlParameter
                {
                    ParameterName= "UlkeID",
                    Value=EklenecekMisafir.UlkeID
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirAciklama",
                    Value=EklenecekMisafir.MisafirAciklama
                },
                   new SqlParameter
                {
                    ParameterName= "DilID",
                    Value=EklenecekMisafir.DilID
                },
                   new SqlParameter
                {
                    ParameterName= "PersonelId",
                    Value=personel.PersonelId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_misafirekle", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // Update Misafirler
        public int getUpdateMisafir(MisafirlerEntity GüncellenecekMisafir)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "MisafirAd",
                    Value=GüncellenecekMisafir.MisafirAd
                },
                new SqlParameter
                {
                    ParameterName= "MisafirSoyad",
                    Value=GüncellenecekMisafir.MisafirSoyad
                },
                new SqlParameter
                {
                    ParameterName= "MisafirTcKimlik",
                    Value=GüncellenecekMisafir.MisafirTcKimlik
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirDogumTarihi",
                    Value=GüncellenecekMisafir.MisafirDogumTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirUyrukId",
                    Value=GüncellenecekMisafir.MisafirUyrukId
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirEposta",
                    Value=GüncellenecekMisafir.MisafirEposta
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirTelefon",
                    Value=GüncellenecekMisafir.MisafirTelefon
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirPasaportNo",
                    Value=GüncellenecekMisafir.MisafirPasaportNo
                },
                 new SqlParameter
                {
                    ParameterName= "CinsiyetId",
                    Value=GüncellenecekMisafir.CinsiyetId
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirAdres",
                    Value=GüncellenecekMisafir.MisafirAdres
                },
                 new SqlParameter
                {
                    ParameterName= "IlID",
                    Value=GüncellenecekMisafir.IlID
                },
                 new SqlParameter
                {
                    ParameterName= "IlceID",
                    Value=GüncellenecekMisafir.IlceID
                },
                 new SqlParameter
                {
                    ParameterName= "UlkeID",
                    Value=GüncellenecekMisafir.UlkeID
                },
                 new SqlParameter
                {
                    ParameterName= "MisafirAciklama",
                    Value=GüncellenecekMisafir.MisafirAciklama
                },
                   new SqlParameter
                {
                    ParameterName= "DilID",
                    Value=GüncellenecekMisafir.DilID
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_misafirgüncelle", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region //TC'ye Göre Misafir Getir
        public MisafirlerEntity getTCyeGöreMisafirGetir(string MisafirTcKimlik)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "MisafirTcKimlik",
                    Value=MisafirTcKimlik
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_tcyegöremisafirgetir", true, kmtprmtr);
            MisafirlerEntity mymisafir = new MisafirlerEntity();
            while (oku.Read())
            {
                mymisafir.MisafirId = Convert.ToInt32(oku["MisafirId"]);
                mymisafir.MisafirAd = oku["MisafirAd"].ToString();
                mymisafir.MisafirSoyad = oku["MisafirSoyad"].ToString();
                mymisafir.MisafirTcKimlik = oku["MisafirTcKimlik"].ToString();
                mymisafir.MisafirDogumTarihi = Convert.ToDateTime(oku["MisafirDogumTarihi"]);
                mymisafir.MisafirUyrukId = Convert.ToInt32(oku["MisafirUyrukId"]);
                mymisafir.MisafirEposta = oku["MisafirEposta"].ToString();
                mymisafir.MisafirTelefon = oku["MisafirTelefon"].ToString();
                mymisafir.MisafirPasaportNo = oku["MisafirPasaportNo"].ToString();
                mymisafir.CinsiyetId = Convert.ToInt32(oku["CinsiyetId"]);
                mymisafir.MisafirAdres = oku["MisafirAdres"].ToString();
                mymisafir.IlID = Convert.ToInt32(oku["IlID"]);
                mymisafir.IlceID = Convert.ToInt32(oku["IlceID"]);
                mymisafir.UlkeID = Convert.ToInt32(oku["UlkeID"]);
                mymisafir.MisafirAciklama = oku["MisafirAciklama"].ToString();
                mymisafir.DilID = Convert.ToInt32(oku["DilID"]);
            }
            oku.Close();
            return mymisafir;
        }
        #endregion
        #region //Misafirlerin Hepsini Getir
        public MisafirlerEntity getMisafirlerinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_misafirlerigetir", true, null);
            MisafirlerEntity misafirler = null;
            while (oku.Read())
            {
                misafirler.MisafirId = Convert.ToInt32(oku["MisafirId"]);
                misafirler.MisafirAd = oku["MisafirAd"].ToString();
                misafirler.MisafirSoyad = oku["MisafirSoyad"].ToString();
                misafirler.MisafirTcKimlik = oku["MisafirTcKimlik"].ToString();
                misafirler.MisafirDogumTarihi = Convert.ToDateTime(oku["MisafirDogumTarihi"]);
                misafirler.MisafirUyrukId = Convert.ToInt32(oku["MisafirUyrukId"]);
                misafirler.MisafirEposta = oku["MisafirEposta"].ToString();
                misafirler.MisafirTelefon = oku["MisafirTelefon"].ToString();
                misafirler.MisafirPasaportNo = oku["MisafirPasaportNo"].ToString();
                misafirler.CinsiyetId = Convert.ToInt32(oku["CinsiyetId"]);
                misafirler.MisafirAdres = oku["MisafirAdres"].ToString();
                misafirler.IlID = Convert.ToInt32(oku["IlID"]);
                misafirler.IlceID = Convert.ToInt32(oku["IlceID"]);
                misafirler.UlkeID = Convert.ToInt32(oku["UlkeID"]);
                misafirler.MisafirAciklama = oku["MisafirAciklama"].ToString();
                misafirler.DilID = Convert.ToInt32(oku["DilID"]);
            }
            oku.Close();
            return misafirler;
        }
        #endregion
        #region //Delete Misafir
        public int getMisafirSil(MisafirlerEntity silinecekMisafir)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "MisafirTcKimlik",
                    Value=silinecekMisafir.MisafirTcKimlik
                }
            };
            int etkilenenSatir = SQL.SqlexecuteNonQuerry("sp_DeleteMisafirler", true, kmtprmtr);
            return etkilenenSatir;
        }
        #endregion
    }
}
