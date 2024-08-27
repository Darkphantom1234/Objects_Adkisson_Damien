 using System;

namespace Objects_Adkisson_Damien
{
    class Program
    {
        static void Main(string[] args)
        {
            //Makes computer object and compares it
            Computer myComputer = new Computer("Apple", "All-in-One", true);
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));

            //creates other computer and compares it
            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            //changes the reference for my string
            string myString = myComputer.ToString();
            string myOtherString = myString;

            myString = "Hi!";
            
            //primts strings to console
            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);

            //compares the computers and prints result
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            //returns the computers type
            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());

            //runs the power off from ibootup
            myOtherComputer.PowerOnOff();

            //compares and prints
            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());


            //checks if string contains the letter i
            Console.WriteLine(myString.Contains('i'));
            //makes the strings uppercase
            Console.WriteLine(myString.ToUpper());
        }
    }
}