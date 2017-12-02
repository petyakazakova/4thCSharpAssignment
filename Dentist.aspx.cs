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
    public partial class Dentist1 : System.Web.UI.Page
    {
        List<Dentist> dentistslist = new List<Dentist>();
        //int SelectedDentistIndex; //so we can select the field for update it later
        private string filename; // where we store users data

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Application["SelectedDentist"] = null;
                MessageNewFormDent.Text = (string)Application["SelectedDentist"];
            }

            filename = Server.MapPath("~/App_Data/dentistslistdata.ser");

            if (Application["DentistList"] == null)
            {
                Application["DentistList"] = new List<Dentist>();
            }

            dentistslist = (List<Dentist>)Application["DentistList"];
        }

        private void UpdateDentist()
        {

            foreach (Dentist dent in (List<Dentist>)Application["DentistList"])
            {
                //creating a variable for each new dentist inthe application
                dentistslist.Add(dent);
            }

            for (int i = 0; i < dentistslist.Count(); i++)
            {
                if (i == Convert.ToInt32(Application["SelectedDentist"]))
                {
                    Dentist dent = dentistslist[i];
                    TextBoxNameDentist.Text = dent.Name;
                    TextBoxAgeDentist.Text = dent.Age.ToString();
                    TextBoxPassDentist.Text = dent.Password;
                    TextBoxEmailDentist.Text = dent.Email;
                    TextBoxCPRDentist.Text = dent.CPR.ToString();
                }
            }

        }

        // SAVE TO FILE
        protected void ButtonSaveDentistFile_Click(object sender, EventArgs e)
        {
            dentistslist = (List<Dentist>)Application["DentistList"];

            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, dentistslist);
            fs.Close();

            MessageDentistForm.Text = "Dentists list saved to file.";

        }

        // ADD
        protected void ButtonCRNewDentist_Click(object sender, EventArgs e)
        {
            Dentist dent = new Dentist(TextBoxNameDentist.Text, Int32.Parse(TextBoxAgeDentist.Text), TextBoxPassDentist.Text, TextBoxEmailDentist.Text, Int32.Parse(TextBoxCPRDentist.Text));

            Application.Lock();
            dentistslist = (List<Dentist>)Application["DentistList"];
            dentistslist.Add(dent);
            Application["DentistList"] = dentistslist;
            Application.UnLock();

            TextBoxNameDentist.Text = "";
            TextBoxAgeDentist.Text = "";
            TextBoxPassDentist.Text = "";
            TextBoxEmailDentist.Text = "";
            TextBoxCPRDentist.Text = "";
            MessageDentistForm.Text = "Dentist added to dentists list. You can now login as a dentist.";

        }

    }
}