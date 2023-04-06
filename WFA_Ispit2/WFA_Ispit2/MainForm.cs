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
    public partial class MainForm : Form
    {
        public string brSjedista;
        public MainForm()
        {
            InitializeComponent();
            lblVrijeme.Text = DateTime.Now.ToString();
        }

        private void btnSjedistaClick(object sender, EventArgs e)
        {
            if (tbPutnik.Text != "") 
            {
                string putnik = tbPutnik.Text;
                string brSjedistaGlavneForme = tbSjediste.Text;
                SjedistaForm frmSjedista = new SjedistaForm(putnik, brSjedistaGlavneForme);
                frmSjedista.ShowDialog();
                if(frmSjedista.DialogResult == DialogResult.OK)
                {
                    tbSjediste.Text = frmSjedista.brSjedista;
                }
             }
            
        }

        private void timerTick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString();
        }

        private void btnRezervisiClick(object sender, EventArgs e)
        {
            tbPutnik.Clear();
            tbSjediste.Clear();
            cbKategorija.Text = "";
            cbLinija.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }
    }
}
