﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico
{
    public class Trousers : Garment
    {
        public bool chupin;
        public bool normal;
        public Trousers(QualityGarment quality,float priceUnit, int count)
        {
            this.Quality = quality;
            this.PriceUnit = priceUnit;
            this.Count = count;
        }
    }
}