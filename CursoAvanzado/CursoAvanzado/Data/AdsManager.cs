using CursoAvanzado.Models.Ads;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAvanzado.Data
{
    public class AdsManager
    {
        public IList<Ad> Ads { get; set; }
        public static Lazy<AdsManager> Instance = new Lazy<AdsManager>();

        public AdsManager()
        {
            Ads = AdsRepository.Ads;
        }

    }
}
