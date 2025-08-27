using System.Text;

namespace core.easy;

public class ValidPalindrome
{
    public bool Solve(string s)
    {
        // Input: "Was it a car or a cat I saw?"
        // Using front and end index and check each letter until they meet
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // If not alphanumeric, skip
            // The bound checks are necessary to ensure case like this: string s = "a!!!!b" won't break.
            while (left < right && !char.IsLetterOrDigit(s[left]))
                left++;
            while (right > left && !char.IsLetterOrDigit(s[right]))
                right--;

            Console.WriteLine($"left: {left}");
            Console.WriteLine($"right: {right}");

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }

    public bool Solve_UsingStringReversion(string s)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                sb.Append(s[i]);
            }
        }

        var newString = sb.ToString();
        var reversed = new string([.. sb.ToString().Reverse()]);

        Console.WriteLine(newString);
        Console.WriteLine(reversed);

        return newString.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}
