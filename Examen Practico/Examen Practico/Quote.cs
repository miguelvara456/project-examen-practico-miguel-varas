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

        public Garment quotedGarment;

        public Quote(int numberId, string dateHour, int sellerCode, int quotedUnits, float quotedResult)
        {
            this.NumberId = numberId;
            this.DateHour = dateHour;
            this.SellerCode = sellerCode;
            this.QuotedUnits = quotedUnits;
            this.QuotedResult = quotedResult;
        }

        public void CalculateQuote()
        {

        }

    }
}
