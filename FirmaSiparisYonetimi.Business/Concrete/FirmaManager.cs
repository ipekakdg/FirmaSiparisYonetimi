using FirmaSiparisYonetimEntity;
using FirmaSiparisYonetimi.Business.Abstract;
using FirmaSiparisYonetimi.DataAccess.Abstract;
using FirmaSiparisYonetimi.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimi.Business.Concrete
{
    public class FirmaManager : IFirmaService
    {
        private IFirmaDal _firmaDal;

        public FirmaManager(IFirmaDal firmaDal) {

            _firmaDal = firmaDal;

        }
        void IFirmaService.Add(Firma firma_adi)
        {
            _firmaDal.Add(firma_adi);
        }

        List<Firma> IFirmaService.GetAll()
        {
            return _firmaDal.GetAll();
        }

        void IFirmaService.Update(Firma onay_durumu)
        {
            _firmaDal.Update(onay_durumu);
        }
    }
}

