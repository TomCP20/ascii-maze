

using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace AsciiMaze
{
    static class MazeGenerator
    {
        
        static Random rnd = new Random();
        public static Maze BlankMaze(int rows, int cols)
        {
            int height = 2*rows+1;
            int width = 2*cols+1;
            string evenRow = new string('#', width);
            string[] walls = new string[cols+1];
            Array.Fill(walls, "#");
            string oddRow = string.Join(".", walls);
            string[] maze = new string[height];
            for (int i = 0; i < height; i++)
            {
                maze[i] = i % 2 == 0 ? evenRow : oddRow;
            }
            return new Maze(maze, height, width);
        }

        public static Maze GenerateMaze(int height, int width)
        {
            Maze maze = BlankMaze(height, width);
            List<(int, int)> visited = new List<(int, int)>();
            DFS((1, 1), visited, maze);
            return maze;
        }

        public static void DFS((int, int) coords, List<(int, int)> visited, Maze maze)
        {
            var (y, x) = coords;
            visited.Add(coords);
            foreach ((int, int) neighbor in Neighbors(coords))
            {
                if (maze.validPos(neighbor) && !visited.Contains(neighbor))
                {
                    var (ny, nx) = neighbor;
                    int wy = (ny + y)/2;
                    int wx = (nx + x)/2;
                    maze.setCell((wy, wx), '.');
                    DFS(neighbor, visited, maze);
                }
            }

        }

        static IEnumerable<(int, int)> Neighbors((int, int) coords)
        {
            var (y, x) = coords;
            (int, int)[] neighbors = [
                (y - 2, x),
                (y + 2, x),
                (y, x - 2),
                (y, x + 2)];
            neighbors = neighbors.OrderBy(_ => rnd.Next()).ToArray();
            foreach ((int, int) neighbor in neighbors)
            {
                yield return neighbor;
            }
        }

        
    }
}