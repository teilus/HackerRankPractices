namespace CodingChallenge;

public class AppleAndOrange
{
    public void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var fruits = CountApplesAndOrangesInRange(s, t, a, b, apples, oranges);
        Console.WriteLine(fruits[0]);
        Console.WriteLine(fruits[1]);
    }
    
    public List<int> CountApplesAndOrangesInRange(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        return new List<int>
        {
            apples.Where(x => x + a >= s && x + a <= t).ToList().Count,
            oranges.Where(x => x + b >= s && x + b <= t).ToList().Count
        };
    }
}