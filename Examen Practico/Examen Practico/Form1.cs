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
        private Garment garmentActual;
        public Form1()
        {
            InitializeComponent();
            Boot();
            InitializeUI();
        }
        private void Boot()
        {
            shop = new Shop("Abasto", "Av. Corrientes 1234", "Capital Federal", "1233", "Buenos Aires");
            seller = new Seller("Miguel Varas", 1238493812);
            shop.AddGarmentToShop(new Shirts());
            shop.AddGarmentToShop(new Trousers());
        }

        private void InitializeUI()
        {
            labelNameShop.Text = shop.ShopName;
            labelAddressShop.Text = shop.Address;
            labelLastNameAndSellerCode.Text = $"{seller.LastName} | Codigo Vendedor: {seller.SellerCode}";
            checkBoxMaoNeck.Enabled = false;
            checkBoxShortSleeve.Enabled = false;
            checkBoxChupin.Enabled = false;
            radioButtonPremium.Enabled = false;
            radioButtonStandard.Enabled = false;
            texCount.Enabled = false;
            textPrice.Enabled = false;
        }
        private void radioButtonTrousers_CheckedChanged(object sender, EventArgs e)
        {
           if(radioButtonTrousers.Checked)
            {
                var trousers = (Trousers)shop.GetGarmentToShop(1);
                garmentActual = trousers;
                trousers.count = 2000;
                labelUnitStock.Text =$"Unidades de stock disponibles: {trousers.count}";
                checkBoxMaoNeck.Enabled = false;
                checkBoxShortSleeve.Enabled = false;
                checkBoxChupin.Enabled = true;
                radioButtonPremium.Enabled = true;
                radioButtonStandard.Enabled = true;
                texCount.Enabled = true;
                textPrice.Enabled = true;
            }
        }

        private void radioButtonShirt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonShirt.Checked)
            {
                var shirts = (Shirts)shop.GetGarmentToShop(0);
                garmentActual = shirts;
                shirts.count = 1000;
                labelUnitStock.Text = $"Unidades de stock disponibles: {shirts.count}";
                checkBoxMaoNeck.Enabled = true;
                checkBoxShortSleeve.Enabled = true;
                checkBoxChupin.Enabled = false;
                radioButtonPremium.Enabled = true;
                radioButtonStandard.Enabled = true;
                texCount.Enabled = true;
                textPrice.Enabled = true;
            }
        }

        private void checkBoxChupin_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxChupin.Enabled)
            {
                if(checkBoxChupin.Checked)
                {
                    var trousers = (Trousers)shop.GetGarmentToShop(1);
                    trousers.count = 1500;
                    trousers.chupin = true;
                    labelUnitStock.Text = $"Unidades de stock disponibles: {trousers.count}";
                    garmentActual = trousers;
                }
                else
                {
                    var trousers = (Trousers)shop.GetGarmentToShop(1);
                    trousers.count = 500;
                    trousers.chupin = false;
                    labelUnitStock.Text = $"Unidades de stock disponibles: {trousers.count}";
                    garmentActual = trousers;
                }

            }
        }

        private void checkBoxShortSleeve_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShortSleeve.Enabled)
            {
                if (checkBoxShortSleeve.Checked)
                {
                    var shirts = (Shirts)shop.GetGarmentToShop(0);
                    shirts.shortSleeve = true;
                    if (shirts.maoNeck)
                        shirts.count = 200;
                    else
                        shirts.count = 500;
                    labelUnitStock.Text = $"Unidades de stock disponibles: {shirts.count}";
                    garmentActual = shirts;
                }
                else
                {
                    var shirts = (Shirts)shop.GetGarmentToShop(0);
                    shirts.shortSleeve = false;
                    if (shirts.maoNeck)
                        shirts.count = 300;
                    else
                        shirts.count = 500;
                    labelUnitStock.Text = $"Unidades de stock disponibles: {shirts.count}";
                    garmentActual = shirts;
                }
            }
        }

        private void checkBoxMaoNeck_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMaoNeck.Enabled)
            {
                if (checkBoxMaoNeck.Checked)
                {
                    var shirts = (Shirts)shop.GetGarmentToShop(0);
                    shirts.maoNeck = true;
                    if (shirts.shortSleeve)
                        shirts.count = 200;
                    else
                        shirts.count = 500;
                    labelUnitStock.Text = $"Unidades de stock disponibles: {shirts.count}";
                    garmentActual = shirts;
                }
                else
                {
                    var shirts = (Shirts)shop.GetGarmentToShop(0);
                    shirts.maoNeck = false;
                    if(shirts.shortSleeve)
                        shirts.count = 300;
                    else
                        shirts.count = 500;
                    labelUnitStock.Text = $"Unidades de stock disponibles: {shirts.count}";
                    garmentActual = shirts;
                }
            }
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {
                if(textPrice.Text != string.Empty)
                garmentActual.priceUnit = float.Parse(textPrice.Text);
        }

        private void radioButtonPremium_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPremium.Checked)
            {
                if (radioButtonTrousers.Checked)
                {
                    var trousers = (Trousers)shop.GetGarmentToShop(1);
                    trousers.quality = QualityGarment.premium;
                    if(trousers.chupin)
                    {
                        trousers.count = 750;
                        labelUnitStock.Text = $"Unidades de stock disponibles: {trousers.count}";
                    }
                    garmentActual = trousers;
                }
                else if(radioButtonShirt.Checked)
                {
                    var shirts = (Shirts)shop.GetGarmentToShop(0);
                    shirts.quality = QualityGarment.premium;
                    if(shirts.shortSleeve)
                    {
                        if (shirts.maoNeck)
                            shirts.count = 100;
                        else
                            shirts.count = 150;
                    }
                    else if (!shirts.shortSleeve)
                    {
                        if (shirts.maoNeck)
                            shirts.count = 75;
                        else
                            shirts.count = 175;
                    }
                    labelUnitStock.Text = $"Unidades de stock disponibles: {shirts.count}";
                    garmentActual = shirts;

                }
            }
        }

        private void radioButtonStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPremium.Checked)
            {
                if (radioButtonTrousers.Checked)
                {
                    var trousers = (Trousers)shop.GetGarmentToShop(1);
                    trousers.quality = QualityGarment.standard;
                    if (!trousers.chupin)
                    {
                        trousers.count = 250;
                        labelUnitStock.Text = $"Unidades de stock disponibles: {trousers.count}";
                    }
                    garmentActual = trousers;
                }
                else if (radioButtonShirt.Checked)
                {
                    var shirts = (Shirts)shop.GetGarmentToShop(0);
                    shirts.quality = QualityGarment.standard;
                    if (shirts.shortSleeve)
                    {
                        if (shirts.maoNeck)
                            shirts.count = 100;
                        else
                            shirts.count = 150;
                    }
                    else if (!shirts.shortSleeve)
                    {
                        if (shirts.maoNeck)
                            shirts.count = 75;
                        else
                            shirts.count = 175;
                    }
                    labelUnitStock.Text = $"Unidades de stock disponibles: {shirts.count}";
                    garmentActual = shirts;
                }
            }
        }

        private void buttonQuote_Click(object sender, EventArgs e)
        {
            if (!radioButtonShirt.Checked && !radioButtonTrousers.Checked)
            {
                MessageBox.Show("Por favor antes de cotizar, seleccione una prenda, calidad, precio y cantidad", "Atencion!!");
            }
            else if (texCount.Text == string.Empty && texCount.Enabled)
            {
                MessageBox.Show("Por favor escriba un valor acorde a la cantidad de stock", "Atencion!!");
            }
            else if(textPrice.Text == string.Empty && texCount.Enabled)
            {
                MessageBox.Show("Por favor escriba un precio por la unidad", "Atencion!!");
            }
            else if (!radioButtonPremium.Checked && !radioButtonStandard.Checked)
            {
                MessageBox.Show("Por favor seleccione una calidad para la prenda elegida", "Atencion!!");
            }
            else if (int.Parse(texCount.Text) > garmentActual.count || texCount.Text == string.Empty)
            {
                MessageBox.Show("No hay Stock de esa cantidad, por favor escriba un valor acorde a la cantidad de stock", "Atencion!!");
            }
            else
            {
                garmentActual.priceUnit = float.Parse(textPrice.Text);
                var quote = new Quote(seller.SellerCode,int.Parse(texCount.Text));
                if (radioButtonTrousers.Checked)
                {
                    quote.CalculateQuoteTrousers((Trousers)garmentActual);
                }
                else if(radioButtonShirt.Checked)
                {
                    quote.CalculateQuoteShirts((Shirts)garmentActual);
                }

                labelResult.Text = quote.QuotedResult.ToString();
                seller.RegistreryQuote(quote);
            }
        }

        private void labelHistoryQuotes_Click(object sender, EventArgs e)
        {
            Form2 formQuotedList = new Form2();
            formQuotedList.Show(); 
            formQuotedList.UpdateListQuotedList(seller.GetListQuotes());
        }
    }
}
