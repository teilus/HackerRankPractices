namespace CodingChallenge.Test;

public class BreakingTheRecordsTest
{
    private readonly BreakingTheRecords _breakingTheRecordsTest;
    
    public BreakingTheRecordsTest()
    {
        _breakingTheRecordsTest = new BreakingTheRecords();
    }
    
    [Theory]
    [MemberData(nameof(BreakingRecordsTestData))]
    public void BreakingRecordsTest(List<int> scores, List<int> expectedRecords)
    {
        var result = _breakingTheRecordsTest.BreakingRecords(scores);
        Assert.Equal(expectedRecords, result);
    }

    public static IEnumerable<object[]> BreakingRecordsTestData()
    {
        return new List<object[]>
        {
            new object[] { new List<int>{ 10, 5, 20, 20, 4, 5, 2, 25, 1 }, new List<int>{ 2, 4 }},
            new object[] { new List<int>{ 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 }, new List<int>{ 4, 0 }},
        };
    }
}