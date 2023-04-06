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
    public partial class PodesavanjaForm : Form
    {
        private  float p1Rad = Properties.Settings.Default.P1_Rad;
        private  float p1Pauza = Properties.Settings.Default.P1_Pauza;
        private  float p2Rad = Properties.Settings.Default.P2_Rad;
        private  float p2Pauza = Properties.Settings.Default.P2_Pauza;
        private  float p3Rad = Properties.Settings.Default.P3_Rad;
        private  float p3Pauza = Properties.Settings.Default.P3_Pauza;
        private float kalorijskaMoc = Properties.Settings.Default.kalorijskaMoc;
        private float kolicina = Properties.Settings.Default.kolicina;

        public PodesavanjaForm()
        {
            InitializeComponent();
            textBox1.Text = p1Rad.ToString("0.00");
            textBox2.Text = p1Pauza.ToString("0.00");
            textBox4.Text = p2Rad.ToString("0.00");
            textBox3.Text = p2Pauza.ToString("0.00");
            textBox6.Text = p3Rad.ToString("0.00");
            textBox5.Text = p3Pauza.ToString("0.00");
            textBox8.Text = kalorijskaMoc.ToString("0.00");
            textBox7.Text = kolicina.ToString("0.00");
        }

        private void btnSnimiClick(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.P1_Rad = float.Parse(textBox1.Text);
                Properties.Settings.Default.P1_Pauza = float.Parse(textBox2.Text);
                Properties.Settings.Default.P2_Rad = float.Parse(textBox4.Text);
                Properties.Settings.Default.P2_Pauza = float.Parse(textBox3.Text);
                Properties.Settings.Default.P3_Rad = float.Parse(textBox6.Text);
                Properties.Settings.Default.P3_Pauza = float.Parse(textBox5.Text);
                Properties.Settings.Default.kalorijskaMoc = float.Parse(textBox8.Text);
                Properties.Settings.Default.kolicina = float.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("Pogresno ste unijeli snage.", "Pogresan unos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}


