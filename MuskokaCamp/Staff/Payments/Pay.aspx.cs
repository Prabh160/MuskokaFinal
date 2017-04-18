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
    public partial class Pay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (IsPostBack == false)
            {
                getPayment();

                //check id so that we can edit or add
                if (!String.IsNullOrEmpty(Request.QueryString["camperID"]))
                {
                    //get id from URL
                    Int32 camperID = Convert.ToInt32(Request.QueryString["camperID"]);

                    //Connect
                    var conn = new muskokaEntities();

                    //look up the selected campers

                    var objCamper = (from c in conn.camperProfiles
                                     where c.camperID == camperID
                                     select c).FirstOrDefault();

                    var objPayment = (from p in conn.payments
                                      where p.camperID == camperID
                                      select p).FirstOrDefault();

                    //run the query using LINQ
                    var payment = from p in conn.payments
                                  where p.camperID == camperID
                                  select p;

                    //display the query results in grid view
                    grdPayment.DataSource = payment.ToList();
                    grdPayment.DataBind();

                    //populate the camper form
                    familyName.Text = objCamper.familyName;
                    firstName.Text = objCamper.firstName;
                    rate.Text = "$" + objCamper.rate;

                }

            }
        }
        protected void getPayment()
        {
            //connect to db
            var conn = new muskokaEntities();

        }

        protected void submitPayment_Click(object sender, EventArgs e)
        {
        
            //connect to db
            var db = new muskokaEntities();

                // create new payment in the memory
                payment pay = new payment();
        
          
                //fill properties to make a payment
                pay.date = datebox1.Text;
                pay.amount = "$" + makePayment.Text;
                pay.payment_type = payType.SelectedItem.Text;
                pay.camperID = Convert.ToInt32(Request.QueryString["camperID"]);

                //save the new object to the database
                db.payments.Add(pay);
                db.SaveChanges();

                //redirect
                Response.Redirect("Index.aspx");
            
            }
        }
    }   