namespace core.medium;

public class GroupAnagrams
{
    /// <summary>
    /// Groups an array of strings into anagrams.
    /// </summary>
    /// <param name="strs">The array of strings.</param>
    /// <returns>A list of lists, where each inner list contains anagrams.</returns>
    public List<List<string>> Solve(string[] strs)
    {
        var anagrams = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            // Sort the string to find its anagram group
            var sortedStr = new string([.. str.OrderBy(c => c)]);

            if (!anagrams.TryGetValue(sortedStr, out List<string>? value))
            {
                value = [];
                anagrams[sortedStr] = value;
            }

            value.Add(str);
        }

        return [.. anagrams.Values];
    }

    public List<List<string>> Solve_Using_Character_Count(string[] strs)
    {
        var anagrams = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] charCount = new char[26];
            foreach (var c in str)
            {
                charCount[c - 'a']++;
            }
            string key = string.Join(",", charCount);
            if (!anagrams.TryGetValue(key, out List<string>? value))
            {
                value = [];
                anagrams[key] = value;
            }

            value.Add(str);
        }

        return [.. anagrams.Values];
    }
}
