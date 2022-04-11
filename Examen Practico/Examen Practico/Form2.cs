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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void UpdateListQuotedList(List<Quote> list)
        {
            foreach (var quote in list)
            {
                var descriptionQuote = $"ID: {quote.NumberId} | Prenda: {quote.QuotedGarment.GetType().Name} | Unidades: {quote.QuotedUnits} | Hora y Fecha: {quote.DateHour} | Codigo Vendedor: {quote.SellerCode} | Total: {quote.QuotedResult}";
                listBoxQuotes.Items.Add(descriptionQuote);
            }
        }
    }
}
