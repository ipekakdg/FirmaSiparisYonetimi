using FirmaSiparisYonetimEntity;
using FirmaSiparisYonetimi.Business.Abstract;
using FirmaSiparisYonetimi.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimi.Business.Concrete
{
    public class SiparisManager : ISiparisService
    {
        private ISiparisDal _siparisDal;

        public SiparisManager(ISiparisDal siparisDal)
        {

            _siparisDal = siparisDal;

        }
        void ISiparisService.Add(Siparis siparis)
        {
            _siparisDal.Add(siparis);
        }
    }
}
