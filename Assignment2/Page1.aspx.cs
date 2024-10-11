using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Assignment2
{
    public partial class Page1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Server=LAPTOP-T65PDTRN\SQLEXPRESS;Database=Practice; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string qry = " ";
            if (!string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                qry += " and Company_Name like '%"+TextBox1.Text+"%' ";
            }
            if (!string.IsNullOrWhiteSpace(TextBox2.Text))
            {

                qry += " and Skills like '%"+TextBox2.Text+"%' ";
            }
            if (!string.IsNullOrWhiteSpace(TextBox3.Text))
            {
                qry += " and Experience like '%"+TextBox3.Text+"%' ";
            }
            
            string s = "Select * from Company where 1=1 " + qry;
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}