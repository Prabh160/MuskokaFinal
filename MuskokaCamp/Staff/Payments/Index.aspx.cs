using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//add success the database
using System.Web.ModelBinding;

namespace MuskokaCamp.Staff.Payments
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getCampers();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }
        protected void getCampers()
        {
            //connect to db
            var conn = new muskokaEntities();

            //run the query using LINQ
            var Campers = from c in conn.camperProfiles
                          select c;
            //display the query results in grid view
            grdCampers.DataSource = Campers.ToList();
            grdCampers.DataBind();
        }
    }
}