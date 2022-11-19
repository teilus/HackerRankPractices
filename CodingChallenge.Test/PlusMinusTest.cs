namespace CodingChallenge.Test;

public class PlusMinusTest
{
    private readonly PlusMinus _plusMinus;
    
    public PlusMinusTest()
    {
        _plusMinus = new PlusMinus();
    }
    
    [Theory]
    [InlineData(2, 5, 0.400000)]
    [InlineData(1, 5, 0.200000)]
    [InlineData(3, 6, 0.500000)]
    [InlineData(2, 6, 0.333333)]
    [InlineData(1, 6, 0.166667)]
    public void CalculateRatioTest(int totalNumbers, int listSize, double expectedResult)
    {
        var result = _plusMinus.CalculateRatio(totalNumbers, listSize);
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [MemberData(nameof(PlusMinusTestData))]
    public void CalculateRatiosTest(List<int> numbers, List<double> expectedRatios)
    {
        var result = _plusMinus.CalculateRatios(numbers);
        Assert.Equal(expectedRatios, result);
    }

    public static IEnumerable<object[]> PlusMinusTestData()
    {
        return new List<object[]>
        {
            new object[] { new List<int>{ 1, 1, 0, -1, -1 }, new List<double>{ 0.400000, 0.400000, 0.200000 }},
            new object[] { new List<int>{ -4, 3, -9, 0, 4, 1, }, new List<double>{ 0.500000, 0.333333, 0.166667 }},
        };
    }
}