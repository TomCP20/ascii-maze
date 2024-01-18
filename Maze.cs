

namespace AsciiMaze
{
    class Maze
    {
        readonly string[] maze;
        public readonly int height;
        public readonly int width;

        public Maze(int rows, int cols)
        {
            height = 2*rows+1;
            width = 2*cols+1;
            string evenRow = new string('#', width);
            string[] walls = new string[cols+1];
            Array.Fill(walls, "#");
            string oddRow = string.Join(".", walls);
            this.maze = new string[height];
            for (int i = 0; i < height; i++)
            {
                maze[i] = i % 2 == 0 ? evenRow : oddRow;
            }
        }

        public Maze(string[] maze, int rows, int cols)
        {
            this.maze = maze;
            height = 2*rows+1;
            width = 2*cols+1;
        }

        public override string ToString()
        {
            return string.Join("\n", maze);
        } 

        public void displayMaze()
        {
            Console.WriteLine(ToString());
        }

        public bool validPos((int, int) coords)
        {
            var (y, x) = coords;
            return 0 <= y && y < height && 0 <= x && x < width;
        }

        public void setCell((int, int) coords, char value)
        {
            var (y, x) = coords;
            char[] charArray = maze[y].ToCharArray();
            charArray[x] = value;
            maze[y] = new string(charArray);
        }

    }
}