using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDistributionChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Please enter your age");

            //int userAge = int.Parse(System.Console.ReadLine());
            //int userAge = 2;
            string line = "2";

            int userAge = int.Parse(line);

            if (userAge >= 0 && userAge <= 2)
            {
                System.Console.WriteLine("Still in Mama's Arms");
            }
            else if (userAge >= 3 && userAge <= 4)
            {
                System.Console.WriteLine("Preschool Maniac");
            }
            else if (userAge >= 5 && userAge <= 11)
            {
                System.Console.WriteLine("Elementary School");
            }
            else if (userAge >= 12 && userAge <= 14)
            {
                System.Console.WriteLine("Middle School");
            }
            else if (userAge >= 15 && userAge <= 18)
            {
                System.Console.WriteLine("High School");
            }
            else if (userAge >= 19 && userAge <= 22)
            {
                System.Console.WriteLine("College");
            }
            else if (userAge >= 23 && userAge <= 65)
            {
                System.Console.WriteLine("Working for the Man");
            }
            else if (userAge >= 66 && userAge <= 100)
            {
                System.Console.WriteLine("The Golden Years");
            }
            else if (userAge < 0 || userAge > 100)
            {
                System.Console.WriteLine("This program is for humans.");
            }
        }
    }
}
