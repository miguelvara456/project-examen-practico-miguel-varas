using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico
{
    public enum QualityGarment
    {
        premium,standard
    }

    public abstract class Garment
    {
        public QualityGarment quality;

        public float priceUnit;

        public int count;
    }
}
