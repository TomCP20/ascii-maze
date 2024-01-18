namespace AsciiMaze
{
    internal static class Program
    {
        static int Main(string[] args)
        {
            int height = Convert.ToInt32(args[1]);
            int width = Convert.ToInt32(args[2]);
            string path = "";
            bool saveMaze = false;
            if (args.Length > 3)
            {
                path = args[3];
                saveMaze = true;
            }
            MazeGenerator MG;
            switch (args[0])
            {
                case "DFS":
                    MG = new RandomDepthFirstSearchMazeGenerator(height, width);
                    break;
                case "Kruskal":
                    MG = new KruskalMazeGenerator(height, width);
                    break;
                default:
                    Console.WriteLine("Invalid Maze Generation method.");
                    return 1;
            }
            Maze m = MG.GenerateMaze();
            m.displayMaze();
            if (saveMaze)
            {
                File.WriteAllText(path, m.ToString());
            }
            return 0;
        }
    }
}