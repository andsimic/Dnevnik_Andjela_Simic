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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dnevnik_Andjela_Simic
{
    public partial class Upisnica : Form
    {
        public Upisnica()
        {
            InitializeComponent();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_populate()
        {
            SqlConnection veza = konekcija.povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable godina = new DataTable();
            adapter.Fill(godina);
            comboBox2.DataSource = godina;
            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "naziv";
        }
        private void comboBox3_populate()
        {
            SqlConnection veza = konekcija.povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, razred, indeks, godina_id, str(razred)+'-'+indeks as naziv FROM odeljenje", veza);
            DataTable odeljenje = new DataTable();
            adapter.Fill(odeljenje);
            comboBox3.DataSource = odeljenje;
            comboBox3.ValueMember = "id";
            comboBox3.DisplayMember = "naziv";
        }

        private void comboBox4_populate() 
        {
            SqlConnection veza = konekcija.povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, prezime+' '+ime as naziv FROM osoba", veza);
            DataTable ucenik = new DataTable();
            adapter.Fill(ucenik);
            comboBox4.DataSource = ucenik;
            comboBox4.ValueMember = "id";
            comboBox4.DisplayMember = "naziv";
        }
        private void Upisnica_Load(object sender, EventArgs e)
        {
            comboBox2_populate();
            comboBox3_populate();
            comboBox4_populate();
            DataGridPopulate();
            textBox1.Enabled = false;

        }

       
        private void DataGridPopulate()
        {
            SqlConnection veza = konekcija.povezi();
            string naredba = "SELECT upisnica.id, ime+' '+prezime as ucenik, str(razred)+'-'+indeks as odel, odeljenje.godina_id as god_id, odeljenje.id as odel_id, osoba.id as os_id from upisnica JOIN osoba ON osoba_id=osoba.id JOIN odeljenje ON odeljenje_id=odeljenje.id";
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, veza);
            DataTable upisnica = new DataTable();
            adapter.Fill(upisnica);
            dataGridView1.DataSource = upisnica;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["god_id"].Visible = false;
            dataGridView1.Columns["odel_id"].Visible = false;
            dataGridView1.Columns["os_id"].Visible = false;
        }

        private void DataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int broj_sloga = dataGridView1.CurrentRow.Index;
                comboBox2.SelectedValue = dataGridView1.Rows[broj_sloga].Cells["god_id"].Value.ToString();
                comboBox3.SelectedValue = dataGridView1.Rows[broj_sloga].Cells["odel_id"].Value.ToString();
                comboBox4.SelectedValue = dataGridView1.Rows[broj_sloga].Cells["os_id"].Value.ToString();
                textBox1.Text = dataGridView1.Rows[broj_sloga].Cells["id"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string naredba = "INSERT INTO upisnica (odeljenje_id, osoba_id) VALUES(";
            naredba += comboBox3.SelectedValue.ToString() + ", ";
            naredba += comboBox4.SelectedValue.ToString() + ")";
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            DataGridPopulate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE upisnica SET osoba_id = " + comboBox4.SelectedValue.ToString();
            naredba += ", odeljenje_id=" + comboBox3.SelectedValue.ToString();
            naredba += " WHERE id=" + textBox1.Text;
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            DataGridPopulate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM upisnica WHERE id=" + textBox1.Text;
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            DataGridPopulate();
        }

    }
}
