namespace CodingChallenge.Test;

public class GradingStudentsTest
{
    private readonly GradingStudents _gradingStudents;
    
    public GradingStudentsTest()
    {
        _gradingStudents = new GradingStudents();
    }
    
    [Theory]
    [InlineData(84, 85)]
    [InlineData(57, 57)]
    [InlineData(73, 75)]
    [InlineData(67, 67)]
    [InlineData(38, 40)]
    public void RoundGradeTest(int grade, int roundedGrade)
    {
        var result = _gradingStudents.RoundGrade(grade);
        Assert.Equal(roundedGrade, result);
    }
    
    [Theory]
    [MemberData(nameof(GradingStudentsTestData))]
    public void GradingStudentsExecutionTest(List<int> numbers, List<int> expectedRatios)
    {
        var result = _gradingStudents.GradingStudentsExecution(numbers);
        Assert.Equal(expectedRatios, result);
    }

    public static IEnumerable<object[]> GradingStudentsTestData()
    {
        return new List<object[]>
        {
            new object[] { new List<int>{ 84, 29, 57 }, new List<int>{ 85, 29, 57 }},
            new object[] { new List<int>{ 73, 67, 38, 33 }, new List<int>{ 75, 67, 40, 33 }}
        };
    }
}