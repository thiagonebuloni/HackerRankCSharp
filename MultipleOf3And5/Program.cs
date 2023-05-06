namespace MultipleOf3And5;

public class Program {

    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= n; i++) {
            string answer = "";
            if (i % 3 == 0) {
                answer += "Fizz";
            }
            
            if (i % 5 == 0) {
                answer += "Buzz";
            }

            if (answer != "") Console.WriteLine(answer);
            else Console.WriteLine(i);
        }
    }
}

// Congratulations!