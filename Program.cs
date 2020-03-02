using System;

namespace WaterTrackingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables declared..
            string enterAgain;
            int goal;
            int water;
            int glasses;
            int total;
            int more;
            double moreGlasses;
            int count = 0;
            //start of the do/while loop for the enterAgain variable.

            //Welcome the user to the program
            Console.WriteLine("**********************************");
            Console.WriteLine("Welcome to the Water Tracking App!");
            Console.WriteLine("**********************************");
            Console.WriteLine(" ");

            //Asking for the user's age.
            Console.WriteLine("What is your glass goal for the day?: ");
            goal = int.Parse(Console.ReadLine());
            

            do
            {  //Asking for the amount of ounces of water
                Console.WriteLine("How many glasses of water have you drank so far?");
                glasses = int.Parse(Console.ReadLine());         

                //More variable to be used if the user has less than 68 oz or 8 glasses.
                more = 8 - glasses;
                
                //If statement for statements for water.
                if (glasses > goal)
                {
                    Console.WriteLine("You've made your goal/n That's great!");
                    count = count + glasses;
                }
                else
                {
                    Console.WriteLine("You are {0:D} away from your goal!", more);
                    Console.WriteLine("Keep going!!");
                    count = count + glasses;
                }

                //Displays results of the program.
                Console.WriteLine("Your goal is " + goal + " glasses.");
                Console.WriteLine("You have tracked {0:D} glasses in this session.", glasses);
                ;



                //Asking the user to enter more water if they want.
                Console.WriteLine("Do you want to track more water? (Y/N)");
                enterAgain = Console.ReadLine();
            } while (enterAgain == "Y" || enterAgain == "y");

            //Display end of program
            Console.WriteLine("Your glasses count for the day is: {0:D}. Great job tracking!", count);
            Console.WriteLine("****************************************");
            Console.WriteLine("*This is the end of the water program!**");
            Console.WriteLine("****************************************");
        }
    }
}
