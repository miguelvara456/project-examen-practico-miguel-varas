using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico
{
    public class Shirts : Garment
    {
        public bool maoNeck;
        public bool shortSleeve;
        public Shirts(QualityGarment quality, float priceUnit, int count)
        {
            this.Quality = quality;
            this.PriceUnit = priceUnit;
            this.Count = count;
        }
    }
}
