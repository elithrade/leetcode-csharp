using System.Diagnostics;

namespace core.medium;

public class LongestConsecutive
{
    public int Solve(int[] nums)
    {
        // Input: [2, 20, 4, 10, 3, 4, 5]
        var numSet = new HashSet<int>(nums);
        // Hast set will be {2, 20, 4, 10, 3, 5}

        var longest = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            // If nums[i] - 1 is not in the set, it means nums[i] is the start of a sequence
            if (!numSet.Contains(nums[i] - 1))
            {
                var length = 1;
                // Look for the next consecutive numbers
                // In the case of 2, it will try to find 2, 3, 4 until 5 which is not in the set
                while (numSet.Contains(nums[i] + length))
                {
                    length++;
                }

                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
