using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Ispit2
{
    public partial class SjedistaForm : Form
    {
        public string brSjedista {get; set;}
        public SjedistaForm(string putnik, string brojSjedistaGlavneForme)
        {
            InitializeComponent();
            this.Text += putnik;
            lblVrijeme.Text = DateTime.Now.ToString();
            foreach(Control ctrl in panel1.Controls)
            {
                if(brojSjedistaGlavneForme == ctrl.Text)
                {
                    Button btn = (Button)ctrl;
                    btn.BackColor = Color.PaleVioletRed;
                }
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            brSjedista = btn.Text;
            this.DialogResult = DialogResult.OK;
            
            this.Close();
        }

        private void timerTick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString();
        }
    }
}
