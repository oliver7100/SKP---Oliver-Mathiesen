using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
       static ConsoleKeyInfo userKey;
       static bool gameRunning = true;
       static int locationY = 5;
       static int locationX = 5;


        private static void buildWall()
        {
            for (int i = 1; i < 26; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(80, i);
                Console.Write("■");

            }
            for (int i = 1; i < 81; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(i, 1);
                Console.Write("■");
                Console.SetCursorPosition(i, 25);
                Console.Write("■");

            }
        }
        static void Main()
        {
            buildWall();

            while (gameRunning)
            {



                if (Console.KeyAvailable)
                {
                    userKey = Console.ReadKey(true);

                    switch (userKey.Key)
                    {
                        case ConsoleKey.LeftArrow:

                            if (locationX > 2)
                            {
                                locationX = locationX - 1;
                            }
                            break;

                        case ConsoleKey.RightArrow:

                            if (locationX < 78)
                            {

                                locationX = locationX + 1;
                            }
                            break;

                        case ConsoleKey.UpArrow:

                            if (locationY > 2)
                            {

                                locationY = locationY - 1;
                            }
                            break;
                        case ConsoleKey.DownArrow:

                            if (locationY < 24)
                            {

                                locationY = locationY + 1;
                            }
                            break;

                        case ConsoleKey.Escape:
                            // Exit the game when pressed
                            gameRunning = false;
                            break;
                    }
                }

                Console.Clear();
                Console.SetCursorPosition(locationX, locationY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("■");
            }
        }

   
    }


    }


      

