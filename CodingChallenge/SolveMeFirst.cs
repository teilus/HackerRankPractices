namespace CodingChallenge
{
    public class SolveMeFirst
    {
        public int SolveMeFirstMethod(int a, int b)
        {
            var minRange = 1;
            var maxRange = 1000;
            
            if (!IsValidNumber(a, minRange, maxRange))
            {
                return -1;
            }

            if (!IsValidNumber(b, minRange, maxRange))
            {
                return -1;
            }
            
            return a+b;
        }

        public bool IsValidNumber(int number, int minRange, int maxRange)
        {
            if (minRange <= number && number <= maxRange)
            {
                return true;
            }

            return false;
        }
    }
}