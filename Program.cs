namespace AsciiMaze
{
    internal static class Program
    {
        static int Main(string[] args)
        {
            int height = Convert.ToInt32(args[0]);
            int width = Convert.ToInt32(args[1]);
            string path = "";
            bool saveMaze = false;
            if (args.Length > 2)
            {
                path = args[2];
                saveMaze = true;
            }
            Maze m = MazeGenerator.GenerateMaze(height, width);
            m.displayMaze();
            if (saveMaze)
            {
                File.WriteAllText(path, m.ToString());
            }
            return 0;
        }
    }
}