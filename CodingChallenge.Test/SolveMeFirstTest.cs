namespace CodingChallenge.Test
{
    public class SolveMeFirstTest
    {
        private readonly SolveMeFirst _solveMeFirst;
        public SolveMeFirstTest()
        {
            _solveMeFirst = new SolveMeFirst();
        }
        
        [Theory]
        [InlineData(1, 1, 1000, true)]
        [InlineData(49, 1, 1000, true)]
        [InlineData(500, 1, 1000, true)]
        [InlineData(5000, 1, 1000, false)]
        [InlineData(-20, 1, 1000, false)]
        public void IsValidNumberTest(int numberToTest, int minRange, int maxRange, bool expectedResult)
        {
            bool result = _solveMeFirst.IsValidNumber(numberToTest, minRange, maxRange);
            Assert.Equal(expectedResult, result);
        }
        
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(49, 1, 50)]
        [InlineData(500, 500, 1000)]
        [InlineData(5000, 1, -1)]
        [InlineData(-20, 1, -1)]
        public void SolveMeFirstMethodTest(int a, int b, int expectedResult)
        {
            int result = _solveMeFirst.SolveMeFirstMethod(a, b);
            Assert.Equal(expectedResult, result);
        }
    }
}