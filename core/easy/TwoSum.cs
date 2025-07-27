namespace core.easy
{
    public class TwoSum
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// </summary>
        /// <param name="nums">The array of integers.</param>
        /// <param name="target">The target sum.</param>
        /// <returns>An array containing the indices of the two numbers that sum up to the target.</returns>
        public int[] Solve(int[] nums, int target)
        {
            // A dictionary to store numbers and their indices
            var numMap = new System.Collections.Generic.Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                // If the complement exists in the map, we found our pair
                if (numMap.ContainsKey(complement))
                {
                    return new int[] { numMap[complement], i };
                }
                // Otherwise, add the current number and its index to the map
                if (!numMap.ContainsKey(nums[i])) // Avoid adding duplicate keys if nums contains duplicates
                {
                    numMap.Add(nums[i], i);
                }
            }

            // In a typical LeetCode scenario, this line would not be reached if a solution is guaranteed.
            // However, for robustness, you might throw an exception or return an empty array.
            throw new System.ArgumentException("No two sum solution");
        }
    }
}
