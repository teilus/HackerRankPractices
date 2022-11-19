namespace CodingChallenge;

public class BirthdayCakeCandles
{
    public int BirthdayCakeCandlesExecution(List<int> candles)
    {
        var maximum = 0;
        var numberOfCandles = 0;

        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] > maximum)
            {
                maximum = candles[i];
                numberOfCandles = 1;
            }
            else if (candles[i] == maximum)
            {
                numberOfCandles++;
            }
        }
        
        return numberOfCandles;
    }
}