using System;
using System.Collections.Generic;

namespace dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Turn1 map = new Turn1();
            int row = 0;
            while (row < 5)
            {
                Console.WriteLine("k");
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
                Console.WriteLine(map[0, 0]);
            }
        }
    }

  
    class Turn1
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