using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal class Player : IMazeObject
    {
        public char Symbol { get; } = '@';
        public bool IsSolid { get;} = true;
        public int X { get; set; }
        public int Y { get; set; }

        
    }
    
}
