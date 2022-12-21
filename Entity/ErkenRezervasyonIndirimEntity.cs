using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ErkenRezervasyonIndirimEntity
    {
        public int ErkenRezervasyonId { get; set; }
        public int ErkenRezervasyonGünSayisi { get; set; }
        public int ErkenRezervasyonIndirimOrani { get; set; }
        public string ErkenRezervasyon { get; set; }
        public bool ErkenRezervasyonAktifMi { get; set; }
    }
}
