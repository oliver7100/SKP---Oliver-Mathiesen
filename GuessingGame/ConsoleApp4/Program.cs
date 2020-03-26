using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 11);
            int attempts;
            int numOfAttempts = 3;
            bool gameOver = false;

            Console.WriteLine("Guess a number between 1 and 10");

            while (gameOver == false)
            {
                attempts = Convert.ToInt32(Console.ReadLine());
                numOfAttempts--;

                if (attempts != rndNum && numOfAttempts == 0)
                {
                    Console.WriteLine("You lost! You're an unworthy opponent");
                    gameOver = true;
                }
                else if(attempts == rndNum)
                {
                    Console.WriteLine("Thats the number! You won, let's play again later");
                    gameOver = true;
                }
                else if (attempts > rndNum)
                {
                    Console.WriteLine("The number is lower than that.");
                }
                
                else if (attempts < rndNum)
                {
                    Console.WriteLine("The number is higher than that.");
                }



            }
            Console.ReadLine();
       


        }
    }
}
