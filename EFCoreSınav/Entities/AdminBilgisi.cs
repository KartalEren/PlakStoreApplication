using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSınav.Entities
{
    public class AdminBilgisi : BaseEntity
    {
        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }
    }
}
