namespace AsciiMaze
{
    internal static class Program
    {
        static void Main()
        {
            Maze m = MazeGenerator.GenerateMaze(7, 30);
            m.displayMaze();
        }
    }
}