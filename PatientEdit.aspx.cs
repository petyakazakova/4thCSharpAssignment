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
    public partial class PatientEdit : System.Web.UI.Page
    {
        private List<Dentist> dentistslistdesr;
        private List<Patient> patientslistdesr;
        private static string filename;
        private static string filename1;

        //int SelectedPatientIndex; //so we can select the field for update later

        protected void Page_Load(object sender, EventArgs e)
        {
            Patient p = (Patient)Session["PatLog"];

            filename = Server.MapPath("~/App_Data/patientslistdata.ser");
            filename1 = Server.MapPath("~/App_Data/dentistslistdata.ser");

            Deserialise();

            if (Session["PatLog"] != null && !Page.IsPostBack)
            {
                LabelPatDash.Text = Session["PatLog"].ToString();
            }

            if (!Page.IsPostBack)
            {
                DeserialiseDent();

                List<string> dentistnamelist = new List<string>(); //making new list only with names
                foreach (Dentist d in dentistslistdesr)
                {
                    dentistnamelist.Add(d.Name);
                }

                GridViewDNames.DataSource = dentistnamelist;
                GridViewDNames.DataBind();                            
            }
        }

        public void DeserialiseDent()
        {
            filename1 = Server.MapPath("~/App_Data/dentistslistdata.ser"); //decalring the path to the serializedfile
            dentistslistdesr = new List<Dentist>(); //am creating an instance variable
            using (FileStream fs = new FileStream(filename1, FileMode.Open, FileAccess.Read, FileShare.None)) //opening afile stream to readfrom the file in the given path
            {
                BinaryFormatter bf = new BinaryFormatter();
                dentistslistdesr = (List<Dentist>)bf.Deserialize(fs);
                fs.Close();
            }
        }

        public void Deserialise()
        {
            //filename = Server.MapPath("~/App_Data/patientslistdata.ser"); //decalring the path to the serializedfile
            patientslistdesr = new List<Patient>();
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None))
            { //opening a file stream to readfrom the file in the given path

                BinaryFormatter bf = new BinaryFormatter();
                patientslistdesr = (List<Patient>)bf.Deserialize(fs);
                fs.Close();
            }
        }

        //SAVE
        protected void ButtonSavePatientFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, patientslistdesr);
            fs.Close();

            LabelPatDash.Text = "Patient saved to file.";
        }

        protected void ButtonUpdateSelectedPatient_Click(object sender, EventArgs e)
        {
            string name = TextBoxPatientName.Text;
            string email = TextBoxPatientEmail.Text;
            string pass = TextBoxPatientPassword.Text;

            Int32.TryParse(TextBoxPatientAge.Text, out int age);
            Int32.TryParse(TextBoxPatientCPR.Text, out int Cpr);

            Patient pat = (Patient)Session["PatLog"];
            foreach (Patient p in patientslistdesr) //p is local variable
            {
                if (pat.Email == p.Email)
                {
                    p.Name = name;
                    p.Email = email;
                    p.Password = pass;
                    p.Age = age;
                    p.CPR = Cpr;

                    LabelPatDash.Text = "Updated patient: " + pat.Name;
                }
            }            
        }

        protected void ButtonDeleteSelectedPatient_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            List<Patient> pl = (List<Patient>)bf.Deserialize(fs);
            fs.Close();

            LabelPatDash.Text = "Patient deleted.";
            Patient p = (Patient)Session["PatLog"];

            foreach (Patient pat in pl)
            {
                if (p.Email == pat.Email && p.Password == pat.Password)
                {
                    pl.Remove(pat);
                    break;
                }
            }

            // write to file
            fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            bf = new BinaryFormatter();
            bf.Serialize(fs, pl);
            fs.Close();

            // clear session
            Session["PatLog"] = null;
            Session.Clear();

            // rediretto login page
            Response.Redirect("Home.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientDashboard.aspx");
        }
    }
}













/* {

List<Dentist> dentistslist = new List<Dentist>();
List<Patient> patientslist = new List<Patient>();
private string filename; // where we store users data
private string filename1;
int SelectedPatientIndex; //so we can select the field for update later

protected void Page_Load(object sender, EventArgs e)
{
    Patient p  = (Patient)Session["PatLog"];

    filename = Server.MapPath("~/App_Data/patientslistdata.ser");
    filename = Server.MapPath("~/App_Data/dentistslistdata.ser");

    MessagePatientForm.Text = p.Name;
    Deserialise();

    PatientsGridView.DataSource = patientslist;
    PatientsGridView.DataBind();

    if (!Page.IsPostBack)
    {
        DeserialiseDent();

        List<string> dentistnamelist = new List<string>(); //making new list only with names
        //Application["SelectedPatient"] = null;
        //MessagePatientForm.Text = (string)Application["SelectedPatient"];

        foreach (Dentist d in dentistslist)
        {
            dentistnamelist.Add(d.Name);
        }

        GridViewDNames.DataSource = dentistnamelist;
        GridViewDNames.DataBind();
    }

    /* // create file
    filename = Server.MapPath("~/App_Data/patientslistdata.ser");

    if (Application["PatientList"] == null)
    {
        Application["PatientList"] = new List<Patient>(); // makes a new empty list of patients
    }

    patientslist = (List<Patient>)Application["PatientList"];

    UpdatePatientsGridView(); */
