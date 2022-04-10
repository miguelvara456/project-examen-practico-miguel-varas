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
        public Form2(List<Quote> list)
        {
            InitializeComponent();
            foreach (var quote in list)
            {
                listBoxQuotes.Items.Add(quote);
            }
        }
    }
}
