using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    
    public class PersonellerDAL
    {
        #region // Insert Personeller
        public int getInsertPersonel(PersonellerEntity EklenecekPersonel,VardiyaEntity vardiya)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "PersonelAd",
                    Value=EklenecekPersonel.PersonelAd
                },
                new SqlParameter
                {
                    ParameterName= "PersonelSoyad",
                    Value=EklenecekPersonel.PersonelSoyad
                },
                new SqlParameter
                {
                    ParameterName= "PersonelTcKimlik",
                    Value=EklenecekPersonel.PersonelTcKimlik
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelDogumTarihi",
                    Value=EklenecekPersonel.PersonelDogumTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelUyrukId",
                    Value=EklenecekPersonel.PersonelUyrukId
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelEposta",
                    Value=EklenecekPersonel.PersonelEposta
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelTelefon",
                    Value=EklenecekPersonel.PersonelTelefon
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelPasaportNo",
                    Value=EklenecekPersonel.PersonelPasaportNo
                },
                 new SqlParameter
                {
                    ParameterName= "CinsiyetId",
                    Value=EklenecekPersonel.CinsiyetId
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelIseGirisTarihi",
                    Value=EklenecekPersonel.PersonelIseGirisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelIstenCikisTarihi",
                    Value=EklenecekPersonel.PersonelIstenCikisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelSaatlikUcret",
                    Value=EklenecekPersonel.PersonelSaatlikUcret
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelMaas",
                    Value=EklenecekPersonel.PersonelMaas
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelSicilNo",
                    Value=EklenecekPersonel.PersonelSicilNo
                },
                 new SqlParameter
                {
                    ParameterName= "GorevId",
                    Value=EklenecekPersonel.GorevId
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelKategoriID",
                    Value=EklenecekPersonel.PersonelKategoriID
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelEngelDurumu",
                    Value=EklenecekPersonel.PersonelEngelDurumu
                },                
                 new SqlParameter
                {
                    ParameterName= "IlID",
                    Value=EklenecekPersonel.IlID
                },
                 new SqlParameter
                {
                    ParameterName= "IlceID",
                    Value=EklenecekPersonel.IlceID
                },
                 new SqlParameter
                {
                    ParameterName= "UlkeID",
                    Value=EklenecekPersonel.UlkeID
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelAdres",
                    Value=EklenecekPersonel.PersonelAdres
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelAcilDurumKisiAd",
                    Value=EklenecekPersonel.PersonelAcilDurumKisiAd
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelAcilDurumKisiTelefon",
                    Value=EklenecekPersonel.PersonelAcilDurumKisiTelefon
                },
                   new SqlParameter
                {
                    ParameterName= "ResimId",
                    Value=EklenecekPersonel.ResimId
                },
                   new SqlParameter
                {
                    ParameterName= "VardiyaId",//SORULACAK
                    Value=vardiya.VardiyaId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_personelekle", true, kmtprmtr);

            return deger;
        }
        #endregion
        #region // Update Misafirler
        public int getUpdatePersonel(PersonellerEntity GüncellenecekPersonel, VardiyaEntity vardiya)
        {
           

            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "PersonelId",
                    Value=GüncellenecekPersonel.PersonelId
                },
                new SqlParameter
                {
                    ParameterName= "PersonelAd",
                    Value=GüncellenecekPersonel.PersonelAd
                },
                new SqlParameter
                {
                    ParameterName= "PersonelSoyad",
                    Value=GüncellenecekPersonel.PersonelSoyad
                },
                new SqlParameter
                {
                    ParameterName= "PersonelTcKimlik",
                    Value=GüncellenecekPersonel.PersonelTcKimlik
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelDogumTarihi",
                    Value=GüncellenecekPersonel.PersonelDogumTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelUyrukId",
                    Value=GüncellenecekPersonel.PersonelUyrukId
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelEposta",
                    Value=GüncellenecekPersonel.PersonelEposta
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelTelefon",
                    Value=GüncellenecekPersonel.PersonelTelefon
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelPasaportNo",
                    Value=GüncellenecekPersonel.PersonelPasaportNo
                },
                 new SqlParameter
                {
                    ParameterName= "CinsiyetId",
                    Value=GüncellenecekPersonel.CinsiyetId
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelIseGirisTarihi",
                    Value=GüncellenecekPersonel.PersonelIseGirisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelIstenCikisTarihi",
                    Value=GüncellenecekPersonel.PersonelIstenCikisTarihi
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelSaatlikUcret",
                    Value=GüncellenecekPersonel.PersonelSaatlikUcret
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelMaas",
                    Value=GüncellenecekPersonel.PersonelMaas
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelSicilNo",
                    Value=GüncellenecekPersonel.PersonelSicilNo
                },
                 new SqlParameter
                {
                    ParameterName= "GorevId",
                    Value=GüncellenecekPersonel.GorevId
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelKategoriID",
                    Value=GüncellenecekPersonel.PersonelKategoriID
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelEngelDurumu",
                    Value=GüncellenecekPersonel.PersonelEngelDurumu
                },
                 new SqlParameter
                {
                    ParameterName= "IlID",
                    Value=GüncellenecekPersonel.IlID
                },
                 new SqlParameter
                {
                    ParameterName= "IlceID",
                    Value=GüncellenecekPersonel.IlceID
                },
                 new SqlParameter
                {
                    ParameterName= "UlkeID",
                    Value=GüncellenecekPersonel.UlkeID
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelAdres",
                    Value=GüncellenecekPersonel.PersonelAdres
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelAcilDurumKisiAd",
                    Value=GüncellenecekPersonel.PersonelAcilDurumKisiAd
                },
                 new SqlParameter
                {
                    ParameterName= "PersonelAcilDurumKisiTelefon",
                    Value=GüncellenecekPersonel.PersonelAcilDurumKisiTelefon
                },
                   new SqlParameter
                {
                    ParameterName= "ResimId",
                    Value=GüncellenecekPersonel.ResimId
                },
                   new SqlParameter
                {
                    ParameterName= "VardiyaId",//SORULACAK
                    Value=vardiya.VardiyaId
                }

            };

            int deger = SQL.SqlexecuteNonQuerry("sp_personelgüncelle", true, kmtprmtr);

            return deger;
        }
        #endregion
        #region //TC'ye Göre Personel Getir
        public PersonellerEntity getTCyeGörePersonelGetir(string PersonelTcKimlik)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "PersonelTcKimlik",
                    Value=PersonelTcKimlik
                }
            };
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_tcyegörepersonelgetir", true, kmtprmtr);
            PersonellerEntity mypersonel = new PersonellerEntity();
            while (oku.Read())
            {
                mypersonel.PersonelId = Convert.ToInt32(oku["PersonelId"]);
                mypersonel.PersonelAd = oku["PersonelAd"].ToString();
                mypersonel.PersonelSoyad = oku["PersonelSoyad"].ToString();
                mypersonel.PersonelTcKimlik = oku["PersonelTcKimlik"].ToString();
                mypersonel.PersonelDogumTarihi = Convert.ToDateTime(oku["PersonelDogumTarihi"]);
                mypersonel.PersonelUyrukId = Convert.ToInt32(oku["PersonelUyrukId"]);
                mypersonel.PersonelEposta = oku["PersonelEposta"].ToString();
                mypersonel.PersonelTelefon = oku["PersonelTelefon"].ToString();
                mypersonel.PersonelPasaportNo = oku["PersonelPasaportNo"].ToString();
                mypersonel.CinsiyetId = Convert.ToInt32(oku["CinsiyetId"]);
                mypersonel.PersonelIseGirisTarihi = Convert.ToDateTime(oku["PersonelIseGirisTarihi"]);
                mypersonel.PersonelIstenCikisTarihi = Convert.ToDateTime(oku["PersonelIstenCikisTarihi"]);
                mypersonel.PersonelSaatlikUcret = Convert.ToDecimal(oku["PersonelSaatlikUcret"]);
                mypersonel.PersonelMaas = Convert.ToDecimal(oku["PersonelMaas"]);
                mypersonel.PersonelSicilNo = oku["PersonelSicilNo"].ToString();
                mypersonel.GorevId = Convert.ToInt32(oku["GorevId"]);
                mypersonel.PersonelKategoriID = Convert.ToInt32(oku["PersonelKategoriID"]);
                mypersonel.PersonelEngelDurumu = Convert.ToBoolean(oku["PersonelEngelDurumu"]);
                mypersonel.IlID = Convert.ToInt32(oku["IlID"]);
                mypersonel.IlceID = Convert.ToInt32(oku["IlceID"]);
                mypersonel.UlkeID = Convert.ToInt32(oku["UlkeID"]);
                mypersonel.PersonelAdres = oku["PersonelAdres"].ToString();
                mypersonel.PersonelAcilDurumKisiAd = oku["PersonelAcilDurumKisiAd"].ToString();
                mypersonel.PersonelAcilDurumKisiTelefon = oku["PersonelAcilDurumKisiTelefon"].ToString();
                mypersonel.ResimId = Convert.ToInt32(oku["ResimId"]);
            }
            oku.Close();
            return mypersonel;
        }
        #endregion
        #region //Personellerin Hepsini Getir
        public PersonellerEntity getPersonellerinHepsiniGetir()
        {
            SqlDataReader oku = SQL.SqlexecuteReaderSp("sp_personellerigetir", true, null);
            PersonellerEntity personeller = null;
            while (oku.Read())
            {
                personeller.PersonelId = Convert.ToInt32(oku["PersonelId"]);
                personeller.PersonelAd = oku["PersonelAd"].ToString();
                personeller.PersonelSoyad = oku["PersonelSoyad"].ToString();
                personeller.PersonelTcKimlik = oku["PersonelTcKimlik"].ToString();
                personeller.PersonelDogumTarihi = Convert.ToDateTime(oku["PersonelDogumTarihi"]);
                personeller.PersonelUyrukId = Convert.ToInt32(oku["PersonelUyrukId"]);
                personeller.PersonelEposta = oku["PersonelEposta"].ToString();
                personeller.PersonelTelefon = oku["PersonelTelefon"].ToString();
                personeller.PersonelPasaportNo = oku["PersonelPasaportNo"].ToString();
                personeller.CinsiyetId = Convert.ToInt32(oku["CinsiyetId"]);
                personeller.PersonelIseGirisTarihi = Convert.ToDateTime(oku["PersonelIseGirisTarihi"]);
                personeller.PersonelIstenCikisTarihi = Convert.ToDateTime(oku["PersonelIstenCikisTarihi"]);
                personeller.PersonelSaatlikUcret = Convert.ToDecimal(oku["PersonelSaatlikUcret"]);
                personeller.PersonelMaas = Convert.ToDecimal(oku["PersonelMaas"]);
                personeller.PersonelSicilNo = oku["PersonelSicilNo"].ToString();
                personeller.GorevId = Convert.ToInt32(oku["GorevId"]);
                personeller.PersonelKategoriID = Convert.ToInt32(oku["PersonelKategoriID"]);
                personeller.PersonelEngelDurumu = Convert.ToBoolean(oku["PersonelEngelDurumu"]);
                personeller.IlID = Convert.ToInt32(oku["IlID"]);
                personeller.IlceID = Convert.ToInt32(oku["IlceID"]);
                personeller.UlkeID = Convert.ToInt32(oku["UlkeID"]);
                personeller.PersonelAdres = oku["PersonelAdres"].ToString();
                personeller.PersonelAcilDurumKisiAd = oku["PersonelAcilDurumKisiAd"].ToString();
                personeller.PersonelAcilDurumKisiTelefon = oku["PersonelAcilDurumKisiTelefon"].ToString();
                personeller.ResimId = Convert.ToInt32(oku["ResimId"]);
            }
            oku.Close();
            return personeller;
        }
        #endregion
        #region //Delete Misafir
        public int getPersonelSil(PersonellerEntity silinecekPersonel)
        {
            SqlParameter[] kmtprmtr =
            {
                new SqlParameter
                {
                    ParameterName= "PersonelTcKimlik",
                    Value=silinecekPersonel.PersonelTcKimlik
                }
            };
            int etkilenenSatir = SQL.SqlexecuteNonQuerry("sp_DeletePersoneller", true, kmtprmtr);
            return etkilenenSatir;
        }
        #endregion
    }

}
