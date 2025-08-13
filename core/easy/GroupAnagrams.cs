namespace core.easy;

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
            var sortedStr = new string(str.OrderBy(c => c).ToArray());

            if (!anagrams.ContainsKey(sortedStr))
            {
                anagrams[sortedStr] = new List<string>();
            }

            anagrams[sortedStr].Add(str);
        }

        return anagrams.Values.ToList();
    }
}
