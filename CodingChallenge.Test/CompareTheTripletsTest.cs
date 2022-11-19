namespace CodingChallenge.Test;

public class CompareTheTripletsTest
{
    private readonly CompareTheTriplets _compareTheTriplets;
    
    public CompareTheTripletsTest()
    {
        _compareTheTriplets = new CompareTheTriplets();
    }
    
    [Theory]
    [MemberData(nameof(CompareTripletsTestData))]
    public void CompareTripletsTest(List<int> alice, List<int> bob, List<int> expectedResult)
    {
        var result = _compareTheTriplets.CompareTriplets(alice, bob);
        Assert.Equal(expectedResult, result);
    }
        
    public static IEnumerable<object[]> CompareTripletsTestData()
    {
        return new List<object[]>
        {
            new object[] { new List<int>{ 5, 6, 7 }, new List<int>{ 3, 6, 10 }, new List<int>{ 1, 1 }},
            new object[] { new List<int>{ 1, 2, 3 }, new List<int>{ 3, 2, 1 }, new List<int>{ 1, 1 }},
            new object[] { new List<int>{ 17, 28, 30 }, new List<int>{ 99, 16, 8 }, new List<int>{ 2, 1 }},
            new object[] { new List<int>{ 1, 2, 3 }, new List<int>{ 1, 2, 3 }, new List<int>{ 0, 0 }}
        };
    }
}