using System.Collections.Generic;
using Xunit;

namespace CollectionTricks.ProblemSet1.Tests
{
    public class CollectionTricks_GetSumShould
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void ReturnSum(int[] list, object expected)
        {
            var result = NumberTricks.GetSum(list);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestCases => new List<object[]>
        {
            new object[] {new int[]{1, 2, 3}, 6},
            new object[] {new int[]{3, 2, 1, 0, -1}, 5},
            new object[] {new int[]{-3, -2, -1, 0 }, -6},
        };
    }
}