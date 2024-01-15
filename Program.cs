namespace AsciiMaze
{
    internal static class Program
    {
        static void Main()
        {
            Maze m = MazeGenerator.GenerateMaze(100, 100);
            m.displayMaze();
        }
    }
}