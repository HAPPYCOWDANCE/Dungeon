using System;
using System.Collections.Generic;

namespace dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerz = 0;
            var player = new List<int>();
            player.Add(0);
            player.Add(0);
            int x = 0;
            int y = 0;

            int p = 0;
            while (p == 0)
            {
                Console.WriteLine(player);
                Console.WriteLine(floormax(playerz));
                string input = Console.ReadLine();
                if (input == "f")
                {
                    if (player[1] == floormax(playerz))
                    {
                        Console.WriteLine("Invalid move");
                    }
                    if (player[1] != floormax(playerz))
                    {
                        x = player[0];
                        y = player[1] + 1;
                        player.RemoveRange(0, 2);
                        player.Add(x);
                        player.Add(y);
                    }
                }
                if (input == "b")
                {
                    if (player[1] == 0)
                    {
                        Console.WriteLine("Invalid move");
                    }
                    if (player[1] != 0)
                    {
                        x = player[0];
                        y = player[1] - 1;
                        player.RemoveRange(0, 2);
                        player.Add(x);
                        player.Add(y);
                    }
                }
                if (input == "l")
                {
                    if (player[1] == 0)
                    {
                        Console.WriteLine("Invalid move");
                    }
                    if (player[1] != 0)
                    {
                        x = player[0] - 1;
                        y = player[1];
                        player.RemoveRange(0, 2);
                        player.Add(x);
                        player.Add(y);
                    }
                }
                if (input == "r")
                {
                    if (player[1] == floormax(playerz))
                    {
                        Console.WriteLine("Invalid move");
                    }
                    if (player[1] != floormax(playerz))
                    {
                        x = player[0] + 1;
                        y = player[1];
                        player.RemoveRange(0, 2);
                        player.Add(x);
                        player.Add(y);
                    }
                }



            }

        }
        static int floormax(int playerz)
        {
            if (playerz == 0)
            {
                return 6;
            }
            if (playerz >= 1 && playerz <= 4)
            {
                return 4;
            }
            if (playerz == 5)
            {
                return 2;
            }
            return 9;

        }
    }
}
