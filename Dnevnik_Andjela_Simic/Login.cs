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

namespace Dnevnik_Andjela_Simic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection veza = konekcija.povezi();
            SqlCommand naredba = new SqlCommand("SELECT pass FROM osoba WHERE email = '" + textBox1.Text + "'", veza);
            SqlDataAdapter adapt = new SqlDataAdapter(naredba);
            DataTable tabela = new DataTable();
            adapt.Fill(tabela);
            int count = tabela.Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("Neispravan e-mail");
            }
            else
            {
                if (tabela.Rows[0]["pass"].ToString() != textBox2.Text)
                {
                    MessageBox.Show("Neispravna lozinka ");
                }
                else
                {
                    this.Hide();
                    Glavna nova = new Glavna();
                    nova.Show();

                }
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
