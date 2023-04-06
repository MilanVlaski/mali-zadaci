using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Ispit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblVrijeme.Text = DateTime.Now.ToString();
            KeyPreview = true;
        }

        private void timerTick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString();
        }
        
        private void izracunaj()
        {
            if (cmbBoxSnaga.Text == "" && txtBoxBrSati.Text == "")
            {
                MessageBox.Show("Niste unijeli potrebne informacije", "Pogresan unos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                try
                {
                    float kolicinaPeleta = Properties.Settings.Default.kolicina;
                    float kalorijskaMoc = Properties.Settings.Default.kalorijskaMoc;
                    float radSnage = 0;
                    float pauzaSnage = 0;
                    float brSati = float.Parse(txtBoxBrSati.Text);

                    switch (cmbBoxSnaga.Text)
                    {
                        case "P1":
                            radSnage = Properties.Settings.Default.P1_Rad;
                            pauzaSnage = Properties.Settings.Default.P1_Pauza;
                            break;
                        case "P2":
                            radSnage = Properties.Settings.Default.P2_Rad;
                            pauzaSnage = Properties.Settings.Default.P2_Pauza;
                            break;
                        case "P3":
                            radSnage = Properties.Settings.Default.P3_Rad;
                            pauzaSnage = Properties.Settings.Default.P3_Pauza;
                            break;
                        default:
                            MessageBox.Show("Pogresno ste unijeli snagu.", "Pogresan unos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                    }

                    float potrosnjaPoSatu = (kolicinaPeleta / 1000) * (radSnage * 60) / (radSnage + pauzaSnage);
                    float snaga = potrosnjaPoSatu * kalorijskaMoc;
                    float potrosnjaPoDanu = potrosnjaPoSatu * brSati;

                    lblSnaga.Text = snaga.ToString("0.00") + " kW";
                    lblPotrosnjaSat.Text = potrosnjaPoSatu.ToString("0.00") + " kg/h";
                    lblPotrosnjaDan.Text = potrosnjaPoDanu.ToString("0.00") + " kg/dan";
                }
                catch
                {
                    MessageBox.Show("Pogresno ste unijeli informacije.", "Pogresan unos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btnIzracunajClick(object sender, EventArgs e)
        {
            izracunaj();
        }

        private void btnEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            btnIzracunaj.PerformClick();
        }

        private void btnIzlazClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPodesavanjeClick(object sender, EventArgs e)
        {
            new PodesavanjaForm().ShowDialog();

        }
    }
}
