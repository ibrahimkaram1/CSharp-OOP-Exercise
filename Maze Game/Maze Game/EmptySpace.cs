using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal class EmptySpace : IMazeObject
    {
        public char Symbol { get;  } = ' ';
        public bool IsSolid { get; } = false;
       
    }
    
}
