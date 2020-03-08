using System.Collections.Generic;
using Xunit;

namespace CollectionTricks.ProblemSet1.Tests
{
    public class CollectionTricks_GetBiggestShould
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void ReturnBiggest(int[] list, object expected)
        {
            var result = NumberTricks.GetBiggest(list);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestCases => new List<object[]>
        {
            new object[] {new int[]{1, 2, 3}, 3},
            new object[] {new int[]{43, 45, 44}, 45}
        };
    }
}