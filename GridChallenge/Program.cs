namespace GridChallenge;

public class Program
{

    public static void Main(string[] args)
    {
        List<string> grid = new List<string>{ "ebacd", "fghij", "olmkn", "trpqs", "xywuv" };

        gridChallenge(grid);
    }

    public static string gridChallenge(List<string> grid)
    {
        string result = "YES";

        int rows = grid.Count;
        List<string> gridSorted = new List<string>();

        for (int i = 0; i < rows; i++)
        {
            string sorted = grid[i];
            sorted = String.Concat(sorted.OrderBy(c => char.ToLower(c)).ThenBy(c => c));
            gridSorted.Add(sorted);
        }
        

        foreach (var row in gridSorted) Console.WriteLine($"{row}");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - 1; j++) {
                if (grid[j][i] > grid[j + 1][i])
                {
                    result = "NO";
                    break;
                }
            }
        }
        Console.WriteLine($"{result}");

        return result;
    }
}