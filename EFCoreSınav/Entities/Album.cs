using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSınav.Entities
{
    public class Album : BaseEntity
    {
        

        public string AlbumAdi { get; set; }

        public string AlbumunSanatcisi { get; set; }

        public DateTime AlbumCikisTarihi { get; set; }

        public decimal AlbumFiyati { get; set; }

        public double? IndirimOrani { get; set; }

        public bool SatisaDevamEdiyorMu { get; set; }



    }
}
