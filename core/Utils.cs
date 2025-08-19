namespace core;

public class Utils
{
    // TODO: This can be extracted to utils and be used by other frequency counters.
    public static Dictionary<TKey, int> BuildFrequencyMap<TKey>(TKey[] nums)
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
