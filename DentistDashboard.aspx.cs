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
    public partial class DentistDashboard : System.Web.UI.Page
    {
        List<Dentist> dentistslist = new List<Dentist>();
        private string filename; // where we store users data

        List<Patient> patientslist = new List<Patient>();
        private string filename1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["DentLog"] != null && !Page.IsPostBack)
            {
                //Dentist d = (Dentist)Session["DentLog"];
                //LabelDDash.Text = "Dentist name: " + d.Name.ToString() + ". Age: " + d.Age.ToString() + ". Email: " + d.Email.ToString() + "; Password: " + d.Password.ToString();
                LabelDDash.Text = Session["DentLog"].ToString();
            }

            filename = Server.MapPath("~/App_Data/dentistslistdata.ser");

            if (Application["DentistList"] == null)
            {
                Application["DentistList"] = new List<Dentist>();
            }

            dentistslist = (List<Dentist>)Application["DentistList"];

            UpdateDentistGridView();

            //patients grid
            if (!Page.IsPostBack)
            {
                Application["SelectedPatient"] = null;
                LabelMessageP.Text = (string)Application["SelectedPatient"];
            }

            // create file
            filename1 = Server.MapPath("~/App_Data/patientslistdata.ser");

            if (Application["PatientList"] == null)
            {
                Application["PatientList"] = new List<Patient>(); // makes a new empty list of patients
            }

            patientslist = (List<Patient>)Application["PatientList"];

            UpdatePatientsGridView();
        }

        public void UpdateDentistGridView()
        {
            GridViewDList.DataSource = dentistslist;
            GridViewDList.DataBind();
        }

        public void UpdatePatientsGridView()
        {
            GridViewPList.DataSource = patientslist;
            GridViewPList.DataBind();
        }

        // READ FROM DENT LIST 
        protected void ButtonReadD_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            dentistslist = (List<Dentist>)bf.Deserialize(fs);
            fs.Close();

            Application.Lock();
            Application["DentistList"] = dentistslist;
            Application.UnLock();

            UpdateDentistGridView();
            LabelMessage.Text = "Now reading dentists from file.";
        }

        //READ FROM PAT LIST
        protected void ButtonReadP_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(filename1, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            patientslist = (List<Patient>)bf.Deserialize(fs);
            fs.Close();

            Application.Lock();
            Application["PatientList"] = patientslist;
            Application.UnLock();

            UpdatePatientsGridView();
            LabelMessageP.Text = "Now reading patients from file.";
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Home.aspx");
        }

        protected void ButtonEditD_Click(object sender, EventArgs e)
        {
            Response.Redirect("DentistEdit.aspx");
        }

        protected void GridViewPList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}