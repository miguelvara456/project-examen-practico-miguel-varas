using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Practico
{
    public partial class Form1 : Form
    {
        private Shop shop;
        private Seller seller;
        private bool isListQuotedOpen;
        public Form1()
        {
            InitializeComponent();
            shop = new Shop("Abasto", "Av. Corrientes 1234", "Capital Federal", "1233", "Buenos Aires");
            seller = new Seller("Miguel Varas", 1238493812);
            labelNameShop.Text = shop.ShopName;
            labelAddressShop.Text = shop.Address;
            labelLastNameAndSellerCode.Text = $"{seller.LastName} | Codigo Vendedor: {seller.SellerCode}";
        }

        private void radioButtonTrousers_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonShirt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChupin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShortSleeve_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxLongSleeve_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void texCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDisponibleStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPremium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonStandard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonQuote_Click(object sender, EventArgs e)
        {

        }

        private void labelHistoryQuotes_Click(object sender, EventArgs e)
        {
                Form2 formQuotedList = new Form2(seller.GetListQuotes());
                formQuotedList.Show();
        }
    }
}
