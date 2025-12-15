using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Dnevnik_Andjela_Simic
{
    internal class konekcija
    {
        public static SqlConnection povezi()
        {
            string CS;
            CS = ConfigurationManager.ConnectionStrings["pocetna"].ConnectionString;
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }
    }
}
