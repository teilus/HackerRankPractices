namespace CodingChallenge;

public class NumberLineJumps
{
    public string Kangaroo(int x1, int v1, int x2, int v2)
    {
        for (var i = 10000; i > 0; i--)
        {
            if (x1 == x2)
            {
                return "YES";
            }

            x1 += v1;
            x2 += v2;
        }
        
        return "NO";
    }
}