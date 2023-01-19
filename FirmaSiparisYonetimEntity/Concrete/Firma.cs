using FirmaSiparisYonetimEntity.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimEntity
{
    public class Firma:IEntity
    {
        public int firma_id { get; set; }
        public string firma_adi { get; set; }
        public string onay_durumu { get; set; }
        public DateTime siparis_izin_baslangic_saati { get; set; }
        public DateTime siparis_izin_bitis_saati{ get; set; }

    }
}
