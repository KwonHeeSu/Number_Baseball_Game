using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Game = new string[20, 30];

            Game[0, 0] = "┏";
            Game[0, 29] = "┓";
            Game[19, 0] = "┗";
            Game[19, 29] = "┛";

            for (int i=1; i < 29; i++)
            {
                Game[0, i] = "━";
                Game[19, i] = "━";
            }

            for(int i = 1; i < 19; i++)
            {
                Game[i, 0] = "┃";
                Game[i, 29] = "┃";
            }
            
            for (int i = 0; i < 20; i++) {
                for (int j = 0; j < 30; j++) {
                    Console.Write(Game[i, j]);
                }
                Console.WriteLine();
            }


        }
    }
}
