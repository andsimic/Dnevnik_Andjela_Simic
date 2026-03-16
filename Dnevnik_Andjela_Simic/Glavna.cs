using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnevnik_Andjela_Simic
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nova = new Form1();
            nova.ShowDialog();
        }

        private void upisnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upisnica nova = new Upisnica();
            nova.ShowDialog();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sifarnik nova = new Sifarnik("smer");
            nova.ShowDialog();
        }

        private void predmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik nova = new Sifarnik("predmet");
            nova.ShowDialog();
        }

        private void skolskaGodinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik nova = new Sifarnik("skolska_godina");
            nova.ShowDialog();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

