using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace Lab8_5_RealityTVStar
{
    class HouseHunter : Application
    {

        public string Job;
        public int Income;
        public int whenMove;
        public int Bedrooms;
        public int Bathrooms;


        public HouseHunter(string jobTitle, int annualIncome, int moveTimeMonths, int bedrooms, int bathrooms,
            string firstName, string lastName, string birthDate, string addr, string city, string state, int zip, string email,
            string phone) : base(firstName, lastName, birthDate, addr, city, state, zip, phone, email)
        {
            this.Job = jobTitle;
            this.Income = annualIncome;
            this.whenMove = moveTimeMonths;
            this.Bedrooms = bedrooms;
            this.Bathrooms = bathrooms;
             
            }

        public override void Accepted()
        {
           
            if(this.AppSubmitted == true)
            {
                this.AppAccepted = true;
                Console.WriteLine("Congratulations, "+ FirstName + " " + LastName + " you've been accepted to Dream House Hunters! \n");
            }
            else
            { 
            Console.WriteLine(FirstName + " we do not have an application for you.");
            }
        }



    }
}


/*
The House Hunter Class
The house hunter class needs to include additional data. It should have these properties
● Job Title
● Current Annual Income
● When are you Looking To Buy House
● Number of Bedrooms
● Number of Bathrooms

House Hunters class will override Accept(). The override will print “You’ve been accepted to “Dream House Hunters”

 * */
