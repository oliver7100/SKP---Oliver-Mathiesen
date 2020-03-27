using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public class Part
        {
            public string PartName { get; set; }
            public int Wins { get; set; }

            public int Win = 0;

            public override string ToString()
            {
                return "   Name: " + PartName + "  Amount: " + Wins;
            }

        }

        static void Main(string[] args)
        {



            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("*                     MENU                     *");
                Console.WriteLine("*                -------------                 *");
                Console.WriteLine("*    1) Start Game                             *");
                Console.WriteLine("*    2) Tutorial                               *");
                Console.WriteLine("*    0) Exit                                   *");
                Console.WriteLine("************************************************");
                Console.Write(">");

                string valg1 = Console.ReadLine();
                int valg = int.Parse(valg1);

                switch (valg)
                {
                    case 1:
                        dos_StartGame();
                        break;
                    case 2:
                        dos_Tutoiral();
                        break;
                  
                    //case 3:
                    //    dos_highscore();
                    //break;

                    case 0:
                        keepGoing = false;
                        break;
                    default:
                        Console.ReadKey();
                        break;

                }
            }
            Console.Clear();
        }

        //public static List<Part> parts = new List<Part>();

        //static void dos_highscore()
        //{




        //    if (parts.Count == 0)
        //    {

        //        Console.WriteLine("There is no current highscore");
        //        Console.ReadKey();
        //        Console.Clear();
        //    }
        //    else
        //    {
        //        foreach (Part aPart in parts)
        //        {
        //            Console.WriteLine(aPart);
        //            Console.ReadKey();
        //            Console.Clear();
        //        }
        //    }






        //    Console.ReadKey();

        //    Console.Clear();






        //}

        static void dos_Tutoiral()
        {
            Console.WriteLine("To play the game go into menu and press 1. Afterwards the game will give a number to choose from between 1 and 10. Then you have to guess correctly you have 3 attemps.");


            Console.ReadKey();
            Console.Clear();
        }



        static void dos_StartGame()
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 11);
            int attempts;
            int numOfAttempts = 3;
            int Win = 0;
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
                else if (attempts == rndNum)
                {
                    Console.WriteLine("Thats the number! You won, let's play again");
                    //for (int i = 0; i <Win; i++)
                    //{
                    //    List<long> list = new List<long>();
                    //    for (long z = 0; z < 1; z++)
                    //    {
                    //        list.Insert(0, i);
                    //    }
                    //}

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
            Console.Clear();
        }





    }
}
