using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["ConexiónNorthwind"];
                SqlConnection conexion = new SqlConnection(connString.ConnectionString);

                using (SqlCommand cmd = new SqlCommand("SalesByCategory", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = "Seafood";
                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            GridV.DataSource = reader;
                            GridV.DataBind();
                        }
                    }
                }
            }
        }
    }
}
