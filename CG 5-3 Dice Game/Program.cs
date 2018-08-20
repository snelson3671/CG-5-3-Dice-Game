using System;

namespace CG_5_3_Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you make your dice rolls add up to 20 before the computer does?");
            Console.WriteLine("If so, then you win!");

            Console.ReadLine();

            

            
        }

        private static int UserRoll()
        {
            Console.Write("Press Enter to roll the dice.  ");
            int userRoll =  int.Parse(Console.ReadLine());
            
            Console.WriteLine($"You rolled a {userRoll}");
            Random myRandom = new Random();
            userRoll = myRandom.Next(1, 13);

            int userSum = 0;
            userSum += userRoll;

            Console.WriteLine($"Your sum is {userSum}");

            do
            {
                Console.WriteLine("Press enter to roll again.");

            } while (userSum <= 20);

            return userSum;
        }

        private static int ComputerRoll()
        {
            Console.Write("Press Enter to roll the dice.  ");
            int computerRoll = int.Parse(Console.ReadLine());

            Console.WriteLine($"The computer rolled a {computerRoll}");

            Random myRandom = new Random();
            computerRoll = myRandom.Next(1, 13);

            int computerSum = 0;
            computerSum += computerRoll;

            Console.WriteLine($"The computer's sum is {computerSum}");

            do
            {
                Console.WriteLine("Press enter to roll again.");

            } while (computerRoll <= 20);

            return computerSum;
        }
    }
}
