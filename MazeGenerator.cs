using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace AsciiMaze
{
    abstract class MazeGenerator
    {
        protected int rows;
        protected int cols;

        protected Maze maze;
        protected MazeGenerator(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.maze = new Maze(rows, cols);
        }

        public abstract Maze GenerateMaze();
                
    }
}