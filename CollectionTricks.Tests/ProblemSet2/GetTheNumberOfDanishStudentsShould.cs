using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace CollectionTricks.ProblemSet2.Tests
{
    public class GetTheNumberOfDanishStudents
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void ReturnTheNumberOfDanishStudents(Student[] students, int expected)
        {
            var result = StudentTricks.GetNumberOfDanishStudents(students);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] {TestData.AllStudents, 6};
        }
    }
}