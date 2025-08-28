namespace core.medium;

public class TwoSumII
{
    public int[] Solve(int[] numbers, int target)
    {
        // Solve using two-pointer technique with sorted array
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum < target)
            {
                // Increase the left pointer to the right
                left++;
            }
            else if (sum > target)
            {
                // Descrease the right pointer to the left
                right--;
            }
            else
            {
                // 1-indexed
                return [left + 1, right + 1];
            }
        }
        return [];
    }
}
