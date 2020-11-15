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
        private List<Pekaru> pekaru;
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
            if (PekaruLista.SelectedIndex >= 0)
            {
                Pekaru p = (Pekaru)PekaruLista.SelectedItem;
                pekaruNev.Text = p.Nev;
                pekaruAr.Text = Convert.ToString(p.Ar);
                torles.Visible = true;
            }
            else
            {
                pekaruNev.Text = "";
                pekaruAr.Text = "";
            }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            PekaruLista.Items.RemoveAt(PekaruLista.SelectedIndex);
            PekaruLista.SelectedIndex = -1;
            torles.Visible = false;
        }

        private void PeksegHozzaAd_Click(object sender, EventArgs e)
        {
            if (peksegNev.Text!="")
            {
                pekaru = new List<Pekaru>();

                Pekseg p = new Pekseg(peksegNev.Text, pekaru, DateTime.Now);
                PeksegLista.Items.Add(p);
                PeksegStat.Items.Add(p);
            }
        }

        private void hozzaAdpekaru_Click(object sender, EventArgs e)
        {
            PekaruLista2.Items.Clear();
          
                var psideiglenes = PeksegLista.SelectedItem;
                Pekseg p = (Pekseg)psideiglenes;
                var paideiglenes = PekaruLista.SelectedItem;
                Pekaru pa = (Pekaru)paideiglenes;
          
                p.Termekek.Add(pa);
                
                for (int i = 0; i < p.Termekek.Count; i++)
                {
                    PekaruLista2.Items.Add(p.Termekek[i]);
                }
            
        }

        private void PeksegStat_SelectedIndexChanged(object sender, EventArgs e)
        {
                var psideiglenes = PeksegStat.SelectedItem;
                Pekseg p = (Pekseg)psideiglenes;
                label1.Text = p.Nev;
                label2.Text += p.Alapitva;
                label3.Text += p.Termekek.Count + " db";
                int sum=0;
                foreach (var item in p.Termekek)
                {
                    sum += item.Ar;
                }
                label4.Text += (sum / p.Termekek.Count) + " Ft";
                List<int> arak = new List<int>();
                int min = p.Termekek[0].Ar;
                int minindex = 0;
                for (int i = 0; i < p.Termekek.Count; i++)
                {
                    if (p.Termekek[i].Ar<min)
                    {
                        min = p.Termekek[i].Ar;
                        minindex = i;
                    }
                }
                label5.Text += p.Termekek[minindex];
                int max = p.Termekek[0].Ar;
                int maxindex = 0;
                for (int i = 0; i < p.Termekek.Count; i++)
                {
                    if (p.Termekek[i].Ar > min)
                    {
                        max = p.Termekek[i].Ar;
                        maxindex = i;
                    }
                }
                label6.Text += p.Termekek[maxindex];
                double db = 0;
                foreach (var item in p.Termekek)
                {
                    if (item.Laktozmentes)
                    {
                        db++;
                    }
                }
            double atlag = db / (double)p.Termekek.Count * 100;
                label7.Text += db + ", " + atlag + "%";
        }
    }
}
