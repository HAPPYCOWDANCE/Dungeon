using System;

namespace Wumple
{
    class Program
    {
        static void Main(string[] args)
        {
            int player = 0;
            int check = 0;

           
            int pitbatadjacent = 0;
            int enemyadjacent = 0;
            int right = 0;
            int left = 0;
            int down = 0;
            int up = 0;

            Random pick = new Random();
            int choose = pick.Next(2, 29);
            int wumple = Check(choose);
            int bat1 = Check(choose);
            while (bat1 == wumple)
            {
                choose = pick.Next(2, 29);
                bat1 = Check(choose);
            }
            int bat2 = Check(choose);
            while (bat2 == wumple || bat2 == bat1)
            {
                choose = pick.Next(2, 29);
                bat2 = Check(choose);
            }
            int pit1 = Check(choose);
            while (pit1 == wumple || pit1 == bat1 || pit1 == bat2)
            {
                choose = pick.Next(2, 29);
                pit1 = Check(choose);
            }
            int pit2 = Check(choose);
            while (pit2 == wumple || pit2 == bat1 || pit2 == bat2 || pit2 == pit1)
            {
                choose = pick.Next(2, 29);
                pit2 = Check(choose);
            }

            
                
            // main loop
            int x = 0;
            while (x == 0)
            {
                Console.WriteLine(player);
                if (player == pit1 || player == pit2 || player == wumple)
                {
                    Console.WriteLine("you died");
                    break;
                }
                if (player == bat1 || player == bat2)
                {
                    player = pick.Next(0, 29);
                    while ((player > 4 && player <= 10) || player == 20 ||  player == 22 || player == 24 || player == 26 || player == 28)
                    {
                        player = pick.Next(0, 29);
                    }
                    Console.WriteLine("you have been transported to a random room"); 
                }
                
                if (LeftAdjacent(player) == wumple || RightAdjacent(player) == wumple || UpAdjacent(player) == wumple || DownAdjacent(player) == wumple)
                {
                    Console.WriteLine("you hear snorting");
                    enemyadjacent += 1;
                }
                if (LeftAdjacent(player) == bat1 || RightAdjacent(player) == bat1 || UpAdjacent(player) == bat1 || DownAdjacent(player) == bat1 || LeftAdjacent(player) == bat2 || RightAdjacent(player) == bat2 || UpAdjacent(player) == bat2 || DownAdjacent(player) == bat2)
                {
                    Console.WriteLine("you hear squeaking");
                    pitbatadjacent += 1;
                }
                if (LeftAdjacent(player) == pit1 || RightAdjacent(player) == pit1 || UpAdjacent(player) == pit1 || DownAdjacent(player) == pit1 || LeftAdjacent(player) == pit2 || RightAdjacent(player) == pit2 || UpAdjacent(player) == pit2 || DownAdjacent(player) == pit2)
                {
                    Console.WriteLine("you hear the wind howling");
                    pitbatadjacent += 1;
                }

                //string input = Console.ReadLine();
                string input = "hello";

                while (x == 0)
                {
                    if (enemyadjacent == 1)
                    {
                        if (right == 1)
                        {
                            input = "ar";
                            right = 0;
                            left = 0;
                            up = 0;
                            down = 0;
                            enemyadjacent = 0;
                            break;
                        }
                        if (left == 1)
                        {
                            input = "al";
                            right = 0;
                            left = 0;
                            up = 0;
                            down = 0;
                            enemyadjacent = 0;
                            break;
                        }
                        if (down == 1)
                        {
                            input = "ar";
                            right = 0;
                            left = 0;
                            up = 0;
                            down = 0;
                            enemyadjacent = 0;
                            break;
                        }
                        if (up == 1)
                        {
                            input = "al";
                            right = 0;
                            left = 0;
                            up = 0;
                            down = 0;
                            enemyadjacent = 0;
                            break;
                        }
                    }
                    if (pitbatadjacent >= 1)
                    {
                        if (right == 1)
                        {
                            input = "l";
                            right = 0;
                            left = 0;
                            up = 0;
                            down = 0;
                            pitbatadjacent = 0;
                            break;
                        }
                        if (left == 1)
                        {
                            input = "r";
                            right = 0;
                            left = 0;
                            up = 0;
                            down = 0;
                            pitbatadjacent = 0;
                            break;
                        }
                        if (down == 1)
                        {
                            input = "u";
                            right = 0;
                            left = 0;
                            up = 0;
                            down = 0;
                            pitbatadjacent = 0;
                            break;
                        }
                        if (up == 1)
                        {
                            input = "d";
                            right = 0;
                            left = 0;
                            up = 0;
                            down = 0;
                            pitbatadjacent = 0;
                            break;
                        }
                    }

                    right = 0;
                    left = 0;
                    up = 0;
                    down = 0;
                    int q = pick.Next(0, 4);
                    if (q == 0)
                    { 
                    input = "r";
                    right += 1;
                    }
                    if (q == 1)
                    {
                        input = "l";
                        left += 1;
                    }
                    if (q == 2)
                    {
                        input = "u";
                        up += 1;
                    }
                    if (q == 3)
                    {
                        input = "d";
                        down += 1;
                    }
                    q = 5;
                    break;
                }


                if (input == "r")
                {
                    player = RightAdjacent(player);

                }

                if (input == "l")
                {
                    player = LeftAdjacent(player);
                }

                if (input == "u")
                {
                    player = UpAdjacent(player);
                }

                if (input == "d")
                {
                    player = DownAdjacent(player);
                }

                if (input == "ar")
                {
                    player = RightAdjacent(player);
                    if (player == wumple)
                    {
                        Console.WriteLine("you win");
                        break;
                    }
                    if (player != wumple)
                    {
                        Console.WriteLine("you missed");
                        player = LeftAdjacent(player);
                        check += 1;
                    }
                 }
                if (input == "al")
                {
                    player = LeftAdjacent(player);
                    if (player == wumple)
                    {
                        Console.WriteLine("you win");
                        break;
                    }
                    if (player != wumple)
                    {
                        Console.WriteLine("you missed");
                        player = RightAdjacent(player);
                        check += 1;
                    }
                }
                if (input == "au")
                {
                    player = UpAdjacent(player);
                    if (player == wumple)
                    {
                        Console.WriteLine("you win");
                        break;
                    }
                    if (player != wumple)
                    {
                        Console.WriteLine("you missed");
                        player = DownAdjacent(player);
                        check += 1;
                    }
                }
                if (input == "ad")
                {
                    player = UpAdjacent(player);
                    if (player == wumple)
                    {
                        Console.WriteLine("you win");
                        break;
                    }
                    if (player != wumple)
                    {
                        Console.WriteLine("you missed");
                        player = UpAdjacent(player);
                        check += 1;
                    }
                }
             
                if (check == player)
                {
                    Console.WriteLine("invalid move");
                }
                check = player;
                int y = pick.Next(3);
                if (y == 0)
                {
                    player = wumple;
                    wumple = RightAdjacent(player);
                    
                }
                if (y == 1)
                {
                    player = wumple;
                    wumple = LeftAdjacent(player);
                    
                }
                if (y == 2)
                {
                    player = wumple;
                    wumple = UpAdjacent(player);
                   
                }
                if (y == 3)
                {
                    player = wumple;
                    wumple = DownAdjacent(player);
                    
                }
                y = 4;
                
                player = check;
            }
        }

