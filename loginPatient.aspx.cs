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
    public partial class loginPatient : System.Web.UI.Page
    {
        List<Patient> patientslist = new List<Patient>();
        private List<Patient> patientslistdesr;
        private string filename; // where we store users data

        public string email;
        public string password;

        protected void Page_Load(object sender, EventArgs e)
        {
            Deserialise();
        }

        private string FindUser(string email, string password)
        {
            foreach (Patient pat in patientslistdesr)
            {
                if (pat.Email == email && pat.Password == password)
                {
                    Session["PatLog"] = pat;
                    // return email.ToString();
                }
            }

            return null;
        }

        public void Deserialise()
        {
            filename = Server.MapPath("~/App_Data/patientslistdata.ser"); //decalring the path to the serializedfile
            patientslistdesr = new List<Patient>(); //am creating an instance variable
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None)) //opening afile stream to readfrom the file in the given path
            {
                BinaryFormatter bf = new BinaryFormatter();
                patientslistdesr = (List<Patient>)bf.Deserialize(fs);
                fs.Close();
            }

            PatGridview.DataSource = patientslistdesr;
            PatGridview.DataBind();
        }

        protected void ButtonLoginP_Click(object sender, EventArgs e)
        {
            string password = TextBoxLoginPpass.Text;
            string email = TextBoxPEmailLogIn.Text;


            if (patientslistdesr.Count > 0)
            {
                FindUser(email, password);
                //Session["PatLog"] = FindUser(email, password);
                //LabelLogInD.Text = (string)Session["PatLog"];
                Response.Redirect("PatientDashboard.aspx");
            }

        }

        protected void ReadFileButton_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonAddPatient_Click()
        {

        }

        protected void ButtonAddPatient_Click(object sender, EventArgs e)
        {
            Response.Redirect("Patients.aspx");
        }

        protected void PatGridview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}