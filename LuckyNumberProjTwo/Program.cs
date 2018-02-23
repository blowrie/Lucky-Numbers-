using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumberProjTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            double jackpot = 448000000.00;
            int rangeLow, rangeHigh;
            int rangeSwitch = 0;
            int match = 0;
            int[] luckyNumbers = new int[6];
            int[] winningNumbers = new int[6];
            string startOver = "null";
            bool restart;


            do
            {
                Console.WriteLine("WELCOME TO JACKPOT! THE CONSOLE APPLICATION WHERE YOU CAN WIN REAL MONEY\nTODAYS JACKPOT IS 448,000,000\n");

                Console.Write("Press Enter to get started...\n");
                Console.ReadLine();


                Console.Write("Please enter a low number: ");
                rangeLow = int.Parse(Console.ReadLine());
                Console.Write("Please enter a higher number: ");
                rangeHigh = int.Parse(Console.ReadLine());
                if (rangeLow < rangeHigh)
                {
                    //Good Job
                }
                else
                {
                    Console.WriteLine("\nOops! you put a lower number. I will switch them for you.\n");
                    rangeSwitch = rangeHigh;
                    rangeHigh = rangeLow;
                    rangeLow = rangeSwitch;
                }
                Console.WriteLine("range low is: " + rangeLow);
                Console.WriteLine("range high is: " + rangeHigh);

                Console.WriteLine("\nPlease input 6 numbers that will be used for your lucky numbers within your range (no duplicates)...\n");

                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    Console.Write("Your lucky number " + (i + 1) + ": ");
                    luckyNumbers[i] = int.Parse(Console.ReadLine());
                    if (luckyNumbers[i] < rangeLow || luckyNumbers[i] > rangeHigh)
                    {
                        Console.WriteLine("Number out of range please try again.");
                        i--;
                    }
                }
                Console.WriteLine("Lets reveal those winning numbers! Press Enter when you are feeling lucky\n");
                Console.ReadLine();

                Random rand = new Random();

                for (int i = 0; i < winningNumbers.Length; i++)
                {
                    winningNumbers[i] = rand.Next(rangeLow, rangeHigh);
                    Console.WriteLine("Lucky Number: " + winningNumbers[i]);
                }

                Console.WriteLine("");


                
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    for (int j = 0; j < winningNumbers.Length; j++)
                    {
                        if (luckyNumbers[i] == winningNumbers[j])
                        {
                            Console.WriteLine("Congratulations! " + luckyNumbers[i] + " and " + winningNumbers[j] + " MATCH!");
                            match++; //If numbers match eachother match is added 1
                        } 
                    }
                }
                if (match == 0)
                {
                    Console.WriteLine("\nYou guessed " + match + " numbers correctly. ");
                    Console.WriteLine("I'm sorry but you didnt win any money.");

                }
                else
                {
                    jackpot = jackpot / match;
                    Console.WriteLine("Wow, you guessed " + match + " numbers correctly!");
                    Console.WriteLine("You won: {0:0.00}", jackpot);
                }

                    Console.WriteLine("\nPlease Type yes if you would like to play again.");
                    startOver = Console.ReadLine().ToLower();
                

                if (startOver == "yes")
                {
                    restart = true;
                    Console.WriteLine(" ");
                }

                else
                {
                    restart = false;
                }

            } while (restart == true);

            Console.WriteLine("Thank you for playing!");





            
        }
    }
}
