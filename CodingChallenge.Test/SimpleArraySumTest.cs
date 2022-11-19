using System.Collections.Generic;

namespace CodingChallenge.Test
{
    public class SimpleArraySumTest
    {
        private readonly SimpleArraySum _simpleArraySum;
        public SimpleArraySumTest()
        {
            _simpleArraySum = new SimpleArraySum();
        }
        
        [Theory]
        [MemberData(nameof(SimpleArraySumTestData))]
        public void SimpleArraySumMethodTest(List<int> arrayNumbers, int expectedResult)
        {
            var result = _simpleArraySum.SimpleArraySumMethod(arrayNumbers);
            Assert.Equal(expectedResult, result);
        }
        
        public static IEnumerable<object[]> SimpleArraySumTestData()
        {
            return new List<object[]>
            {
                new object[] { new List<int>{ 1, 2, 3, 4, 10, 11 }, 31 },
                new object[] { new List<int>{ 1, 2, 3 }, 6 },
                new object[] { new List<int>{ 1, 0, 0 }, 1 }
            };
        }
    }
}