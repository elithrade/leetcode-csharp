namespace core.medium;

public class ThreeSum
{
    public List<List<int>> Solve(int[] nums)
    {
        // Input: [-1,0,1,2,-1,-4]
        var sorted = nums.OrderBy(x => x).ToArray();
        // Output: [-4, -1, -1, 0, 1, 2]

        var result = new List<List<int>>();
        for (int i = 0; i < sorted.Length; i++)
        {
            // First number is -4, so from the next number
            // we need to find two numbers that sum to 4
            // we can use two pointers approach.
            // The key point is to skip duplicates
            // not just i, but left and right as well.
            if (i > 0 && sorted[i - 1] == sorted[i])
            {
                // We have already processed this number
                continue;
            }

            int left = i + 1;
            int right = sorted.Length - 1;

            int target = -sorted[i];
            while (left < right)
            {
                var sum = sorted[left] + sorted[right];
                if (sum < target)
                {
                    // Move the left pointer to the right
                    left++;
                }
                else if (sum > target)
                {
                    // Move the right pointer to the left
                    right--;
                }
                else
                {
                    // We found a triplet
                    result.Add([sorted[i], sorted[left], sorted[right]]);
                    left++;
                    right--;

                    // Skip duplicates for the second number, this is tricky...
                    while (left < right && sorted[left] == sorted[left - 1])
                        left++;

                    while (left < right && sorted[right] == sorted[right + 1])
                        right--;
                }
            }
        }

        return result;
    }
}
