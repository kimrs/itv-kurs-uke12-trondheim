using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace CollectionTricks.ProblemSet2.Tests
{
    public class GetTheOldestStudentShould
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void ReturnTheOldestStudent(Student[] students, int expected)
        {
            var result = StudentTricks.GetTheOldestStudent(students);

            Assert.Equal(expected, result.Id);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] {TestData.AllStudents, 1};
        }
    }
}