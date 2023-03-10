using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MisafirlerEntity
    {
        public int MisafirId { get; set; }
        public string MisafirAd { get; set; }
        public string MisafirSoyad { get; set; }
        public string MisafirTcKimlik { get; set; }
        public DateTime MisafirDogumTarihi { get; set; }
        public int MisafirUyrukId { get; set; }
        public string MisafirEposta { get; set; }
        public string MisafirTelefon { get; set; }
        public string MisafirPasaportNo { get; set; }
        public int CinsiyetId { get; set; }
        public string MisafirAdres { get; set; }
        public int IlID { get; set; }
        public int IlceID { get; set; }
        public int UlkeID { get; set; }
        public string MisafirAciklama { get; set; }
        public int DilID { get; set; }
    }
}
