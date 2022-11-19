namespace CodingChallenge.Test;

public class TimeConversionTest
{
    private readonly TimeConversion _timeConversion;
    
    public TimeConversionTest()
    {
        _timeConversion = new TimeConversion();
    }
    
    [Theory]
    [InlineData("12:00:00AM", "00:00:00")]
    [InlineData("12:00:00PM", "12:00:00")]
    [InlineData("12:01:00PM", "12:01:00")]
    [InlineData("12:01:00AM", "00:01:00")]
    [InlineData("07:05:45PM", "19:05:45")]
    public void TimeConversionExecutionTest(string initialTIme, string militaryTime)
    {
        var result = _timeConversion.TimeConversionExecution(initialTIme);
        Assert.Equal(militaryTime, result);
    }
}