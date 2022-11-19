namespace CodingChallenge.Test;

public class BetweenTwoSetsTest
{
    private readonly BetweenTwoSets _betweenTwoSets;
    
    public BetweenTwoSetsTest()
    {
        _betweenTwoSets = new BetweenTwoSets();
    }
    
    [Theory]
    [MemberData(nameof(GetTotalXTestData))]
    public void GetTotalXTest(List<int> a, List<int> b, int numbers)
    {
        var result = _betweenTwoSets.GetTotalX(a, b);
        Assert.Equal(numbers, result);
    }
    
    public static IEnumerable<object[]> GetTotalXTestData()
    {
        return new List<object[]>
        {
            new object[] { new List<int>{ 2, 6 }, new List<int>{ 24, 36 }, 2 },
            new object[] { new List<int>{ 2, 4 }, new List<int>{ 16, 32, 96 }, 3 },
            new object[] { new List<int>{ 3, 4 }, new List<int>{ 24, 48 }, 2 },
            new object[] { new List<int>{ 1 }, new List<int>{ 72, 48 }, 8 },
        };
    }
    
    [Theory]
    [MemberData(nameof(GetCommonMultipliersTestData))]
    public void GetCommonMultipliersTest(List<int> numbers, int limit, HashSet<int> expectedFactors)
    {
        var commonFactors = _betweenTwoSets.GetCommonMultipliers(numbers, limit);
        Assert.Equal(expectedFactors, commonFactors);
    }

    public static IEnumerable<object[]> GetCommonMultipliersTestData()
    {
        return new List<object[]>
        {
            new object[] { new List<int>{ 2, 6 }, 24, new HashSet<int>{ 6, 12, 18, 24 } },
            new object[] { new List<int>{ 2, 4 }, 16, new HashSet<int>{ 4, 8, 12, 16 } },
            new object[] { new List<int>{ 3, 4 }, 24, new HashSet<int>{ 12, 24 } },
            new object[] { new List<int>{ 1 }, 12, new HashSet<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } }
        };
    }
    
    [Theory]
    [MemberData(nameof(GetMultipliersTestData))]
    public void GetMultipliersTest(int number, int limit, HashSet<int> multipliers)
    {
        var result = _betweenTwoSets.GetMultipliers(number, limit);
        Assert.Equal(multipliers, result);
    }
    
    public static IEnumerable<object[]> GetMultipliersTestData()
    {
        return new List<object[]>
        {
            new object[] { 2, 24, new HashSet<int>{ 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24 } },
            new object[] { 6, 24, new HashSet<int>{ 6, 12, 18, 24 } },
            new object[] { 2, 16, new HashSet<int>{ 2, 4, 6, 8, 10, 12, 14, 16 } },
            new object[] { 3, 24, new HashSet<int>{ 3, 6, 9, 12, 15, 18, 21, 24 } },
            new object[] { 1, 12, new HashSet<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
        };
    }
    
    [Theory]
    [MemberData(nameof(GetFactorsTestData))]
    public void GetFactorsTest(List<int> numbers, HashSet<int> commonMultipliers, List<int> commonFactors)
    {
        var result = _betweenTwoSets.GetFactors(numbers, commonMultipliers);
        Assert.Equal(commonFactors, result);
    }
    
    public static IEnumerable<object[]> GetFactorsTestData()
    {
        return new List<object[]>
        {
            new object[] { new List<int>{ 24, 36 }, new HashSet<int>{ 6, 12, 18, 24 }, new List<int>{ 6, 12 } },
            new object[] { new List<int>{ 16, 32, 96 }, new HashSet<int>{ 4, 8, 12, 16 }, new List<int>{ 4, 8, 16 } },
            new object[] { new List<int>{ 24, 48 }, new HashSet<int>{ 12, 24 }, new List<int>{ 12, 24 } },
            new object[] { new List<int>{ 48, 72 }, new HashSet<int>{  1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 
                16, 17, 18, 19, 20, 21, 22, 23,24, 25, 26, 27, 28, 29, 30 }, new List<int>{ 1, 2, 3, 4, 6, 8, 12, 24 } }
        };
    }
}