using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_U5_W1_D1_2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from V_Dipendenti", conn);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Dipendenti> dipendentiList = new List<Dipendenti>();
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Dipendenti dipendente = new Dipendenti();
                dipendente.PkDipendente =Int32.Parse(sqlDataReader["PkDipendente"].ToString());
                dipendente.Nome = sqlDataReader["Nome"].ToString();
                dipendente.Cognome = sqlDataReader["Cognome"].ToString();
                dipendente.Indirizzo = sqlDataReader["Indirizzo"].ToString();
                dipendente.CF = sqlDataReader["CF"].ToString();
                dipendente.Sposato = sqlDataReader["Sposato"].ToString() == "True" ? "Si" : "No";
                dipendente.FigliACarico = Int32.Parse(sqlDataReader["FigliACarico"].ToString());
                dipendente.Mansione = sqlDataReader["Mansione"].ToString();

                dipendentiList.Add(dipendente);
            }

            Repeater1.DataSource = dipendentiList;
            Repeater1.DataBind();

        }
    }
}