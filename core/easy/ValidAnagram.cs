namespace core.easy;

public class Solution
{
    /// <summary>
    /// Determines whether two strings are anagrams of each other.
    /// An anagram is a word or phrase formed by rearranging the letters of another,
    /// typically using all the original letters exactly once.
    /// </summary>
    /// <param name="s">The first string to compare.</param>
    /// <param name="t">The second string to compare.</param>
    /// <returns>
    /// <c>true</c> if the strings are anagrams of each other; otherwise, <c>false</c>.
    /// </returns>
    /// <remarks>
    /// This method uses a dictionary to count the occurrences of each character in the first string
    /// and then subtracts the counts using the second string. If the counts match for all characters,
    /// the strings are anagrams.
    /// </remarks>
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        // Count characters in the first string
        var charCount = new Dictionary<char, int>();
        // Count each character's occurrences
        foreach (var c in s)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        foreach (var c in t)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]--;
                if (charCount[c] < 0)
                {
                    return false; // More occurrences in t than in s
                }
            }
            else
            {
                return false; // Character in t not found in s
            }
        }

        return charCount.Values.All(count => count == 0); // All counts should be zero if they are anagrams
    }
}
