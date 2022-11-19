using System.Globalization;

namespace CodingChallenge;

public class TimeConversion
{
    public string TimeConversionExecution(string s)
    {
        var formattedTime = FormatTime(s);
        var militaryTime = ConvertToMilitaryTime(formattedTime);
        
        return militaryTime;
    }

    public string FormatTime(string s)
    {
        var time = s.Substring(0, s.Length-2);
        var timeMarker = s.Substring(s.Length-2);
        
        return $"2022-05-07 {time} {timeMarker}";
    }

    public string ConvertToMilitaryTime(string time)
    {
        var cultureInfo = CultureInfo.InvariantCulture;

        var dateTime = DateTime.ParseExact(time, "yyyy-MM-dd hh:mm:ss tt", cultureInfo);
        
        return dateTime.ToString("HH:mm:ss");
    }
}