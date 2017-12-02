using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.IO;

namespace _4thCSharpHandIn
{
    [Serializable]
    public abstract class Person // abstract class is intended to only be a base class to derived classes
    {
        // instance fields
        protected string name;
        protected int age;
        protected string password;
        protected string email;

        //constructor
        public Person(string name, int age, string password, string email) 
        {
            this.Name = name;
            this.Age = age;
            this.Password = password;
            this.Email = email;
        }

        // property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public virtual void ChangeEmail(string newEmail)
        {
            Email = newEmail;
        }

        // method
        public override string ToString()
        {
            return "Patient name: " + this.Name + ", age: " + this.Age + ", Password: " + this.Password + ", email: " + this.Email + ", CPR: ";
        }

    }
}