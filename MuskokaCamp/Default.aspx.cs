using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MuskokaCamp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void passwordSubmit_Click(object sender, EventArgs e)
        {
            var x = password.Text;
            var y = "Getcamper121";
            if (x == y )
            {
                Response.Redirect("Staff/StaffDashboard.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Wrong Password, Please Try Again!')", true);
            }
        }
    }
}