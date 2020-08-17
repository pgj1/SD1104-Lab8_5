using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace Lab8_5_RealityTVStar
{
    class ParadiseIsland : Application
    {
        public string Gender;
        public string PartnerName;
        public int YearsDating;

        public ParadiseIsland(string gender, string partnerName, int yearsOfDating, string firstName, string lastName, string birthDate, string addr, string city, string state, int zip, string email,
                   string phone) : base(firstName, lastName, birthDate, addr, city, state, zip, phone, email)
        {
            this.Gender = gender;
            this.PartnerName = partnerName;
            this.YearsDating = yearsOfDating;
         }

        public override void Accepted()
        {
            if (this.AppSubmitted == true)
            {
                this.AppAccepted = true;
                Console.WriteLine("Congratulations, " + FirstName + " " + LastName + " you've been accepted to Paradise Island! \n");
            }
            else { 
            Console.WriteLine(FirstName + " we do not have an application for you.");
            }
        }

              
           
        }
        

  
}


