using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.IO;

namespace _4thCSharpHandIn
{
    [Serializable]
    public class Patient : Person // inherited
    {
        // instance special for patient
        protected int Cpr;

        // constructor
        public Patient(string name, int age, string password, string email, int CPR) : base(name, age, password, email)
        {
            this.Cpr = CPR;
        }

        // property
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

    }
}