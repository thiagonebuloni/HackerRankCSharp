using System.IO;

namespace GridChallenge;

public class Program
{

    public static void Main(string[] args)
    {
        // List<string> newList = new List<string>{ "eabcd", "fghij", "olkmn", "trpqs", "xywuv" };
        // List<string> newList2 = new List<string>{ "abc", "aed", "efg"};
        List<string> newList = new List<string>{ "kc", "iu"};
        // List<string> newList2 = new List<string>{ "uxf", "vof", "hmp"};

        // List<string> newList = new List<string>(fileToLists());
        Console.WriteLine($"{gridChallenge(newList)}");
        // Console.WriteLine($"{gridChallenge(newList2)}");
        // Console.WriteLine($"newList = { newList }");
    }

    
    public static string gridChallenge(List<string> grid)
    {
        int rows = grid.Count;
        foreach (var c in grid) Console.WriteLine($"{c}");

        int columns = grid[0].Length;

        List<string> gridSorted = new List<string>();

        for (int i = 0; i < rows; i++)
        {
            string sorted = grid[i];
            sorted = String.Concat(sorted.OrderBy(c => char.ToLower(c)).ThenBy(c => c));
            Console.WriteLine($"{sorted}");
            gridSorted.Add(sorted);
        }
        

        foreach (var row in gridSorted) Console.WriteLine($"{row}");

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows - 1; j++) {
                if (gridSorted[j][i] > gridSorted[j + 1][i])
                {
                    Console.WriteLine($"gridSorted[j][i] > gridSorted[j+1][i]{gridSorted[j][i]} > {gridSorted[j + 1][i]}");
                    return "NO";
                }
            }
        }

        return "YES";
    }
}