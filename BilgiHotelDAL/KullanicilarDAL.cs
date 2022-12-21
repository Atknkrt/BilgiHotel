using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class KullanicilarDAL
    {
        #region // Insert Kullanicilar
        public int getInsertKullanicilar(KullaniciEntity EklenecekKullanici,MüsterilerEntity ekmüsteri,PersonellerEntity ekpersonel,YetkilerEntity ekyetki)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KullaniciTipiId",
                    Value=EklenecekKullanici.KullaniciTipiId
                },
                new SqlParameter
                {
                    ParameterName= "KullaniciAd",
                    Value=EklenecekKullanici.KullaniciAd
                },
                new SqlParameter
                {
                    ParameterName= "KullaniciParola",
                    Value=EklenecekKullanici.KullaniciParola
                },
                 new SqlParameter
                {
                    ParameterName= "KullaniciEposta",
                    Value=EklenecekKullanici.KullaniciEposta
                },
                 new SqlParameter
                {
                    ParameterName= "KullaniciEpostaOnayKod",
                    Value=EklenecekKullanici.KullaniciEpostaOnayKod
                },
                 new SqlParameter
                {
                    ParameterName= "KullaniciEpostaOnay",
                    Value=EklenecekKullanici.KullaniciEpostaOnay
                },
                 new SqlParameter
                {
                    ParameterName= "KullaniciKayıtTarihi",
                    Value=EklenecekKullanici.KullaniciKayıtTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "KullaniciSonGirisTarihi",
                    Value=EklenecekKullanici.KullaniciSonGirisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "DilId",
                    Value=EklenecekKullanici.DilId
                },
                 new SqlParameter
                {
                    ParameterName= "ResimId",
                    Value=EklenecekKullanici.ResimId
                },
                 new SqlParameter
                {
                    ParameterName= "MusteriID",
                    Value=ekmüsteri.MusteriID
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelId",
                    Value=ekpersonel.PersonelId
                },
                 new SqlParameter
                {
                    ParameterName= "YetkiId",
                    Value=ekyetki.YetkiId
                }
            };

            int deger = SQL.SqlexecuteNonQuerry("sp_InsertKullanicilar", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region // Update Kullanicilar
        public int getUpdateKullanici(KullaniciEntity GüncellenecekKullanici)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KullaniciTipiId",
                    Value=GüncellenecekKullanici.KullaniciTipiId
                },
                new SqlParameter
                {
                    ParameterName= "KullaniciAd",
                    Value=GüncellenecekKullanici.KullaniciAd
                },
                new SqlParameter
                {
                    ParameterName= "KullaniciParola",
                    Value=GüncellenecekKullanici.KullaniciParola
                },
                 new SqlParameter
                {
                    ParameterName= "KullaniciEposta",
                    Value=GüncellenecekKullanici.KullaniciEposta
                },
                 new SqlParameter
                {
                    ParameterName= "KullaniciEpostaOnayKod",
                    Value=GüncellenecekKullanici.KullaniciEpostaOnayKod
                },
                 new SqlParameter
                {
                    ParameterName= "KullaniciEpostaOnay",
                    Value=GüncellenecekKullanici.KullaniciEpostaOnay
                },
                 new SqlParameter
                {
                    ParameterName= "KullaniciKayıtTarihi",
                    Value=GüncellenecekKullanici.KullaniciKayıtTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "KullaniciSonGirisTarihi",
                    Value=GüncellenecekKullanici.KullaniciSonGirisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "DilId",
                    Value=GüncellenecekKullanici.DilId
                },
                 new SqlParameter
                {
                    ParameterName= "ResimId",
                    Value=GüncellenecekKullanici.ResimId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_UpdateKulanicilar", true, kmtprmtr);

            return deger;

        }
        #endregion
        #region //ID'ye Göre Kulanici Getir
        public KullaniciEntity getTCyeGöreKulaniciGetir(int KullaniciId)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KullaniciId",
                    Value=KullaniciId
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_IdyeGörekullaniciGetir", true, kmtprmtr);
            KullaniciEntity mykullanici = new KullaniciEntity();
            while (oku.Read())
            {
                mykullanici.KullaniciId = Convert.ToInt32(oku["KullaniciId"]);
                mykullanici.KullaniciTipiId = Convert.ToInt32(oku["KullaniciTipiId"]);
                mykullanici.KullaniciAd = oku["KullaniciAd"].ToString();
                mykullanici.KullaniciParola = oku["KullaniciParola"].ToString();
                mykullanici.KullaniciEposta = oku["KullaniciEposta"].ToString();
                mykullanici.KullaniciEpostaOnayKod = oku["KullaniciEpostaOnayKod"].ToString();
                mykullanici.KullaniciEpostaOnay = oku["KullaniciEpostaOnay"].ToString();
                mykullanici.KullaniciKayıtTarihi =Convert.ToDateTime(oku["KullaniciKayıtTarihi"]);
                mykullanici.KullaniciSonGirisTarihi = Convert.ToDateTime(oku["KullaniciSonGirisTarihi"]);
                mykullanici.DilId = Convert.ToInt32(oku["DilId"]);
                mykullanici.ResimId = Convert.ToInt32(oku["ResimId"]);
            }
            oku.Close();
            return mykullanici;
        }
        #endregion
        #region //Kullanici Hepsini Getir
        public KullaniciEntity getKullaniciHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_kullaniciHepsiniGetir", true, null);
            KullaniciEntity kullanicilar = null;
            while (oku.Read())
            {
                kullanicilar.KullaniciId = Convert.ToInt32(oku["KullaniciId"]);
                kullanicilar.KullaniciTipiId = Convert.ToInt32(oku["KullaniciTipiId"]);
                kullanicilar.KullaniciAd = oku["KullaniciAd"].ToString();
                kullanicilar.KullaniciParola = oku["KullaniciParola"].ToString();
                kullanicilar.KullaniciEposta = oku["KullaniciEposta"].ToString();
                kullanicilar.KullaniciEpostaOnayKod = oku["KullaniciEpostaOnayKod"].ToString();
                kullanicilar.KullaniciEpostaOnay = oku["KullaniciEpostaOnay"].ToString();
                kullanicilar.KullaniciKayıtTarihi = Convert.ToDateTime(oku["KullaniciKayıtTarihi"]);
                kullanicilar.KullaniciSonGirisTarihi = Convert.ToDateTime(oku["KullaniciSonGirisTarihi"]);
                kullanicilar.DilId = Convert.ToInt32(oku["DilId"]);
                kullanicilar.ResimId = Convert.ToInt32(oku["ResimId"]);
            }
            oku.Close();
            return kullanicilar;
        }
        #endregion
        #region //Delete kullanici
        public int getkullaniciSil(KullaniciEntity silinecekkullanici)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "KullaniciId",
                    Value=silinecekkullanici.KullaniciId
                }
            };
            int etkilenenSatir = SQL.SqlexecuteNonQuerry("sp_DeleteKullanicilar", true, kmtprmtr);
            return etkilenenSatir;
        }
        #endregion
    }
}
