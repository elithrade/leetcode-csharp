using System.Text;

namespace core.medium;

public class EncodeDecodeString
{
    public string Encode(IList<string> strs)
    {
        StringBuilder sb = new();
        foreach (var s in strs)
        {
            sb.Append(s.Length).Append('#').Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        // Given input "5#hello5#world", we need to decode it into ["hello", "world"]
        List<string> result = [];
        int i = 0;
        while (i < s.Length)
        {
            int delimiterIndex = i;
            // Read until the delimiter '#'
            while (s[delimiterIndex] != '#')
            {
                delimiterIndex++;
            }
            var length = int.Parse(s[i..delimiterIndex]);

            // ["5", "#", "h", "e", "l", "l", "o"]
            //   0    1    2    3    4    5    6
            // We need to start from the index after the delimiter '#'
            var startIndex = delimiterIndex + 1;
            string str = s.Substring(startIndex, length);

            // Move to the next encoded string
            i = startIndex + length;

            result.Add(str);
        }

        return result;
    }
}
