using System.Text;

namespace CodingChallenge;

public class Staircase
{
    public void StaircaseExecution(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{new string(' ', n-i)}{new string('#', i)}");
        }
    }
}