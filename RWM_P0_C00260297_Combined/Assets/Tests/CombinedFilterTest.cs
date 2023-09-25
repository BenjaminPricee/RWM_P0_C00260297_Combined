using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 5, 3, 6, 7, 9 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 0, 3, 4, 6,10 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
