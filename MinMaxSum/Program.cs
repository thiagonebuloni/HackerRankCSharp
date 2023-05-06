namespace MinMaxSum;

class Program {

    public static void Main(string[] args) {
        
        // https://www.hackerrank.com/challenges/one-week-preparation-kit-mini-max-sum/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one&h_r=next-challenge&h_v=zen
        List<int> arr = new List<int> { 7, 69, 2, 221, 8974 };
        
        
        arr.Sort();
        long min = 0;
        long mx = 0;
        
        for (int i = 0; i < arr.Count - 1; i++) {
            min += arr[i];
            mx += arr[i + 1];
        }

        Console.Write($"{min} {mx}");

        // foreach (Int64 num in arr) Console.WriteLine(num);
    }
}