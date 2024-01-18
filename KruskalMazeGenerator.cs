using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace AsciiMaze
{
    class KruskalMazeGenerator : MazeGenerator
    {

        private readonly Random rnd;

        private readonly List<((int, int), (int, int), (int, int))> walls;

        private readonly List<HashSet<(int, int)>> cellSets;

        public KruskalMazeGenerator(int rows, int cols) : base(rows, cols)
        { 
            rnd = new Random();
            walls = new List<((int, int), (int, int), (int, int))>();
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    walls.Add(((2 * i + 1, 2 * j + 2), (2 * i + 1, 2 * j + 1), (2 * i + 1, 2 * j + 3)));
                }
            }
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    walls.Add(((2 * i + 2, 2 * j + 1), (2 * i + 1, 2 * j + 1), (2 * i + 3, 2 * j + 1)));
                }
            }
            walls = walls.OrderBy(_ => rnd.Next()).ToList();
            cellSets = new List<HashSet<(int, int)>>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    cellSets.Add(new HashSet<(int, int)>([(2 * i + 1, 2 * j + 1)]));
                }
            }
        }
        public override Maze GenerateMaze()
        {
            foreach (((int, int), (int, int), (int, int)) wall in walls)
            {
                var (w, c1, c2) = wall;
                bool isSameSet = CheckSameSet(cellSets, c1, c2);
                if (!isSameSet)
                {
                    maze.setCell(w, '.');
                    MergeSets(c1, c2);
                }

            }
            return maze;
        }

        private void MergeSets((int, int) c1, (int, int) c2)
        {
            HashSet<(int, int)> set1 = GetSet(c1);
            HashSet<(int, int)> set2 = GetSet(c2);
            cellSets.Remove(set1);
            cellSets.Remove(set2);
            HashSet<(int, int)> newSet = set1.Union(set2).ToHashSet();
            cellSets.Add(newSet);
        }

        private HashSet<(int, int)> GetSet((int, int) cell)
        {
            HashSet<(int, int)>? set = cellSets.Find(cellSet => cellSet.Contains(cell));
            Debug.Assert(set != null);
            return set;
        }

        private bool CheckSameSet(List<HashSet<(int, int)>> cellSets, (int, int) c1, (int, int) c2)
        {
            return cellSets.Exists(cellSet => cellSet.Contains(c1) && cellSet.Contains(c2));
        }
    }
}