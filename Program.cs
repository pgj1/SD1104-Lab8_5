using System;

namespace Lab8_5_RealityTVStar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 8.5 Reality TV Star \n");

            //Create House Hunter contestant

            HouseHunter HContestant1 = new HouseHunter("Full Stack Web Developer", 100000, 6, 3, 2,
                "Omar", "Smith", "02/04/1975", "111 Bravo Way", "Los Angeles", "California", 90001, "omar.smith@hotmail.com", "888-233-1234");


            Console.WriteLine("************** Dream House Hunter ********************");
            //Submit & accept application
            HContestant1.Submitted();
            HContestant1.Accepted();

            // create Paradise Isaland contestant

            ParadiseIsland PContestant1 = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "05/04/1994", "211 Love Rd",
                "Los Angeles", "California", 90001, "Patti@gmail.com", "988-444-1234");


            Console.WriteLine("**************  Paradise Island ********************");
            //submit & accept application
            PContestant1.Submitted();
            PContestant1.Accepted();


            //create Above Deck contestant
            AboveDeck AContestant1 = new AboveDeck("American",20,"Captain","Lee","07/12/1964","311 Bravo Way",
                "Los Angeles","CA",90001, "captian@gmail.com", "711-333-1234");


            Console.WriteLine("**************  Above Deck  ********************");
            //submit & accept appliation
            AContestant1.Submitted();
            AContestant1.Accepted();


        }
    }
}






