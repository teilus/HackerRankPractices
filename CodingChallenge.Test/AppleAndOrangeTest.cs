namespace CodingChallenge.Test;

public class AppleAndOrangeTest
{
    private readonly AppleAndOrange _appleAndOrange;
    
    public AppleAndOrangeTest()
    {
        _appleAndOrange = new AppleAndOrange();
    }

    [Theory]
    [MemberData(nameof(CountApplesAndOrangesTestData))]
    public void CountApplesAndOrangesTest(
        int s, 
        int t, 
        int a, 
        int b, 
        List<int> apples, 
        List<int> oranges, 
        List<int> fruits)
    {
        var result = _appleAndOrange.CountApplesAndOrangesInRange(s, t, a, b, apples, oranges);
        Assert.Equal(fruits, result);
    }

    public static IEnumerable<object[]> CountApplesAndOrangesTestData()
    {
        return new List<object[]>
        {
            new object[] { 7, 10, 4, 12, new List<int>{ 2, 3, -4 }, new List<int>{ 3, -2, -4 }, new List<int>{ 1, 2 }},
            new object[] { 7, 11, 5, 15, new List<int>{ -2, 2, 1 }, new List<int>{ 5, -6 }, new List<int>{ 1, 1 }}
        };
    }
}