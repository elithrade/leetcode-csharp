namespace core.medium;

public class TopKFrequentElements
{
    public int[] Solve(int[] nums, int k)
    {
        // First build the frequency map.
        // Input: [ 1, 1, 1, 2, 2, 3, 10 ]
        var frequencyMap = BuildFrequencyMap(nums);
        // Expected output: [{1, 3}, {2, 2}, {3, 1}, {10, 1}]

        // Create a new array using the value as array index.
        //
        // The array length should be frequency map's length + 1
        // because we using the frequency as index, the maximum
        // frequency of any element can be at most the length of the array.
        // Length + 1 because we not using the first index - 0.
        var frequencyArray = new List<List<int>>(nums.Length + 1);
        for (var i = 0; i < nums.Length + 1; i++)
        {
            frequencyArray.Add([]);
        }

        foreach (var kvp in frequencyMap)
        {
            var value = frequencyMap[kvp.Key];
            frequencyArray[value].Add(kvp.Key);
        }
        // Expected output: [ 0: [], 1: [3, 10], 2: [2], 3: [1], 4: [], 5: [], 6: [], 7: []]

        // Now we can iterate the frequency array in reverse order.
        var result = new List<int>();
        for (var i = frequencyArray.Count - 1; i > 0; i--)
        {
            var values = frequencyArray[i];
            foreach (var value in values)
            {
                // Add all numbers to result.
                result.Add(value);
                if (result.Count == k)
                {
                    return [.. result];
                }
            }
        }

        return [.. result];
    }

    public int[] Solve_UsingMinHeap(int[] nums, int k)
    {
        var frequencyMap = BuildFrequencyMap(nums);
        var minHeap = new PriorityQueue<int, int>();

        foreach (var kvp in frequencyMap)
        {
            minHeap.Enqueue(kvp.Key, kvp.Value);
            // If the heap exceeds size k, remove the least element with lower frequency.
            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        var result = new List<int>(k);
        for (var i = 0; i < k; i++)
        {
            result.Add(minHeap.Dequeue());
        }

        return [.. result];
    }

    // TODO: This can be extracted to utils and be used by other frequency counters.
    private static Dictionary<TKey, int> BuildFrequencyMap<TKey>(TKey[] nums)
        where TKey : notnull
    {
        var frequencyMap = new Dictionary<TKey, int>();
        foreach (var num in nums)
        {
            if (frequencyMap.TryGetValue(num, out int value))
            {
                frequencyMap[num] = ++value;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }

        return frequencyMap;
    }
}
