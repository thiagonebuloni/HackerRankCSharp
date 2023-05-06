// https://www.hackerrank.com/challenges/one-week-preparation-kit-diagonal-difference/problem?h_l=interview&isFullScreen=false&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-two&h_r=next-challenge&h_v=zen

namespace DiagonalDifference;

class Program
{

    public static void Main(string[] args)
    {

        List<int> lineOne = new List<int> {11, 12, 4};
        List<int> lineTwo = new List<int> {4, 5, 6};
        List<int> lineThree = new List<int> {10, 8, -12};
        List<List<int>> arr = new List<List<int>> { lineOne, lineTwo, lineThree };
        
        Console.WriteLine(diagonalDifference(arr));
    }

    public static int diagonalDifference(List<List<int>> arr)
    {
        int arrLength = arr.Count;
        
        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;

        for (int i = 0; i < arrLength; i++)
        {
            for (int j = 0; j < arrLength; j++)
            {
                if (i == j) primaryDiagonal += arr[i][j];
                    if ((i + j) == arrLength - 1) secondaryDiagonal += arr[i][j];
                else if ((i + j) == arrLength - 1) secondaryDiagonal += arr[i][j];
            }
        }

        int absoluteDifference = Math.Abs(primaryDiagonal - secondaryDiagonal);

        return absoluteDifference;
    }
}

/*

    0  1  2
0  00 01 02
1  10 11 12
2  20 21 22
*/