using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PersonellerEntity
    {
        public int PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelTcKimlik { get; set; }
        public DateTime PersonelDogumTarihi { get; set; }
        public int PersonelUyrukId { get; set; }
        public string PersonelEposta { get; set; }
        public string PersonelTelefon { get; set; }
        public string PersonelPasaportNo { get; set; }
        public int CinsiyetId { get; set; }
        public DateTime PersonelIseGirisTarihi { get; set; }
        public DateTime PersonelIstenCikisTarihi { get; set; }
        public decimal PersonelSaatlikUcret { get; set; }
        public decimal PersonelMaas { get; set; }
        public string PersonelSicilNo { get; set; }
        public int GorevId { get; set; }
        public int PersonelKategoriID { get; set; }
        public bool PersonelEngelDurumu { get; set; }
        public int IlID { get; set; }
        public int IlceID { get; set; }
        public int UlkeID { get; set; }
        public string PersonelAdres { get; set; }
        public string PersonelAcilDurumKisiAd { get; set; }
        public string PersonelAcilDurumKisiTelefon { get; set; }
        public int ResimId { get; set; }

       
    }
}
