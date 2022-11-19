namespace CodingChallenge.Test;

public class NumberLineJumpsTest
{
    private readonly NumberLineJumps _numberLineJumps;
    
    public NumberLineJumpsTest()
    {
        _numberLineJumps = new NumberLineJumps();
    }
    
    [Theory]
    [InlineData(2, 1, 1, 2, "YES")]
    [InlineData(0, 2, 5, 3, "NO")]
    public void KangarooTest(int x1, int v1, int x2, int v2, string areKangaroosInSamePlace)
    {
        var result = _numberLineJumps.Kangaroo(x1, v1, x2, v2);
        Assert.Equal(areKangaroosInSamePlace, result);
    }
}