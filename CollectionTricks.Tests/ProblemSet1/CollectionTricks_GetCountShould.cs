using System.Collections.Generic;
using Xunit;

namespace CollectionTricks.ProblemSet1.Tests
{
    public class CollectionTricks_GetCountShould
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void ReturnCount(object[] list, object expected)
        {
            var result = SimpleTricks<object>.GetCount(list);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestCases => new List<object[]>
        {
            new object[] {new object[]{1, 2, 3}, 3},
            new object[] {new object[]{3.4, 2.3, 1.2, 0.0}, 4},
            new object[] {new object[]{"The", "cake", "is", "a", "lie"}, 5},
        };
    }
}