using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dnevnik_Andjela_Simic
{
    public partial class Osoba : Form
    {
        int br_sloga = 0;
        DataTable tabela;
        public Osoba()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            SqlConnection veza = konekcija.povezi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba",veza);
            tabela = new DataTable();
            da.Fill(tabela);
        }
        private void Txt_Load()
        {
            if (tabela.Rows.Count == -1)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_adresa.Text = "";
                txt_jmbg.Text = "";
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_uloga.Text = "";
            }
            else
            {
                txt_id.Text = tabela.Rows[br_sloga]["id"].ToString();
                txt_ime.Text = tabela.Rows[br_sloga]["ime"].ToString();
                txt_prezime.Text = tabela.Rows[br_sloga]["prezime"].ToString();
                txt_adresa.Text = tabela.Rows[br_sloga]["adresa"].ToString();
                txt_jmbg.Text = tabela.Rows[br_sloga]["jmbg"].ToString();
                txt_email.Text = tabela.Rows[br_sloga]["email"].ToString();
                txt_pass.Text = tabela.Rows[br_sloga]["pass"].ToString();
                txt_uloga.Text = tabela.Rows[br_sloga]["uloga"].ToString();
            }
            if(br_sloga == 0)
            {
                button6.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
                button7.Enabled = true;
            }
            if (br_sloga == tabela.Rows.Count - 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }
        private void Osoba_Load(object sender, EventArgs e)
        {
            Load_Data();
            Txt_Load();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            br_sloga--;
            Txt_Load();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            br_sloga = 0;
            Txt_Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            br_sloga++;
            Txt_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            br_sloga = tabela.Rows.Count - 1;
            Txt_Load();
        }
    }
}
