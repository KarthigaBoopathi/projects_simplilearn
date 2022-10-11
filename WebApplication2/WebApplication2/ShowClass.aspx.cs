using BAL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ShowClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            schooldetails b = new schooldetails();
            List<classes> products = new List<classes>();
            products = b.GetProducts();

            GridView1.DataSource = products;
            GridView1.DataBind();

        }
    }
}