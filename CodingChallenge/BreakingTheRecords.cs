namespace CodingChallenge;

public class BreakingTheRecords
{
    public List<int> BreakingRecords(List<int> scores)
    {
        var records = new List<int>() {0, 0};

        var maxScore = scores[0];
        var minScore = scores[0];

        foreach (var score in scores)
        {
            if (score > maxScore)
            {
                records[0]++;
                maxScore = score;
            }

            if (score < minScore)
            {
                records[1]++;
                minScore = score;
            }
        }
        
        return records;
    }
}