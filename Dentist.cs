using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.IO;

namespace _4thCSharpHandIn
{
    [Serializable]
    public class Dentist : Person
    {
        //field
        protected int Cpr;

        //constructor
        public Dentist(string name, int age, string password, string email, int CPR) : base(name, age, password, email)
        {
            this.Cpr = CPR;
            ChangeEmail(email); 
        }

        public int CPR
        {
            get { return Cpr; }
            set { Cpr = value; }
        }


        //Method
        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Email: " + Email + ", Password: " + Password + ", CPR: " + Cpr;
        }

        //ChangeEmail method
        public override void ChangeEmail(string newEmail)
        {
            //check if email is of type @odont.dk
            if (newEmail.EndsWith("@odont.dk"))
            {
                this.email = newEmail;
            }
            else
            {
                throw new Exception("Illegal email format");

            }
        }
    }
}