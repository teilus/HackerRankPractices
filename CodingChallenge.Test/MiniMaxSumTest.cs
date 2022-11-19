namespace CodingChallenge.Test;

public class MiniMaxSumTest
{
    private readonly MiniMaxSum _miniMaxSum;
    
    public MiniMaxSumTest()
    {
        _miniMaxSum = new MiniMaxSum();
    }

    [Theory]
    [MemberData(nameof(GetMinMaxSumTestData))]
    public void GetMinMaxSumTest(List<int> numbers, long[] expectedResult)
    {
        var result = _miniMaxSum.GetMinMaxSum(numbers);
        Assert.Equal(expectedResult, result);
    }
    
    public static IEnumerable<object[]> GetMinMaxSumTestData()
    {
        return new List<object[]>
        {
            new object[] { new List<int>{ 1, 3, 5, 7, 9 }, new long[] { 16, 24 }},
            new object[] { new List<int>{ 1, 2, 3, 4, 5 }, new long[] { 10, 14 }},
            new object[] { new List<int>{ 256741038, 623958417, 467905213, 714532089, 938071625}, 
                new long[] { 2063136757, 2744467344 }},
            new object[] { new List<int>{ 7, 69, 2, 221, 8974 }, new long[] { 299, 9271 }},
        };
    }
}