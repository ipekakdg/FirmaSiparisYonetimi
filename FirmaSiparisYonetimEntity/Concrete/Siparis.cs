using FirmaSiparisYonetimEntity.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimEntity
{
    public class Siparis:IEntity
    {
        public int siparis_id { get; set; }
        public int firma_id { get; set; }
        public int urun_id { get; set; }
        public string siparis_kisi_adi { get; set; }
        public DateTime siparis_tarih { get; set; }
    }
}
