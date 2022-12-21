using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RezervasyonlarEntity
    {
        public int RezervasyonId { get; set; }
        public DateTime RezervasyonGecerlilikSonTarihi { get; set; }
        public int ErkenRezervasyonIndirim { get; set; }
        public int RezervasyonTipiId { get; set; }
        public string RezervasyonAciklama { get; set; }
        public bool RezervasyonIptalOk { get; set; }
        public DateTime RezervasyonGirisTarihi { get; set; }
        public DateTime RezervasyonCikisTarihi { get; set; }
        public decimal RezervasyonTutari { get; set; }
        public int OdaId { get; set; }
        public int KartId { get; set; }
        public int OdaTipiId { get; set; }
    }
}
