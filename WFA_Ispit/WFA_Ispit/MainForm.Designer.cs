namespace WFA_Ispit
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmbBoxSnaga = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.podesavanjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazIzAplikacijeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxBrSati = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPotrosnjaDan = new System.Windows.Forms.Label();
            this.lblPotrosnjaSat = new System.Windows.Forms.Label();
            this.lblSnaga = new System.Windows.Forms.Label();
            this.grpBoxPodaci = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpBoxPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBoxSnaga
            // 
            this.cmbBoxSnaga.FormattingEnabled = true;
            this.cmbBoxSnaga.Items.AddRange(new object[] {
            "P1",
            "P2",
            "P3"});
            this.cmbBoxSnaga.Location = new System.Drawing.Point(27, 54);
            this.cmbBoxSnaga.Name = "cmbBoxSnaga";
            this.cmbBoxSnaga.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxSnaga.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem1
            // 
            this.meniToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podesavanjeToolStripMenuItem1,
            this.izlazIzAplikacijeToolStripMenuItem1});
            this.meniToolStripMenuItem1.Name = "meniToolStripMenuItem1";
            this.meniToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.meniToolStripMenuItem1.Text = "Meni";
            // 
            // podesavanjeToolStripMenuItem1
            // 
            this.podesavanjeToolStripMenuItem1.Image = global::WFA_Ispit.Properties.Resources.MeniPodesavanja;
            this.podesavanjeToolStripMenuItem1.Name = "podesavanjeToolStripMenuItem1";
            this.podesavanjeToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.podesavanjeToolStripMenuItem1.Text = "Podesavanje";
            this.podesavanjeToolStripMenuItem1.Click += new System.EventHandler(this.btnPodesavanjeClick);
            // 
            // izlazIzAplikacijeToolStripMenuItem1
            // 
            this.izlazIzAplikacijeToolStripMenuItem1.Image = global::WFA_Ispit.Properties.Resources.MeniIzlaz;
            this.izlazIzAplikacijeToolStripMenuItem1.Name = "izlazIzAplikacijeToolStripMenuItem1";
            this.izlazIzAplikacijeToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.izlazIzAplikacijeToolStripMenuItem1.Text = "Izlaz iz aplikacije";
            this.izlazIzAplikacijeToolStripMenuItem1.Click += new System.EventHandler(this.btnIzlazClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberite snagu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj sati rada u danu";
            // 
            // txtBoxBrSati
            // 
            this.txtBoxBrSati.Location = new System.Drawing.Point(185, 55);
            this.txtBoxBrSati.Name = "txtBoxBrSati";
            this.txtBoxBrSati.Size = new System.Drawing.Size(118, 20);
            this.txtBoxBrSati.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVrijeme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 217);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(463, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(47, 17);
            this.lblVrijeme.Text = "Vrijeme";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnIzracunaj.FlatAppearance.BorderSize = 2;
            this.btnIzracunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzracunaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnIzracunaj.Location = new System.Drawing.Point(325, 38);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(123, 37);
            this.btnIzracunaj.TabIndex = 7;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunajClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Snaga kWh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Potrosnja kg/h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(18, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Potrosnja kg/dan";
            // 
            // lblPotrosnjaDan
            // 
            this.lblPotrosnjaDan.AutoSize = true;
            this.lblPotrosnjaDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPotrosnjaDan.ForeColor = System.Drawing.Color.Green;
            this.lblPotrosnjaDan.Location = new System.Drawing.Point(145, 61);
            this.lblPotrosnjaDan.Name = "lblPotrosnjaDan";
            this.lblPotrosnjaDan.Size = new System.Drawing.Size(0, 17);
            this.lblPotrosnjaDan.TabIndex = 13;
            // 
            // lblPotrosnjaSat
            // 
            this.lblPotrosnjaSat.AutoSize = true;
            this.lblPotrosnjaSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPotrosnjaSat.ForeColor = System.Drawing.Color.Green;
            this.lblPotrosnjaSat.Location = new System.Drawing.Point(145, 37);
            this.lblPotrosnjaSat.Name = "lblPotrosnjaSat";
            this.lblPotrosnjaSat.Size = new System.Drawing.Size(0, 17);
            this.lblPotrosnjaSat.TabIndex = 12;
            // 
            // lblSnaga
            // 
            this.lblSnaga.AutoSize = true;
            this.lblSnaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSnaga.ForeColor = System.Drawing.Color.Green;
            this.lblSnaga.Location = new System.Drawing.Point(145, 15);
            this.lblSnaga.Name = "lblSnaga";
            this.lblSnaga.Size = new System.Drawing.Size(0, 17);
            this.lblSnaga.TabIndex = 11;
            // 
            // grpBoxPodaci
            // 
            this.grpBoxPodaci.Controls.Add(this.lblPotrosnjaDan);
            this.grpBoxPodaci.Controls.Add(this.lblPotrosnjaSat);
            this.grpBoxPodaci.Controls.Add(this.lblSnaga);
            this.grpBoxPodaci.Controls.Add(this.label5);
            this.grpBoxPodaci.Controls.Add(this.label4);
            this.grpBoxPodaci.Controls.Add(this.label3);
            this.grpBoxPodaci.Location = new System.Drawing.Point(27, 100);
            this.grpBoxPodaci.Name = "grpBoxPodaci";
            this.grpBoxPodaci.Size = new System.Drawing.Size(421, 98);
            this.grpBoxPodaci.TabIndex = 14;
            this.grpBoxPodaci.TabStop = false;
            this.grpBoxPodaci.Text = "Podaci o snazi i potrosnji";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 239);
            this.Controls.Add(this.grpBoxPodaci);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtBoxBrSati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbBoxSnaga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proracun potrosnje peleta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpBoxPodaci.ResumeLayout(false);
            this.grpBoxPodaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxSnaga;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem podesavanjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izlazIzAplikacijeToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxBrSati;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVrijeme;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPotrosnjaDan;
        private System.Windows.Forms.Label lblPotrosnjaSat;
        private System.Windows.Forms.Label lblSnaga;
        private System.Windows.Forms.GroupBox grpBoxPodaci;
        private System.Windows.Forms.Timer timer;
    }
}

