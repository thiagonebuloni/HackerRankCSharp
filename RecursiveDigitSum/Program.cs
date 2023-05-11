namespace RecursiveDigitSum;

public class Program
{

    public static void Main(string[] args)
    {
        string n = "9875";
        int k = 4;
        Console.WriteLine($"{superDigit(n, k)}");
    }

    public static int superDigit(string n, int k)
    {
        List<long> digits = new List<long>();
        long sum = 0;

        foreach (char digit in n)
        {
            digits.Add(int.Parse(digit.ToString()));
            Console.WriteLine($"{digit}");
        }

        foreach (long num in digits) sum += num;

        Console.WriteLine($"sum = {sum}");
        Console.ReadLine();

        sum *= k;

        if (sum > 9) return superDigit(Convert.ToString(sum), 1);

        return Convert.ToInt32(sum);

    }

    
}