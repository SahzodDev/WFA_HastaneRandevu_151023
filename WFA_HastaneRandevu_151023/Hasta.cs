using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevu_151023
{
    internal class Hasta
    {
        public string Ad {  get; set; }
        public string Poliklinik {  get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string TCNo {  get; set; }
        public string Cinsiyet {  get; set; }
        public string TelefonNo {  get; set; }
        public string RandevuSaati {  get; set; }

        public override string ToString()
        {
            return $"{Ad} - {Poliklinik} - {RandevuTarihi.ToString("d")} - {RandevuSaati}";
        }

        public string ToDetailedString()
        {
            return $"Ad Soyad :{Ad}\nT.C. :{TCNo}\nCinsiyet :{Cinsiyet}";
        }
    }
}
