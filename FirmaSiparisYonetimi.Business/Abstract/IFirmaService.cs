using FirmaSiparisYonetimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimi.Business.Abstract
{
    public interface IFirmaService
    {
        void Add(Firma firma_adi);
        List<Firma> GetAll();

        void Update(Firma onay_durumu);
    }
}
