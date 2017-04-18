using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using MuskokaCamp.Models;
using System.Data.SqlClient;


namespace MuskokaCamp.Parent
{
    public partial class CamperAttendence : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Show current Date
            currentDate.Text = DateTime.Now.DayOfWeek.ToString();
            currentDate2.Text = DateTime.Now.ToString("MM-dd-yyyy").Replace("-", "/");
            Getparents();
        }


        protected void Getparents()
        {
            using (muskokaEntities conn = new muskokaEntities())
            {
                var camperDates = (from cp in conn.camperProfiles

                                   join r in conn.registrationDates on cp.camperID equals r.camperID
                                   where r.date == currentDate2.Text

                                   select new { cp.camperID, cp.familyName, cp.firstName, r.signInTime, r.signOutTime, r.signedInBy, r.signedOutBy });

                grdCampers.DataSource = camperDates.ToList();

                grdCampers.DataBind();
            }
           
        }
    }
}