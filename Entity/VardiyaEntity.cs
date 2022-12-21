using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class VardiyaEntity
    {
        public int VardiyaId { get; set; }
        public string VardiyaTipi { get; set; }
        public DateTime VardiyaBaslangicSaati { get; set; }
        public DateTime VardiyaBitisSaati { get; set; }
    }
}
