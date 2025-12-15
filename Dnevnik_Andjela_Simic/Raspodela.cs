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
    public partial class Raspodela : Form
    {
        public Raspodela()
        {
            InitializeComponent();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Raspodela_Load(object sender, EventArgs e)
        {

            SqlConnection veza = konekcija.povezi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable sk_godina = new DataTable();
            da.Fill(sk_godina);
            comboBox1.DataSource = sk_godina;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "naziv";
        }
    }
}
