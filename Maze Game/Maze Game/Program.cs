using System;

namespace Maze_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("========== Welcome To Maze Game ==========");
            Console.WriteLine("==========================================");

            Maze maze = new Maze(25, 25);
            while (true)
            {
                maze.DrawMaze();
                maze.MovePlayer();
            }
         
   
        }
        }
    }

