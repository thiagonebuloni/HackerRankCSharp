namespace TimeConvertion;
// https://www.hackerrank.com/challenges/one-week-preparation-kit-time-conversion/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(timeConvertion("12:05:45AM"));
    }
        public static string timeConvertion (string s)
        {
            

            string morningOrEvening = s.Substring(8,2);
            
            if (morningOrEvening.Equals("PM"))
            {
                
                if (!s.Substring(0,2).Equals("12"))
                {
                    int newHour = int.Parse(s.Substring(0,2)) + 12;
                    return $"{newHour}{s.Substring(2,6)}";
                }
                else
                {
                    return $"{s.Substring(0,8)}";
                }
            }
            else {
                if (s.Substring(0,2).Equals("12"))
                {
                    return $"00{s.Substring(2,6)}";
                }
                else
                {
                    return $"{s.Substring(0,8)}";
                }
            }

            // Console.WriteLine($"{morningOrEvening}");
        }
}