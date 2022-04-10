using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico
{
    public class Shop
    {
        public string ShopName {get; private set;}
        public string Address {get; private set;}
        public string State {get; private set;}
        public string PostalCode { get; private set;}
        public string Country { get; private set; }

        public List<Garment> garments;
        public Shop(string shopName, string address, string state, string postalCode, string country)
        {
            this.Address = address;
            this.Country = country;
            this.PostalCode = postalCode;
            this.ShopName = shopName;
            this.State = state;
        }

        public void AddGarmentToShop(Garment garment)
        {
            garments.Add(garment);
        }
    }
}
