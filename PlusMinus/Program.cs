namespace PlusMinus;

class Program
{

    public static void Main(string[] args)
    {
        // int numbersLength = 6;
        int numbersLength = int.Parse(Console.ReadLine());

        // List<int> numbers = new List<int> { -4, 3, -9, 0, 4, 1 };
        // List<int> numbers = new List<int>();
        string[] numbersArray = Console.ReadLine().Split();

        int greaterThanZero = 0;
        int zero = 0;
        int lessThanZero = 0;

        for (int i = 0; i < numbersLength; i++)
        {
            if (int.Parse(numbersArray[i]) > 0)
            {
                greaterThanZero++;
            }
            else if (int.Parse(numbersArray[i]) < 0)
            {
                lessThanZero++;
            }
            else zero++;
        }
        
        double ratioGreaterThanZero = (double)greaterThanZero / numbersLength;
        double ratioLessThanZero = (double)lessThanZero / numbersLength;
        double ratioZero = zero / (double)numbersLength;

        Console.WriteLine(ratioGreaterThanZero.ToString("0.000000"));
        Console.WriteLine(ratioLessThanZero.ToString("0.000000"));
        Console.WriteLine(ratioZero.ToString("0.000000"));
    }

}