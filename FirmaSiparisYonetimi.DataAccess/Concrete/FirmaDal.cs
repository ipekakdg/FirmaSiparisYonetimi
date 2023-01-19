using FirmaSiparisYonetimEntity;
using FirmaSiparisYonetimEntity.Concrete;
using FirmaSiparisYonetimi.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimi.DataAccess.Concrete
{
    public class FirmaDal:EntityRepositoryBase<Firma, FirmaSiparisYonetimiContext>,IFirmaDal
    {

    }
}
