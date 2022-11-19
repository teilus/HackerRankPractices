namespace CodingChallenge.Test;

public class DiagonalDifferenceTest
{
    private readonly DiagonalDifference _diagonalDifference;
    
    public DiagonalDifferenceTest()
    {
        _diagonalDifference = new DiagonalDifference();
    }
    
    [Theory]
    [MemberData(nameof(CompareTripletsTestData))]
    public void CompareTripletsTest(List<List<int>> squareMatrix, int expectedResult)
    {
        var result = _diagonalDifference.DiagonalDifferenceExcecution(squareMatrix);
        Assert.Equal(expectedResult, result);
    }
        
    public static IEnumerable<object[]> CompareTripletsTestData()
    {
        var list11 = new List<int> { 1, 2, 3 };
        var list12 = new List<int> { 4, 5, 6 };
        var list13 = new List<int> { 9, 8, 9 };
        
        var list21 = new List<int> { 11, 2, 4 };
        var list22 = new List<int> { 4, 5, 6 };
        var list23 = new List<int> { 10, 8, -12 };
        
        return new List<object[]>
        {
            new object[] { new List<List<int>> { list11, list12, list13}, 2},
            new object[] { new List<List<int>> { list21, list22, list23}, 15}
        };
    }
}