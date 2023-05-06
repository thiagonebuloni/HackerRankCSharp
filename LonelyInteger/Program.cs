namespace LonelyInteger;

class Program
{

    public static void Main(string[] args)
    {
        List<int> a = new List<int> { 1, 2, 3, 4, 3, 2, 1};
        Console.WriteLine(lonelyInteger(a));
    }

    public static int lonelyInteger(List<int> a)
    {
        a.Sort();
        Dictionary<int, int> numbers = new Dictionary<int, int>();

        for (int i = 0; i < a.Count; i++)
        {
            if (!numbers.ContainsKey(a[i]))
            {
                numbers.Add(a[i], 1);
            }
            // catch (ArgumentException)
            else
            {
                numbers[a[i]] = numbers[a[i]] + 1;
            }
        }

        int lonelyInt = numbers.FirstOrDefault(x => x.Value == 1).Key;


        
        return lonelyInt;
    }
}