using System;
using System.Collections.Generic;

namespace dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Input map = new Input();
            int row = 0;
            while (row < 5)
            {
                Console.WriteLine("-----------------");
                string input = Console.ReadLine();

                if (input == null)
                    return;
                if (input.Length >= 5)
                {
                    for(int column = 0; (column < 5); ++column)
                    {
                        if (input[column] == '\\')
                            map.SetValue(column, row, 1);
                        else if (input[column] == '/')
                            map.SetValue(column, row, 2);
                        else if (input[column] == '*')
                            map.SetValue(column, row, 3);
                    }
                    ++row;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
               
            }

            int e = 0;
            int r = 0;
            for (e = 0; e < 5; e++)
            {
                for (r = 0; r < 5; r++)
                {
                    if (map.GetValue(e, r) == 0)
                    {
                        Console.Write("[ ]");
                    }
                    else if (map.GetValue(e, r) == 1)
                    {
                        Console.Write("[\\]");
                    }
                    else if (map.GetValue(e, r) == 2)
                    {
                        Console.Write("[/]");
                    }
                    else
                    {
                        Console.Write("[*]");
                    }
                }
                r = 0;
                Console.WriteLine("");
            }
            e = 0;
            r = 0;
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                    {
                        case ("a"):
                            for (e = 0; r < 5||e < 5||e > 0||r > 0; e++)
                            {
                                if (map.GetValue(e,r) == 1)
                                {
                                    for (r = 0; r < 5 || e < 5 || e > 0 || r > 0; r--)
                                    {
                                        
                                    }
                                }
                                if (map.GetValue(e, r) == 2)
                                {
                                    for (r = 0; r < 5 || e < 5 || e > 0 || r > 0; r++)
                                    {
                                        
                                    }
                                }
                                if (map.GetValue(e, r) == 3)
                                {
                                    for (r = 0; r < 5 || e < 5 || e > 0 || r > 0; r++)
                                    {
                                    break;
                                    }
                                }
                            }
                            Console.WriteLine(e + " " + r);
                            break;
                    }
            }
        }
    }

  
    class Input
    {
        public int[,] map = new int[5, 5];

        public int GetValue(int x, int y)
        {
            return this.map[x, y];
        }

        public void SetValue(int x, int y, int value)
        {
            this.map[x, y] = value;
        }
   
    }
}