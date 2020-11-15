using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pekaruHozzaAd_Click(object sender, EventArgs e)
        {
            if (pekaruNev.Text!="" && pekaruAr.Text!="") 
            {
                bool l = laktozmentes.Checked;
                Pekaru p = new Pekaru(pekaruNev.Text, Convert.ToInt32(pekaruAr.Text), l);
                PekaruLista.Items.Add(p);
            }
        }

        private void PekaruLista_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
