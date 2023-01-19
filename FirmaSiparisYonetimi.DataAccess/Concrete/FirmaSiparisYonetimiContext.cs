using FirmaSiparisYonetimEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FirmaSiparisYonetimi.DataAccess.Concrete
{
    public class FirmaSiparisYonetimiContext:DbContext
    {
        public DbSet<Firma> Firma { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<Urun> Urun { get; set; }

    }
}
