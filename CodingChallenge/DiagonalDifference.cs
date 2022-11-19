namespace CodingChallenge;

public class DiagonalDifference
{
    public int DiagonalDifferenceExcecution(List<List<int>> arr)
    {
        var leftToRightResult = 0;
        var rightToLeftResult = 0;
        
        for (int i = 0, j = arr[0].Count-1; i < arr.Count; i++, j--)
        {
            leftToRightResult += arr[i][i];
            rightToLeftResult += arr[i][j];
        }

        return Math.Abs(leftToRightResult - rightToLeftResult);
    }
}