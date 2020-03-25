using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake_Game
{
    class Program
    {

        int height = 20;
        int width = 30;
        int[] X = new int[50];
        int[] Y = new int[50];

        int BubbleX;
        int BubbleY;

        int parts = 3;

       Random rnd = new Random();

        Lol()
        {
            X[0] = 5;
            Y[0] = 5;
            Console.CursorVisible = false;

        }

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'W';
        public void Board()
        {

            Console.Clear();
            for (int i = 1; i <=(width + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            for (int i = 1; i <= (width + 2); i++)
            {
                Console.SetCursorPosition(i, (height+2));
                Console.Write("-");
            }
            for (int i = 1; i <= (height + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("-");
            }
            for (int i = 1; i <= (height + 1); i++)
            {
                Console.SetCursorPosition((width+ 2), + i);
                Console.Write("-");
            }

        }

       public void logic()
        {
            if (X[0] == BubbleX)
            {
                if (Y[0] == BubbleY)
                {
                    parts++;
                    BubbleX = rnd.Next(2, (width-2));
                    BubbleY = rnd.Next(2, (height - 2));
                }
            }

            for (int i = parts; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];


            }
            switch (key)
            {
                case 'w':
                    Y[0]--;
                    break;
                case 's':
                    Y[0]++;
                    break;
                case 'd':
                    X[0]++;
                    break;
                case 'a':
                    X[0]--;
                    break;

            }
            for (int i = 0; i <= (parts - 1); i++)
            {
                Point(X[i], Y[i]);
                Point(BubbleX, BubbleY);

            }
            Thread.Sleep(100);
        }


        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
           
        }

        public void Point(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("#");
        }


        static void Main(string[] args)
        {
            Program snake = new Program();
            while (true){
                snake.Board();
                snake.Input();
                snake.logic();
            }
            Console.ReadKey();


        }
    }
}
