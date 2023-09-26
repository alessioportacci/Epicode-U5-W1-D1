using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_U5_W1_D1_2
{
    public partial class AggiuntiUtente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Aggiungi_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [T_Dipendenti] VALUES (@Nome, @Cognome, @Indirizzo, @CF, @Sposato, @FigliACarico, 1)", conn);
            cmd.Parameters.AddWithValue("Nome", Nome.Text);
            cmd.Parameters.AddWithValue("Cognome", Cognome.Text);
            cmd.Parameters.AddWithValue("Indirizzo", Indirizzo.Text);
            cmd.Parameters.AddWithValue("CF", CF.Text);
            cmd.Parameters.AddWithValue("Sposato", Sposato.Checked);
            cmd.Parameters.AddWithValue("FigliACarico", Figli.Text);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}