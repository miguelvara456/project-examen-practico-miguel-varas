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
        public Garment quotedGarment {get; private set; }

        public Quote(int numberId, string dateHour, int sellerCode, int quotedUnits)
        {
            this.NumberId = numberId;
            this.DateHour = dateHour;
            this.SellerCode = sellerCode;
            this.QuotedUnits = quotedUnits;
        }

        private void CalculateQuoteTrousers(Trousers trouser)
        {
            QuotedResult = trouser.PriceUnit;

            if(trouser.chupin)
            {
                var percent = ((12 * QuotedResult) / 100);
                QuotedResult -= percent;
                //-12%
            }

            switch (trouser.Quality)
            {
                case QualityGarment.premium:
                    var percent = ((30 * QuotedResult) / 100);
                    QuotedResult += percent;
                    //+30%
                    break;
                case QualityGarment.standard:
                    //no change price
                    break;
            }
            quotedGarment = trouser;
        }

        private void CalculateQuoteShirts(Shirts shirt)
        {
            if (shirt.shortSleeve)
            {
                var percent = ((10 * QuotedResult) / 100);
                QuotedResult -= percent;
                //-10%
            }

            if (shirt.maoNeck)
            {
                var percent = ((3 * QuotedResult) / 100);
                QuotedResult += percent;
                //+3%
            }

            switch (shirt.Quality)
            {
                case QualityGarment.premium:
                    var percent = ((30 * QuotedResult) / 100);
                    QuotedResult += percent;
                    //+30%
                    break;
                case QualityGarment.standard:
                    //no change price
                    break;
            }
            quotedGarment = shirt;
        }

    }
}
