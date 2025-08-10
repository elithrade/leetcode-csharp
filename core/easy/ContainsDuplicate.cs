namespace core.easy;

public class ContainsDuplicate
{
    /// <summary>
    /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    /// You should aim for a solution with O(n) time and O(n) space, where n is the size of the input array.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>True if there are duplicates, otherwise false.</returns>
    public bool Solve(int[] nums)
    {
        // A HashSet to track seen numbers
        var seenNumbers = new HashSet<int>();
        foreach (var num in nums)
        {
            // If the number is already in the set, we found a duplicate
            if (seenNumbers.Contains(num))
            {
                return true;
            }
            seenNumbers.Add(num);
        }

        // If we finish the loop without finding duplicates, return false
        return false;
    }
}
