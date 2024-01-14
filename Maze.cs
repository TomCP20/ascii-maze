

namespace AsciiMaze
{
    class Maze
    {
        readonly string[] maze;
        public readonly int height;
        public readonly int width;

        public Maze(string[] maze, int height, int width)
        {
            this.maze = maze;
            this.height = height;
            this.width = width;
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