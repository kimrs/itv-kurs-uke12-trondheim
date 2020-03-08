using System;
using System.Linq;
using System.Collections.Generic;

namespace CollectionTricks.ProblemSet2
{
    public static class StudentTricks
    {
        public static IEnumerable<Student> GetAllNorwegianStudents(IEnumerable<Student> collection)
        {
            return collection.Where(x => x.Nationality == Nationality.Norwegian);
        }

        public static Student GetTheOldestStudent(IEnumerable<Student> collection)
        {
            return collection.OrderBy(x => x.BirthDay)
                             .First();
        }

        public static int GetNumberOfDanishStudents(IEnumerable<Student> collection)
        {
            return collection.Where(x => x.Nationality == Nationality.Danish)
                             .Count();
        }

        public static IEnumerable<Student> GetStudentsFromTheFuture(IEnumerable<Student> collection)
        {
            return collection.Where(x => x.BirthDay > DateTime.Now);
        }
        
    }
}