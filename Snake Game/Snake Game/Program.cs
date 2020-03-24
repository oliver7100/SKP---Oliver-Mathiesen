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

        public void Board()
        {

            Console.Clear();
            for (int i = 1; i <=(width) ; i++)
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
                Console.SetCursorPosition(i, (1 + i);
                Console.Write("-");
            }

        }



        static void Main(string[] args)
        {
        }
    }
}
