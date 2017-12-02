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
    public partial class DentistEdit : System.Web.UI.Page
    {
        List<Dentist> dentistslist = new List<Dentist>();
        private string filename; // where we store users data

        protected void Page_Load(object sender, EventArgs e)
        {          
            Dentist d = (Dentist)Session["DentLog"];
            filename = Server.MapPath("~/App_Data/dentistslistdata.ser");

            DeserialiseDent();

            if (Session["DentLog"] != null && !Page.IsPostBack)
            {
                LabelDDash.Text = Session["DentLog"].ToString();
            }

            if (!Page.IsPostBack)
            {
                DeserialiseDent();
                
            }
        }

        public void DeserialiseDent()
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            dentistslist = (List<Dentist>)bf.Deserialize(fs);
            fs.Close();
        }

        //UPDATE
        protected void ButtonUpdateSelectedDentist_Click(object sender, EventArgs e)
        {
            DeserialiseDent();
            string name = TextBoxNameDentist.Text;
            string password = TextBoxPassDentist.Text;
            string email = TextBoxEmailDentist.Text;
            Int32.TryParse(TextBoxAgeDentist.Text, out int age);
            Int32.TryParse(TextBoxCPRDentist.Text, out int Cpr);

            Dentist dent = (Dentist)Session["DentLog"];

            foreach (Dentist d in dentistslist) //d is local variqble
            {
                if (dent.Email == d.Email)
                {
                    d.Name = name;
                    d.Email = email;
                    d.Password = password;
                    d.Age = age;
                    d.CPR = Cpr;

                    LabelDDash.Text = "Updated dentist: " + d.Name;
                }

            }        
        }

        //SAVE TO FILE
        protected void ButtonSaveDentistFile_Click(object sender, EventArgs e)
        {
            //dentistslist = (List<Dentist>)Application["DentistList"];
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, dentistslist);
            fs.Close();

            MessageDentistForm.Text = "Dentists list saved to file.";
        }

        //DELETE 
        protected void ButtonDeleteSelectedDentist_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            List<Dentist> dl = (List<Dentist>)bf.Deserialize(fs);
            fs.Close();

            LabelDDash.Text = "Dentist deleted.";
            Dentist d = (Dentist)Session["DentLog"];

            foreach (Dentist dent in dl)
            {
                if (d.Email == dent.Email && d.Password == dent.Password)
                {
                    dl.Remove(dent);
                    break;
                }
            }

            // write to file
            fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            bf = new BinaryFormatter();
            bf.Serialize(fs, dl);
            fs.Close();

            // clear session
            Session["DentLog"] = null;
            Session.Clear();

            // rediretto login page
            Response.Redirect("Home.aspx");
        }

        protected void ButtonGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("DentistDashboard.aspx");
        }
    }
}
