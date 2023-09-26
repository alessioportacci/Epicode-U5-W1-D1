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
    public partial class AggiungiPagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Aggiungi_Click(object sender, EventArgs e)
        {
            double importo = Double.Parse(Importo.Text);
            bool stipendio = Stipendio.Checked;

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [T_Pagamenti] VALUES (@Somma, @Data, @Stipendio, @FkCliente)", conn);
            cmd.Parameters.AddWithValue("Somma", importo);
            cmd.Parameters.AddWithValue("Data", DateTime.Now);
            cmd.Parameters.AddWithValue("Stipendio", stipendio);
            cmd.Parameters.AddWithValue("FkCliente", Request.QueryString["Id"]);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}