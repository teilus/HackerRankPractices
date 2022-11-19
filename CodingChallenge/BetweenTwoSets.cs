namespace CodingChallenge;

public class BetweenTwoSets
{
    public int GetTotalX(List<int> a, List<int> b)
    {
        b.Sort();
        var limit = b[0];
        
        var commonMultipliers = GetCommonMultipliers(a, limit);

        var commonFactors = GetFactors(b, commonMultipliers);

        return commonFactors.Count;
    }

    public HashSet<int> GetCommonMultipliers(List<int> numbers, int limit)
    {
        numbers.Sort();
        
        var multipliers = GetMultipliers(numbers.Last(), limit);
        
        var numbersWithoutLast = numbers.GetRange(0, numbers.Count-1);

        foreach (var multiplier in multipliers)
        {
            foreach (var number in numbersWithoutLast)
            {
                if (multiplier%number != 0)
                {
                    multipliers.Remove(multiplier);
                }
            }
        }
        
        return multipliers;
    }

    public HashSet<int> GetMultipliers(int number, int limit)
    {
        var multipliers = new HashSet<int>();
        var result = number;

        while (result <= limit)
        {
            multipliers.Add(result);
            result += number;
        }
        
        return multipliers;
    }
    
    public List<int> GetFactors(List<int> numbers, HashSet<int> commonMultipliers)
    {
        foreach (var commonMultiplier in commonMultipliers)
        {
            foreach (var number in numbers)
            {
                if (number%commonMultiplier != 0)
                {
                    commonMultipliers.Remove(commonMultiplier);
                }
            }
        }

        return commonMultipliers.ToList();
    }
}