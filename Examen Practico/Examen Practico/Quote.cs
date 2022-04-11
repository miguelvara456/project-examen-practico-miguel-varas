using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico
{

    public class Quote
    {
        public int NumberId{get; private set;}
        public string DateHour{get; private set;}
        public int SellerCode{get; private set;}
        public int QuotedUnits{get; private set;}
        public float QuotedResult{get; private set;}
        public Garment QuotedGarment {get; private set; }

        public Quote( int sellerCode, int quotedUnits)
        {
            this.NumberId = new Random().Next(1000000, 9000000);
            this.DateHour = DateTime.Now.ToString();
            this.SellerCode = sellerCode;
            this.QuotedUnits = quotedUnits;
        }

        public void CalculateQuoteTrousers(Trousers trouser)
        {
            QuotedResult = trouser.priceUnit;

            if(trouser.chupin)
            {
                var percent = ((12 * trouser.priceUnit) / 100);
                trouser.priceUnit -= percent;
                //-12%
            }

            switch (trouser.quality)
            {
                case QualityGarment.premium:
                    var percent = ((30 * trouser.priceUnit) / 100);
                    trouser.priceUnit += percent;
                    //+30%
                    break;
                case QualityGarment.standard:
                    //no change price
                    break;
            }
            QuotedGarment = trouser;
            QuotedResult = trouser.priceUnit;
        }

        public void CalculateQuoteShirts(Shirts shirt)
        {
            if (shirt.shortSleeve)
            {
                var percent = ((10 * shirt.priceUnit) / 100);
                shirt.priceUnit -= percent;
                //-10%
            }

            if (shirt.maoNeck)
            {
                var percent = ((3 * shirt.priceUnit) / 100);
                shirt.priceUnit += percent;
                //+3%
            }

            switch (shirt.quality)
            {
                case QualityGarment.premium:
                    var percent = ((30 * shirt.priceUnit) / 100);
                    shirt.priceUnit += percent;
                    //+30%
                    break;
                case QualityGarment.standard:
                    //no change price
                    break;
            }
            QuotedGarment = shirt;
            QuotedResult = shirt.priceUnit;
        }

    }
}
