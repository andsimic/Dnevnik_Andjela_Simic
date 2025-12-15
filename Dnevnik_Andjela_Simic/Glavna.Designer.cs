namespace Dnevnik_Andjela_Simic
{
    partial class Glavna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonX = new System.Windows.Forms.Button();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odeljenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skolskaGodinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poOdeljenjuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poNastavnikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poUcenikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upisnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(135)))), ((int)(((byte)(95)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 505);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.buttonX);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 497);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekeToolStripMenuItem,
            this.izvestajiToolStripMenuItem,
            this.dokumentaToolStripMenuItem,
            this.administracijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekeToolStripMenuItem
            // 
            this.datotekeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.datotekeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobaToolStripMenuItem,
            this.odeljenjeToolStripMenuItem,
            this.skolskaGodinaToolStripMenuItem,
            this.predmetToolStripMenuItem});
            this.datotekeToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datotekeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.datotekeToolStripMenuItem.Name = "datotekeToolStripMenuItem";
            this.datotekeToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.datotekeToolStripMenuItem.Text = "Datoteke";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poOdeljenjuToolStripMenuItem,
            this.poNastavnikuToolStripMenuItem,
            this.poUcenikuToolStripMenuItem});
            this.izvestajiToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izvestajiToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // dokumentaToolStripMenuItem
            // 
            this.dokumentaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dokumentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upisnicaToolStripMenuItem,
            this.raspodelaToolStripMenuItem,
            this.ocenaToolStripMenuItem});
            this.dokumentaToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dokumentaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.dokumentaToolStripMenuItem.Name = "dokumentaToolStripMenuItem";
            this.dokumentaToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.dokumentaToolStripMenuItem.Text = "Dokumenta";
            // 
            // administracijeToolStripMenuItem
            // 
            this.administracijeToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administracijeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.administracijeToolStripMenuItem.Name = "administracijeToolStripMenuItem";
            this.administracijeToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.administracijeToolStripMenuItem.Text = "Administracije";
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.buttonX.Location = new System.Drawing.Point(417, 12);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(28, 23);
            this.buttonX.TabIndex = 23;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.osobaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.osobaToolStripMenuItem.Text = "Osoba";
            this.osobaToolStripMenuItem.Click += new System.EventHandler(this.osobaToolStripMenuItem_Click);
            // 
            // odeljenjeToolStripMenuItem
            // 
            this.odeljenjeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.odeljenjeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.odeljenjeToolStripMenuItem.Name = "odeljenjeToolStripMenuItem";
            this.odeljenjeToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.odeljenjeToolStripMenuItem.Text = "Odeljenje";
            // 
            // skolskaGodinaToolStripMenuItem
            // 
            this.skolskaGodinaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.skolskaGodinaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.skolskaGodinaToolStripMenuItem.Name = "skolskaGodinaToolStripMenuItem";
            this.skolskaGodinaToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.skolskaGodinaToolStripMenuItem.Text = "Skolska godina";
            // 
            // predmetToolStripMenuItem
            // 
            this.predmetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.predmetToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.predmetToolStripMenuItem.Name = "predmetToolStripMenuItem";
            this.predmetToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.predmetToolStripMenuItem.Text = "Predmet";
            // 
            // poOdeljenjuToolStripMenuItem
            // 
            this.poOdeljenjuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.poOdeljenjuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.poOdeljenjuToolStripMenuItem.Name = "poOdeljenjuToolStripMenuItem";
            this.poOdeljenjuToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.poOdeljenjuToolStripMenuItem.Text = "Po odeljenju";
            // 
            // poNastavnikuToolStripMenuItem
            // 
            this.poNastavnikuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.poNastavnikuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.poNastavnikuToolStripMenuItem.Name = "poNastavnikuToolStripMenuItem";
            this.poNastavnikuToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.poNastavnikuToolStripMenuItem.Text = "Po nastavniku";
            // 
            // poUcenikuToolStripMenuItem
            // 
            this.poUcenikuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.poUcenikuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.poUcenikuToolStripMenuItem.Name = "poUcenikuToolStripMenuItem";
            this.poUcenikuToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.poUcenikuToolStripMenuItem.Text = "Po uceniku";
            // 
            // upisnicaToolStripMenuItem
            // 
            this.upisnicaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.upisnicaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.upisnicaToolStripMenuItem.Name = "upisnicaToolStripMenuItem";
            this.upisnicaToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.upisnicaToolStripMenuItem.Text = "Upisnica";
            this.upisnicaToolStripMenuItem.Click += new System.EventHandler(this.upisnicaToolStripMenuItem_Click);
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.raspodelaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.raspodelaToolStripMenuItem.Text = "Raspodela";
            // 
            // ocenaToolStripMenuItem
            // 
            this.ocenaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.ocenaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(165)))));
            this.ocenaToolStripMenuItem.Name = "ocenaToolStripMenuItem";
            this.ocenaToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.ocenaToolStripMenuItem.Text = "Ocena";
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(489, 529);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavna";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracijeToolStripMenuItem;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odeljenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skolskaGodinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poOdeljenjuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poNastavnikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poUcenikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upisnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocenaToolStripMenuItem;
    }
}