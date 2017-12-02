using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4thCSharpHandIn
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGoPatientsP_Click(object sender, EventArgs e)
        {
            Response.Redirect("Patients.aspx");
        }

        protected void ButtonGoDentistsP_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dentist.aspx");
        }
    }
}