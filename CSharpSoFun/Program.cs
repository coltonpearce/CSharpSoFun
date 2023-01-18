using System;

namespace CSharpSoFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] rollTotals =  new int[11]; //this is the array that will hold the number of rolls per dice

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            var x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                int roll1 = r.Next(1,7);
                int roll2 = r.Next(1,7);

                int roll = roll1 + roll2;

                rollTotals[roll -2]++;
            }

            int thisPerc = 0;

            for (int i = 0; i < 11; i++) //this is the syntax for the for loop
            {
                thisPerc = (int)((rollTotals[i]/(float)x)*100);

                string stars = "";

                for(int j = 0; j < thisPerc; j++)
                {
                    stars += "*";
                }

                Console.WriteLine((i + 2) + ": " + stars);
            }
        }
    }
}
