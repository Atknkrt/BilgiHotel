using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class MüsterilerDAL
    {
        #region//insert Müsteriler
        public int getInsertMüsteri(MüsterilerEntity EklenecekKitap,PersonellerEntity personel)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "MusteriAd",
                    Value=EklenecekKitap.MusteriAd
                },
                new SqlParameter
                {
                    ParameterName= "MusteriSoyad",
                    Value=EklenecekKitap.MusteriSoyad
                },
                new SqlParameter
                {
                    ParameterName= "MusteriTCKimlik",
                    Value=EklenecekKitap.MusteriTCKimlik
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriPasaportNo",
                    Value=EklenecekKitap.MusteriPasaportNo
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriUnvan",
                    Value=EklenecekKitap.MusteriUnvan
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriYetkiliAdSoyad",
                    Value=EklenecekKitap.MusteriYetkiliAdSoyad
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriVergiNo",
                    Value=EklenecekKitap.MusteriVergiNo
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriVergiDairesi",
                    Value=EklenecekKitap.MusteriVergiDairesi
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriTelefon",
                    Value=EklenecekKitap.MusteriTelefon
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriPosta",
                    Value=EklenecekKitap.MusteriPosta
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriAdres",
                    Value=EklenecekKitap.MusteriAdres
                },
                 new SqlParameter
                {
                    ParameterName= "IlID",
                    Value=EklenecekKitap.IlID
                },
                 new SqlParameter
                {
                    ParameterName= "IlceID",
                    Value=EklenecekKitap.IlceID
                },
                 new SqlParameter
                {
                    ParameterName= "UlkeID",
                    Value=EklenecekKitap.UlkeID
                }, new SqlParameter
                {
                    ParameterName= "MusteriAciklama",
                    Value=EklenecekKitap.MusteriAciklama
                },
                  new SqlParameter
                {
                    ParameterName= "MusteriKurumsalOK",
                    Value=EklenecekKitap.MusteriKurumsalOK
                },
                   new SqlParameter
                {
                    ParameterName= "DilID",
                    Value=EklenecekKitap.DilID
                },
                   new SqlParameter
                {
                    ParameterName= "PersonelId",
                    Value=personel.PersonelId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_müsteriekle", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region//Update Müsteriler
        public int getUpdateMüsteri(MüsterilerEntity DüzenelenecekKitap)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "MusteriID",
                    Value=DüzenelenecekKitap.MusteriID
                },
                new SqlParameter
                {
                    ParameterName= "MusteriAd",
                    Value=DüzenelenecekKitap.MusteriAd
                },
                new SqlParameter
                {
                    ParameterName= "MusteriSoyad",
                    Value=DüzenelenecekKitap.MusteriSoyad
                },
                new SqlParameter
                {
                    ParameterName= "MusteriTCKimlik",
                    Value=DüzenelenecekKitap.MusteriTCKimlik
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriPasaportNo",
                    Value=DüzenelenecekKitap.MusteriPasaportNo
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriUnvan",
                    Value=DüzenelenecekKitap.MusteriUnvan
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriYetkiliAdSoyad",
                    Value=DüzenelenecekKitap.MusteriYetkiliAdSoyad
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriVergiNo",
                    Value=DüzenelenecekKitap.MusteriVergiNo
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriVergiDairesi",
                    Value=DüzenelenecekKitap.MusteriVergiDairesi
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriTelefon",
                    Value=DüzenelenecekKitap.MusteriTelefon
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriPosta",
                    Value=DüzenelenecekKitap.MusteriPosta
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriAdres",
                    Value=DüzenelenecekKitap.MusteriAdres
                },
                 new SqlParameter
                {
                    ParameterName= "IlID",
                    Value=DüzenelenecekKitap.IlID
                },
                 new SqlParameter
                {
                    ParameterName= "IlceID",
                    Value=DüzenelenecekKitap.IlceID
                },
                 new SqlParameter
                {
                    ParameterName= "UlkeID",
                    Value=DüzenelenecekKitap.UlkeID
                }, new SqlParameter
                {
                    ParameterName= "MusteriAciklama",
                    Value=DüzenelenecekKitap.MusteriAciklama
                },
                  new SqlParameter
                {
                    ParameterName= "MusteriKurumsalOK",
                    Value=DüzenelenecekKitap.MusteriKurumsalOK
                },
                   new SqlParameter
                {
                    ParameterName= "DilID",
                    Value=DüzenelenecekKitap.DilID
                }

            };
            int deger = SQL.SqlexecuteNonQuerry("sp_UptadeMusteriler", true, kmtprmtr);
            return deger;
        }
        #endregion
        #region //TC'ye Göre Müsteri Getir
        public MüsterilerEntity getTCyeGöreMüsteriGetir(string MusteriTCKimlik)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "MusteriTCKimlik",
                    Value=MusteriTCKimlik
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_tcyegöremüsterigetir", true, kmtprmtr);
            MüsterilerEntity mymüsteri = new MüsterilerEntity();
            while (oku.Read())
            {
                mymüsteri.MusteriID = Convert.ToInt32(oku["MusteriID"]);
                mymüsteri.MusteriAd = oku["MusteriAd"].ToString();
                mymüsteri.MusteriSoyad = oku["MusteriSoyad"].ToString();
                mymüsteri.MusteriTCKimlik = oku["MusteriTCKimlik"].ToString();
                mymüsteri.MusteriPasaportNo = oku["MusteriPasaportNo"].ToString();
                mymüsteri.MusteriUnvan = oku["MusteriUnvan"].ToString();
                mymüsteri.MusteriYetkiliAdSoyad = oku["MusteriYetkiliAdSoyad"].ToString();
                mymüsteri.MusteriVergiNo = oku["MusteriVergiNo"].ToString();
                mymüsteri.MusteriVergiDairesi = oku["MusteriVergiDairesi"].ToString();
                mymüsteri.MusteriTelefon = oku["MusteriTelefon"].ToString();
                mymüsteri.MusteriAdres = oku["MusteriAdres"].ToString();
                mymüsteri.IlID = Convert.ToInt32(oku["IlID"]);
                mymüsteri.IlceID = Convert.ToInt32(oku["IlceID"]);
                mymüsteri.UlkeID = Convert.ToInt32(oku["UlkeID"]);
                mymüsteri.MusteriAciklama = oku["MusteriAciklama"].ToString();
                mymüsteri.MusteriKurumsalOK = Convert.ToBoolean(oku["MusteriKurumsalOK"]);
                mymüsteri.DilID = Convert.ToInt32(oku["DilID"]);
            }
            oku.Close();
            return mymüsteri;
        }
        #endregion
        #region //Müsterilerin Hepsini Getir
        public MüsterilerEntity getMüsterilerinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_müsterilerigetir",true,null);
            MüsterilerEntity müsteriler=null;
            while (oku.Read())
            {
                müsteriler.MusteriID = Convert.ToInt32(oku["MusteriID"]);
                müsteriler.MusteriAd = oku["MusteriAd"].ToString();
                müsteriler.MusteriSoyad = oku["MusteriSoyad"].ToString();
                müsteriler.MusteriTCKimlik = oku["MusteriTCKimlik"].ToString();
                müsteriler.MusteriPasaportNo = oku["MusteriPasaportNo"].ToString();
                müsteriler.MusteriUnvan = oku["MusteriUnvan"].ToString();
                müsteriler.MusteriYetkiliAdSoyad = oku["MusteriYetkiliAdSoyad"].ToString();
                müsteriler.MusteriVergiNo = oku["MusteriVergiNo"].ToString();
                müsteriler.MusteriVergiDairesi = oku["MusteriVergiDairesi"].ToString();
                müsteriler.MusteriTelefon = oku["MusteriTelefon"].ToString();
                müsteriler.MusteriAdres = oku["MusteriAdres"].ToString();
                müsteriler.IlID = Convert.ToInt32(oku["IlID"]);
                müsteriler.IlceID = Convert.ToInt32(oku["IlceID"]);
                müsteriler.UlkeID = Convert.ToInt32(oku["UlkeID"]);
                müsteriler.MusteriAciklama = oku["MusteriAciklama"].ToString();
                müsteriler.MusteriKurumsalOK = Convert.ToBoolean(oku["MusteriKurumsalOK"]);
                müsteriler.DilID = Convert.ToInt32(oku["DilID"]);
            }
            return müsteriler;
        }
        #endregion
        #region //Delete Müsteriler
        public int getMüsteriSil(MüsterilerEntity silinecekMüsteri)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "MusteriTCKimlik",
                    Value=silinecekMüsteri.MusteriTCKimlik
                }
            };
            int etkilenenSatir=SQL.SqlexecuteNonQuerry("sp_DeleteMusteriler",true,kmtprmtr);
            return etkilenenSatir;
        }
        #endregion
    }
}