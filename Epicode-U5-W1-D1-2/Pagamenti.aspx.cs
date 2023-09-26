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
    public partial class Pagamenti1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDb"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from V_Pagamenti", conn);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Pagamenti> pagamentiList = new List<Pagamenti>();
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Pagamenti pagamento = new Pagamenti();
                pagamento.Somma = Double.Parse(sqlDataReader["Somma"].ToString());
                pagamento.Data = DateTime.Parse(sqlDataReader["Data"].ToString());
                pagamento.Nome = sqlDataReader["Nome"].ToString() + sqlDataReader["Cognome"].ToString();

                pagamentiList.Add(pagamento);
            }

            Repeater1.DataSource = pagamentiList;
            Repeater1.DataBind();
        }
    }
}