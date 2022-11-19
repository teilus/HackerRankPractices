namespace CodingChallenge;

public class PlusMinus
{
    public void PlusMinusExcecution(List<int> arr)
    {
        var ratios = CalculateRatios(arr);
        PrintRatios(ratios);
    }
    
    public List<double> CalculateRatios(List<int> arr)
    {
        var totalNumbers = arr.Count;
        var positiveNumbers = 0;
        var negativeNumbers = 0;
        var zeros = 0;

        foreach (var number in arr)
        {
            if (number > 0)
            {
                positiveNumbers++;
            }
            else if (number < 0)
            {
                negativeNumbers++;
            }
            else
            {
                zeros++;
            }
        }
        
        var ratios = new List<double>
        {
            CalculateRatio(positiveNumbers, totalNumbers),
            CalculateRatio(negativeNumbers, totalNumbers),
            CalculateRatio(zeros, totalNumbers)
        };

        return ratios;
    }

    public double CalculateRatio(int totalNumbers, int listSize)
    {
        var result = Convert.ToDouble(totalNumbers) /  Convert.ToDouble(listSize);
        return Math.Round(result, 6);
    }
    
    public void PrintRatios(List<double> ratios)
    {
        foreach (var ratio in ratios)
        {
            Console.WriteLine(ratio);
        }
    }
}