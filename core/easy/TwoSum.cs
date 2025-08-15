namespace core.easy;

public class TwoSum
{
    /// <summary>
    /// Given an array of integers numbers and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// </summary>
    /// <param name="numbers">The array of integers.</param>
    /// <param name="target">The target sum.</param>
    /// <returns>An array containing the indices of the two numbers that sum up to the target.</returns>
    public int[] Solve(int[] numbers, int target)
    {
        // A dictionary to store numbers and their indices
        var numMap = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int complement = target - numbers[i];
            // If the complement exists in the map, we found our pair
            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i };
            }

            // Otherwise, add the current number and its index to the map
            if (!numMap.ContainsKey(numbers[i])) // Avoid adding duplicate keys if numbers contains duplicates
            {
                numMap.Add(numbers[i], i);
            }
        }

        // In a typical LeetCode scenario, this line would not be reached if a solution is guaranteed.
        // However, for robustness, you might throw an exception or return an empty array.
        throw new ArgumentException("No two sum solution");
    }
}
