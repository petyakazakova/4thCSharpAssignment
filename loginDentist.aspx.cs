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
    public partial class loginDentist : System.Web.UI.Page
    {
        //arraylist non static
        List<Dentist> dentistslist = new List<Dentist>();
        private List<Dentist> dentistslistdesr;
        private string filename; // where we store users data

        public string email;
        public string password;

        protected void Page_Load(object sender, EventArgs e)
        {
            Deserialise();
        }

        private string FindUser(string email, string password)
        {
            foreach (Dentist dent in dentistslistdesr)
            {
                if (dent.Email == email && dent.Password == password)
                {
                    Session["DentLog"] = dent;
                } 
            }

            return null;
        }

        public void Deserialise()
        {
            filename = Server.MapPath("~/App_Data/dentistslistdata.ser"); //decalring the path to the serializedfile
            dentistslistdesr = new List<Dentist>(); //am creating an instance variable
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                //opening afile stream to readfrom the file in the given path

                BinaryFormatter bf = new BinaryFormatter();
                dentistslistdesr = (List<Dentist>)bf.Deserialize(fs);
                fs.Close();
            }

            GridViewDList.DataSource = dentistslistdesr;
            GridViewDList.DataBind();
        }

        protected void ButtonLoginD_Click(object sender, EventArgs e)
        {
            string password = TextBoxLoginDpass.Text;
            string email = TextBoxDEmailLogin.Text;

            //Dentist dent = FindUser(email, password);
            //if (dentistslistdesr == null)
            if(dentistslistdesr.Count > 0)
            {
                FindUser(email, password);              
                Response.Redirect("DentistDashboard.aspx");
            }
        }

        protected void ButtonReadFromFIle_Click(object sender, EventArgs e)
        {
        }

        protected void ButtonAddDentist_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dentist.aspx");
        }

        protected void GridViewDList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
