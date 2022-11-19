namespace CodingChallenge.Test;

public class BirthdayCakeCandlesTest
{
    private readonly BirthdayCakeCandles _birthdayCakeCandles;
    
    public BirthdayCakeCandlesTest()
    {
        _birthdayCakeCandles = new BirthdayCakeCandles();
    }

    [Theory]
    [MemberData(nameof(BirthdayCakeCandlesExecutionTestData))]
    public void BirthdayCakeCandlesExecutionTest(List<int> numbers, int expectedCandles)
    {
        var candles = _birthdayCakeCandles.BirthdayCakeCandlesExecution(numbers);
        Assert.Equal(expectedCandles, candles);
    }

    public static IEnumerable<object[]> BirthdayCakeCandlesExecutionTestData()
    {
        return new List<object[]>
        {
            new object[] { new List<int>{ 4, 4, 1, 3 }, 2},
            new object[] { new List<int>{ 3, 2, 1, 3 }, 2}
        };
    }
}