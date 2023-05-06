namespace Staircase;

class Program {

    public static void Main(string[] args) {
        
        int n = 9;
        int spaces = n - 1;

        for (int i = 0; i < n; i++) {
            int briks = i + 1;
            for (int j = spaces; j > i; j--) {
                Console.Write(" ");
            }

            for (int k = 0; k < briks; k++) {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}