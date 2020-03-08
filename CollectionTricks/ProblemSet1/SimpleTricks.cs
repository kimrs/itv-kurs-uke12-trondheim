using System;
using System.Linq;
using System.Collections.Generic;

namespace CollectionTricks.ProblemSet1
{
    public static class SimpleTricks<T>
    {
        public static T GetFirst(IEnumerable<T> collection)
        {
            return collection.First();
        }

        public static T GetLast(IEnumerable<T> collection)
        {
            return collection.Last();
        }

        public static int GetCount(IEnumerable<T> collection)
        {
            return collection.Count();
        }

    }
}
