using System;
using System.Collections.Generic;

namespace dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            while (true)
            {
                Console.WriteLine("f to move forwards b to move backwards etc");
                string input = Console.ReadLine();

                if (player.Move(input))
                {
                   //
                }
                else;
                {
                    Console.WriteLine("invalid move");
                }
            }
        }
    }
    class Player
    {
        public const int MapHeight = 5;
        public const int MapWidth = 5;
        public int X = 0;
        public int Y = 0;

        public bool Move(string input)
        {
            switch(input)
            {
                case "f":
                    if (this.Y < MapHeight)
                    {
                        this.Y += 1;
                        return true;
                    }
                    else
                        return false;
                case "b":
                    if (this.Y > 0)
                    {
                        this.Y -= 1;
                        return true;
                    }
                    else
                        return false;
                case "l":
                    if (this.X > 0)
                    {
                        this.X -= 1;
                        return true;
                    }
                    else
                        return false;
                case "r":
                    if (this.X < MapWidth)
                    {
                        this.X += 1;
                        return true;
                    }
                    else
                        return false;
                default:
                    return false;

            }
        }
    }
}