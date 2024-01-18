using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace AsciiMaze
{
    class RandomDepthFirstSearchMazeGenerator : MazeGenerator
    {

        private readonly Random rnd;

        public RandomDepthFirstSearchMazeGenerator(int rows, int cols) : base(rows, cols)
        {
            rnd = new Random();
        }

        public override Maze GenerateMaze()
        {
            List<(int, int)> visited = new List<(int, int)>();
            DFS((1, 1), visited, maze);
            return maze;
        }

        private void DFS((int, int) coords, List<(int, int)> visited, Maze maze)
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

        private IEnumerable<(int, int)> Neighbors((int, int) coords)
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