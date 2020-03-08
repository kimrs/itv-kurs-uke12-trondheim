using System.Collections.Generic;
using Xunit;

namespace CollectionTricks.ProblemSet1.Tests
{
    public class CollectionTricks_GetFirstShould
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void ReturnFirst(object[] list, object expected)
        {
            var result = SimpleTricks<object>.GetFirst(list);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestCases => new List<object[]>
        {
            new object[] {new object[]{1, 2, 3}, 1},
            new object[] {new object[]{3.4, 2.3, 1.2}, 3.4},
            new object[] {new object[]{"kurs","med", "itverket"}, "kurs"},
        };
    }
}