/* }

 public void DeserialiseDent()
 {
     filename1 = Server.MapPath("~/App_Data/dentistslistdata.ser");
     dentistslist = new List<Dentist>();
     using (FileStream fs = new FileStream(filename1, FileMode.Open, FileAccess.Read, FileShare.None))
     {
         BinaryFormatter bf = new BinaryFormatter();
         dentistslist = (List<Dentist>)bf.Deserialize(fs);
         fs.Close();
     }
 }

 public void Deserialise()
 {
     patientslist = new List<Patient>(); //creating an instance var
     using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None))
     {
         BinaryFormatter bf = new BinaryFormatter();
         patientslist = (List<Patient>)bf.Deserialize(fs);
         fs.Close();
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

     UpdatePatientsGridView();
     MessagePatientForm.Text = "Patient list saved to file.";

 }

 // UPDATE
 protected void ButtonUpdateSelectedPatient_Click(object sender, EventArgs e)
 {
     string name = TextBoxPatientName.Text;
     Int32.TryParse(TextBoxPatientAge.Text, out int age);
     string password = TextBoxPatientPassword.Text;
     string email = TextBoxPatientEmail.Text;
     Int32.TryParse(TextBoxPatientCPR.Text, out int socialnr);

     for (int i = 0; i < patientslist.Count(); i++)
     {
         if (i == Convert.ToInt32(Application["SelectedPatient"]))
         {
             Patient pat = patientslist[i];
             pat.Name = name;
             pat.Age = age;
             pat.Password = password;
             pat.Email = email;
             pat.CPR = socialnr;

             Application.Lock();
             patientslist = (List<Patient>)Application["PatientList"];
             Application["PatientList"] = patientslist;
             Application.UnLock();

             UpdatePatientsGridView();
             MessagePatientForm.Text = "Updated patient: " + pat.Name;
         }
     }

     PatientsGridView.DataSource = patientslist;
     PatientsGridView.DataBind();
 }

 protected void ButtonDeleteSelectedPatient_Click(object sender, EventArgs e)
 {
     /*int selected = PatientsGridView.SelectedIndex;
     patientslist.RemoveAt(selected);

     // call method
     UpdatePatientsGridView();
     MessagePatientForm.Text = "Patient deleted.";*/

/*    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
    BinaryFormatter bf = new BinaryFormatter();
    List<Patient> pl = (List<Patient>)bf.Deserialize(fs);
    fs.Close();

    MessagePatientForm.Text = "Patient deleted.";
    Patient p = (Patient)Session["PatLog"];

    foreach (Patient pat in pl)
    {
        if (p.Email == pat.Email && p.Password == pat.Password)
        {
            pl.Remove(pat);
            break;
        }
    }

    //write to file
    fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
    bf = new BinaryFormatter();
    bf.Serialize(fs, pl);
    fs.Close();

    //clear session
    Session["PatLog"] = null;
    Session.Clear();

    Response.Redirect("Home.aspx");

}

/* --------------------------- */
/*
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

        public void UpdatePatientsGridView()
        {
            PatientsGridView.DataSource = patientslist;
            PatientsGridView.DataBind();
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

            UpdatePatientsGridView();
            MessagePatientForm.Text = "Patient added to Patients list";
        }

        protected void PatientsGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxPatientName.Text = PatientsGridView.SelectedRow.Cells[2].Text;
            TextBoxPatientAge.Text = PatientsGridView.SelectedRow.Cells[3].Text;
            TextBoxPatientPassword.Text = PatientsGridView.SelectedRow.Cells[4].Text;
            TextBoxPatientEmail.Text = PatientsGridView.SelectedRow.Cells[5].Text;
            TextBoxPatientCPR.Text = PatientsGridView.SelectedRow.Cells[1].Text;

            ButtonUpdateSelectedPatient.Enabled = true;

            GridViewRow row = PatientsGridView.SelectedRow;

            SelectedPatientIndex = PatientsGridView.SelectedIndex;
            Application["SelectedPatient"] = SelectedPatientIndex;
            MessagePatientForm.Text = "Selected patient: " + PatientsGridView.SelectedRow.Cells[2].Text;

            UpdatePatientsGridView();
            MessageNewFormPat.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientDashboard.aspx");
        }
    }
} */
