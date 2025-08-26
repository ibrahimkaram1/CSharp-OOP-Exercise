using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal class Maze
    {
        private int Width;
        private int Height;
        private Player player;
        private IMazeObject[,] mazeObjectsArray;
        public Maze(int width ,int height) 
        {
            Width = width;
            Height = height;
            mazeObjectsArray = new IMazeObject[Height, Width]; 
            player = new Player { X =1, Y = 1 }; 
        }
        public void MovePlayer()
        {
            Console.WriteLine("Use Your Keyboard To Move ");

            Console.WriteLine("Moving player...");
            ConsoleKeyInfo userInput = Console.ReadKey();
            switch (userInput.Key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, -1);
                    Console.WriteLine("Player moved up.");
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                    Console.WriteLine("Player moved down.");
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    Console.WriteLine("Player moved left.");
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    Console.WriteLine("Player moved right.");
                    break;
                default:
                    Console.WriteLine("Invalid move. Use arrow keys to move the player.");
                    break;
            }

        }
        public void UpdatePlayer(int dx ,int dy)
        {

            int newx =  player.X + dx;
              int newy = player.Y + dy;

            if (newx >= 0 && newx < Width - 1 && newy >= 0 && newy < Height - 1 && mazeObjectsArray[newx,newy].IsSolid==false)
            {
                player.X = newx;
                player.Y = newy;
            }
            else
            {
                Console.WriteLine("Cannot move outside the maze boundaries.");
            }

            }
        

        public void DrawMaze()
        {
       
            Console.Clear();


            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (x==23 & y == 23)
                    {
                        mazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(mazeObjectsArray[x, y].Symbol);
                        if (player.X == 23 && player.Y == 23)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Write("\n========================================\n");
                            Console.Write("====== Congratulations! You win ========\n");
                            Console.Write("========================================");
                            Console.ResetColor();
                            Environment.Exit(0);
                        }
                    }


                    else if (y == 0 || y == Height - 1 || x == 0 || x == Width - 1)
                    {
                        mazeObjectsArray[x, y] = new Wall();
                        Console.Write(mazeObjectsArray[x, y].Symbol);
                    }
                    else if (x == player.X && y == player.Y)
                    {
                        mazeObjectsArray[x, y] = player;
                        Console.Write(player.Symbol);
                    }
                    else if (x % 2 == 0 && y % 2 == 0)
                    {
                        mazeObjectsArray[x, y] = new Wall();

                        Console.Write(mazeObjectsArray[x, y].Symbol);
                    }
                    else if (x % 3 == 0 && y % 3== 0)
                    {
                        mazeObjectsArray[x, y] = new Wall();

                        Console.Write(mazeObjectsArray[x, y].Symbol);
                    }
                    else if (x % 5 == 0 && y % 5== 0)
                    {
                        mazeObjectsArray[x, y] = new Wall();

                        Console.Write(mazeObjectsArray[x, y].Symbol);
                    }
                    else
                    {
                        mazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(mazeObjectsArray[x, y].Symbol);

                    }
               

                }            

                Console.WriteLine();
            }
        }


    }
}
