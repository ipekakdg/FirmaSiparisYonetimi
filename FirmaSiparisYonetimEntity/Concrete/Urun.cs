using FirmaSiparisYonetimEntity.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimEntity
{
    public class Urun:IEntity
    {
        public int urun_id { get; set; }
        public int firma_id { get; set; }
        public string urun_adi { get; set; }
        public int urun_stok { get; set; }
        public decimal urun_fiyati { get; set; }
    }
}
