using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Adkisson_Damien
{
    //class inherits from interface
    internal class Computer : IBootUp
    {
        public bool IsOn { get; set; }

        public string? Brand { get; set; }

        public string? Type { get; set; }

        //constructor for the computer brand, type, and power
        public Computer(string brand, string type, bool ison)
        {
            Brand = brand;
            Type = type;
            IsOn = ison;
        }

        //bool that says if the computer is on or off
        public void PowerOnOff()
        {
            //(opposite of current)
            IsOn = !IsOn;

            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        //overrides and returns information about the computer
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is {IsOn}!";
        }
    }
}