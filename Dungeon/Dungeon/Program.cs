using System;
using System.Collections.Generic;

namespace dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int playerz = 0;
            var player = new List<int>();
            player.Add(0);
            player.Add(0);
            int x = 0;
            int y = 0;

            int health = 10;
            int attack = 1;
            int defence = 5;
            int speed = 5;
            string weapon = "Fist";
            string armor = "Cloth";
            var inventory = new List<string>();

            var ladder = new List<int>();
            ladder.Add(4);
            ladder.Add(4);  
            var oldladder = new List<int>();
            oldladder.Add(999);
            oldladder.Add(999);

            var mob1 = new List<int>();
            mob1.Add(rnd.Next(2, 5));
            mob1.Add(rnd.Next(2, 5));
            int health1 = 5;
            int attack1 = 1;
            while (mob1 == ladder)
            {
                mob1.Add(rnd.Next(2, 5));
                mob1.Add(rnd.Next(2, 5));
            }
            var mob2 = new List<int>();
            int health2 = 5;
            int attack2 = 1;
            mob2.Add(rnd.Next(2, 5));
            mob2.Add(rnd.Next(2, 5));
            while (mob2 == ladder || mob2 == mob1)
            {
                mob2.Add(rnd.Next(2, 5));
                mob2.Add(rnd.Next(2, 5));
            }
            var mob3 = new List<int>();
            int health3 = 5;
            int attack3 = 1;
            mob3.Add(rnd.Next(2, 5));
            mob3.Add(rnd.Next(2, 5));
            while (mob3 == ladder || mob3 == mob2 || mob3 == mob1)
            {
                mob3.Add(rnd.Next(2, 5));
                mob3.Add(rnd.Next(2, 5));
            }
            var mob4 = new List<int>();
            int health4 = 5;
            int attack4 = 1;
            mob4.Add(rnd.Next(2, 5));
            mob4.Add(rnd.Next(2, 5));
            while (mob4 == ladder || mob4 == mob1 || mob4 == mob2 || mob4 == mob3)
            {
                mob4.Add(rnd.Next(2, 5));
                mob4.Add(rnd.Next(2, 5));
            }

            var item1 = new List<int>();
            item1.Add(1);
            item1.Add(1);

            int p = 0;
            while (p == 0)
            {
                string input = "asd";
                Console.WriteLine("(" + player[0] + ", " + player[1] + ")");
                Console.WriteLine("(" + ladder[0] + ", " + ladder[1] + ")");
                Console.WriteLine("(" + oldladder[0] + ", " + oldladder[1] + ")");
                
                if (player[0] == ladder[0] && player[1] == ladder[1])
                {
                    Console.WriteLine("you find a ladder press u to go up it?");
                    input = Console.ReadLine();
                    if (input == "u")
                    {
                        playerz += 1;
                        ladder.RemoveRange(0,2);
                        oldladder.RemoveRange(0, 2);
                        if (playerz == 1 || playerz == 3)
                        {
                            oldladder.Add(4);
                            oldladder.Add(4);
                            ladder.Add(0);
                            ladder.Add(0);
                        }
                        if (playerz == 2) 
                        {
                            oldladder.Add(0);
                            oldladder.Add(0);
                            ladder.Add(4);
                            ladder.Add(4);
                        }
                        if (playerz == 4)
                        {
                            oldladder.Add(4);
                            oldladder.Add(4);
                            ladder.Add(2);
                            ladder.Add(2);
                        }
                    }
                    input = "asd";
                }
                if (player[0] == oldladder[0] && player[1] == oldladder[1])
                {
                    Console.WriteLine("you find a ladder press d to go down it?");
                    input = Console.ReadLine();
                    if (input == "d")
                    {
                        playerz -= 1;
                        Console.WriteLine(playerz);
                        oldladder.RemoveRange(0, 2);
                        ladder.RemoveRange(0, 2);
                        if (playerz == 0)
                        {
                            oldladder.Add(999);
                            oldladder.Add(999);
                            ladder.Add(4);
                            ladder.Add(4);
                        }
                        if (playerz == 1 || playerz == 3)
                        {
                            oldladder.Add(4);
                            oldladder.Add(4);
                            ladder.Add(0);
                            ladder.Add(0);
                        }
                        if (playerz == 2)
                        {
                            oldladder.Add(0);
                            oldladder.Add(0);
                            ladder.Add(4);
                            ladder.Add(4);
                        }
                       
                     
                    }
                    
                }

                if (player[0] == mob1[0] && player[1] == mob1[1])
                {
                    Console.WriteLine("you encountered a skeleton would you like to fight or run?");
                    input = Console.ReadLine();
                    if (input == "fight")
                    {

                    }
                    if (input == "run")
                    {
                        int success = 1;
                        if (playerz == 0)
                        {
                            for (int i = 0; i < speed; i++)
                            {
                                success = rnd.Next(0, 10);
                                if (success == 0)
                                {   
                                    break;
                                }
                            }  
                                
                        }
                        if (playerz == 1)
                        {
                            for (int i = 0; i < speed; i++)
                            {
                                success = rnd.Next(0, 15);
                                if (success == 0)
                                {
                                    break;
                                }
                            }
                        }
                        if (playerz == 2)
                            for (int i = 0; i < speed; i++)
                            {
                                success = rnd.Next(0, 20);
                                if (success == 0)
                                {
                                    break;
                                }
                            }
                    }
                        if (playerz == 3)
                        {
                            for (int i = 0; i < speed; i++)
                            {
                                success = rnd.Next(0, 25);
                                if (success == 0)
                                {
                                break;
                                }
                            }
                    }
                        if (playerz == 4)
                        {
                            for (int i = 0; i < speed; i++)
                            {
                                success = rnd.Next(0, 25);
                                if (success == 0)
                                {
                                break;
                            }
                        }
                    }
                        if (playerz == 5)
                        {
                            
                        }
                }
                        
                }
                input = Console.ReadLine();
                if (input == "stat")
                {
                    Console.WriteLine("Health: " + health);
                    Console.WriteLine("Weapon: " + weapon + " " + attack + "-atk");
                    Console.WriteLine("Armor: " + armor + " " + defence + "-def" + " " + speed + "-spd");
                    Console.WriteLine("Inventory:");
                    int i = inventory.Count - 1;
                    if (i == -1)
                    {
                        Console.WriteLine("none");
                    }
                    while (i > -1)
                    {
                        Console.WriteLine(inventory[i]);
                        i -= 1;
                    }

                }
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
                    if (player[0] == 0)
                    {
                        Console.WriteLine("Invalid move");
                    }
                    if (player[0] != 0)
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
                    if (player[0] == floormax(playerz))
                    {
                        Console.WriteLine("Invalid move");
                    }
                    if (player[0] != floormax(playerz))
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
