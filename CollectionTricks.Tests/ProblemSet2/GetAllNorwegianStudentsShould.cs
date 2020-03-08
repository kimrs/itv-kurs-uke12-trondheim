using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace CollectionTricks.ProblemSet2.Tests
{
    public class GetAllNorwegianStudentsShould
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void ReturnAllNorwegianStudents(Student[] students, int[] expected)
        {
            var result = StudentTricks.GetAllNorwegianStudents(students)
                                      .Select(x => x.Id);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] {TestData.AllStudents, new int[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 }};
        }
    }
}