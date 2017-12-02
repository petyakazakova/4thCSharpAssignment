using System;
using System.Collections.Generic;
using System.IO; // allows reading and writing to files and data streams
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4thCSharpHandIn
{
    public partial class CreatePatient : System.Web.UI.Page
    {
        List<Patient> patientslist = new List<Patient>();
        private string filename; // where we store users data

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Application["SelectedPatient"] = null;
                MessagePatientForm.Text = (string)Application["SelectedPatient"];
            }

            // create file
            filename = Server.MapPath("~/App_Data/patientslistdata.ser");

            if (Application["PatientList"] == null)
            {
                Application["PatientList"] = new List<Patient>(); // makes a new empty list of patients
            }

            patientslist = (List<Patient>)Application["PatientList"];

        }

        private void UpdatePatient()
        {
            foreach (Patient pat in (List<Patient>)Application["PatientList"])
            {
                patientslist.Add(pat); // create a var for adding new pat
            }

            for (int i = 0; i < patientslist.Count(); i++)
            {
                if (i == Convert.ToInt32(Application["SelectedPatient"]))
                {
                    Patient pat = patientslist[i];
                    TextBoxPatientName.Text = pat.Name;
                    TextBoxPatientAge.Text = pat.Age.ToString();
                    TextBoxPatientPassword.Text = pat.Password;
                    TextBoxPatientEmail.Text = pat.Email;
                    TextBoxPatientCPR.Text = pat.CPR.ToString();
                }
            }
        }


        // SAVE TO FILE
        protected void ButtonSavePatientFile_Click(object sender, EventArgs e)
        {
            patientslist = (List<Patient>)Application["PatientList"];

            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, patientslist);
            fs.Close();

            MessagePatientForm.Text = "Patient list saved to file.";

        }

        // ADD
        protected void ButtonAddPatientList_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient(TextBoxPatientName.Text, Int32.Parse(TextBoxPatientAge.Text), TextBoxPatientPassword.Text, TextBoxPatientEmail.Text, Int32.Parse(TextBoxPatientCPR.Text));

            Application.Lock();
            patientslist = (List<Patient>)Application["PatientList"];
            patientslist.Add(pat);
            Application["PatientList"] = patientslist;
            Application.UnLock();

            TextBoxPatientName.Text = "";
            TextBoxPatientAge.Text = "";
            TextBoxPatientPassword.Text = "";
            TextBoxPatientEmail.Text = "";
            TextBoxPatientCPR.Text = "";

            MessagePatientForm.Text = "Patient added to Patients list. You can login as a patient.";
        }

    }
}