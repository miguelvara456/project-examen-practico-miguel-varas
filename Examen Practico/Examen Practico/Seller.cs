using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico
{
    public class Seller
    {
        public String LastName { get; private set; }
        public int SellerCode { get; private set; }

        private List<Quote> quotes;

        public Seller(string lastName,int sellerCode)
        {
            this.LastName = lastName;
            this.SellerCode = sellerCode;
            quotes = new List<Quote>(0);
        }

        public void RegistreryQuote(Quote quote)
        {
            quotes.Add(quote);
        }


        public List<Quote> GetListQuotes()
        {
            return quotes;
        }
    }
}
