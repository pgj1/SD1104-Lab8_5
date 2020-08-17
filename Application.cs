using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace Lab8_5_RealityTVStar
{
    class Application
    {
        public string FirstName;
        public string LastName;
        public string BirthDate;
        public string Addr;
        public string City;
        public string State;
        public int Zip;
        public string Phone;
        public string Email;
        public bool AppSubmitted;
        public bool AppAccepted;

       public Application(string firstName, string lastName, string birthDate, string addr, string city, string state, int zip, string email,
            string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Addr = addr;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
            this.Email = email;
            AppSubmitted = false;
            AppAccepted = false;
        }


        public void Submitted()
        {
            this.AppSubmitted = true;
            Console.WriteLine("Application submitted.");
        }

        public virtual void Accepted()
        {
            this.AppAccepted = true;
            Console.WriteLine("Congratulations, your application has been accepted!");
        }
 

    }
}



/*      


 
 
 */
