namespace CodingChallenge.Test;

public class AVeryBigSumTest
{
    private readonly AVeryBigSum _aVeryBigSum;
    
    public AVeryBigSumTest()
    {
        _aVeryBigSum = new AVeryBigSum();
    }
    
    [Theory]
    [MemberData(nameof(AVeryBigSumExceutionTestData))]
    public void AVeryBigSumExceutionTest(List<long> numbers, long expectedResult)
    {
        var result = _aVeryBigSum.AVeryBigSumExcecution(numbers);
        Assert.Equal(expectedResult, result);
    }
        
    public static IEnumerable<object[]> AVeryBigSumExceutionTestData()
    {
        return new List<object[]>
        {
            new object[] { new List<long>{ 1000000001, 1000000002 , 1000000003, 1000000004, 1000000005 }, 5000000015},
        };
    }
}