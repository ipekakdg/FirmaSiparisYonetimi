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
    public class UrunManager : IUrunService
    {
        private IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {

            _urunDal = urunDal;

        }
        void IUrunService.Add(Urun urun)
        {
            _urunDal.Add(urun);
        }
    }
}