        static int RightAdjacent(int player)
        {
           
            if (player == 4)
            {
                player -= 4;
                return player;
            }
            if (player == 19)
            {
                player -= 9;
                return player;
            }
            if (player >= 21)
            {
                player += 2;
                return player;
            }
            if (player == 29)
            {
                player -= 8;
                return player;
            }
            if (player != 4 && player != 19 && player < 20)
            {
                player += 1;
                return player;
            }
            return player;
        }
        static int LeftAdjacent(int player)
        {
         
            if (player == 0)
            {
                player += 4;
                return player;
            }
            if (player == 10)
            {
                player += 9;
                return player;
            }
            if (player >= 23)
            {
                player -= 2;
                return player;
            }
            if (player == 21)
            {
                player += 8;
                return player;
            }
            if (player != 0 && player != 10 && player <= 20)
            {
                player -= 1;
                return player;
            }
            return player;
        }
        static int UpAdjacent(int player)
        {
            if (player <= 4)
            {
                player = (10 + (2 * player));
                return player;
            }
            if (player == 11 || player == 13 || player == 15 || player == 17 || player == 19)
            {
                player += 10;
                return player;
            }
            return player;
        }
        static int DownAdjacent(int player)
        {
            if (player == 10 || player == 12 || player == 14 || player == 16 || player == 18)
            {
                player = ((player - 10) - ((player - 10) / 2));
                return player;
            }
            if (player == 21 || player == 23 || player == 25 || player == 27 || player == 29)
            {
                player -= 10;
                return player;
            }
            return player;
        }
        static int Check(int choose)
        {
            while ((choose >= 4 && choose <= 10) || choose == 20 || choose == 22 || choose == 24 || choose == 26 || choose == 28)
            {
                choose = new Random().Next(2, 29);
            }
            return choose;
        }
    }
}
   



