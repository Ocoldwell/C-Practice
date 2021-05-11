using System.Collections.Generic;

namespace ConsecutiveNumbers
{
    class AreConsecutive
    {
        public static bool Consecutive(IReadOnlyList<int> numbers)
        {
            for (var i = 1; i < numbers.Count; ++i)
            {
                if (numbers[i] != numbers[i - 1] + 1) return false;
            }
            return true;
        }
    }
}
