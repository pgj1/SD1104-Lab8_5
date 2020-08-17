using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace Lab8_5_RealityTVStar
{
    class AboveDeck : Application
    {
        public string Nationality;
        public int BoatingExp;


        public AboveDeck(string nationality, int boatingExp, string firstName, string lastName, string birthDate, string addr, string city, string state, int zip, string email,
           string phone) : base(firstName, lastName, birthDate, addr, city, state, zip, phone, email)
        {
            this.Nationality = nationality;
            this.BoatingExp = boatingExp;
        }

        public override void Accepted()
        {
           // base.Accepted();
            this.AppAccepted = true;
            Console.WriteLine("Congratulations, " + FirstName + " "+ LastName + " you've been accepted to Above Deck! \n");
        }



    }
}


