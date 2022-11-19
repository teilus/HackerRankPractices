namespace CodingChallenge;

public class MiniMaxSum
{
    public void MiniMaxSumExcecution(List<int> arr)
    {
        var result = GetMinMaxSum(arr);
        Console.WriteLine($"{result[0]} {result[1]}");
    }

    public long[] GetMinMaxSum(List<int> arr)
    {
        List<long> numbers = arr.ConvertAll(x => (long)x);
        
        long sumResult = numbers.Sum();
        long max = 0;
        long min = sumResult;

        foreach (var number in arr)
        {
            var result = sumResult - number;

            if (min > result)
            {
                min = result;
            }

            if (max < result)
            {
                max = result;
            }
        }
        
        return new long[] { min, max };
    }
}