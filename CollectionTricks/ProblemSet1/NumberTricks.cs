using System.Linq;
using System.Collections.Generic;

namespace CollectionTricks.ProblemSet1
{
    public static class NumberTricks
    {
        public static int GetBiggest(IEnumerable<int> collection)
        {
            return collection.Max();
        }

        public static int GetSmallest(IEnumerable<int> collection)
        {
            return collection.Min();
        }

        public static int GetSum(IEnumerable<int> collection)
        {
            return collection.Sum();
        }
    }
}