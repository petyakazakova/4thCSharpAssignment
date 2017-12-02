using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4thCSharpHandIn
{
    public partial class PatientDashboard : System.Web.UI.Page
    {
        private string filename; // where we store users data
            
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PatLog"] != null && !Page.IsPostBack)
            {
                //LabelPDash.Text = (string)Session["PatLog"];
                //Patient p = (Patient)Session["PatLog"];
                //LabelPDash.Text = p.Name;
                LabelPDash.Text = Session["PatLog"].ToString();
            }

            filename = Server.MapPath("~/App_Data/patientslistdata.ser");            
        }

        protected void ButtonEditP_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientEdit.aspx");
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Home.aspx");
        }
    }    
} 