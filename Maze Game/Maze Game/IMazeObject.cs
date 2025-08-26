using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal interface IMazeObject
    {

        char Symbol {  get; }
        bool IsSolid {  get; }
    }
}
