using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace CollectionTricks.ProblemSet2.Tests
{
    public class GetStudentsFromTheFutureShould
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void ReturnAllStudentsFromTheFuture(Student[] students, int[] expected)
        {
            var result = StudentTricks.GetStudentsFromTheFuture(students)
                                      .Select(x => x.Id);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] {TestData.AllStudents, new int[] {13, 21}};
        }
    }
}