namespace core.medium;

public class ProductsOfArrayExceptSelf
{
    public int[] Solve_BruteForce(int[] nums)
    {
        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            var product = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    product *= nums[j];
                }
            }
            result[i] = product;
        }

        return result;
    }

    public int[] Solve(int[] nums)
    {
        // Solve using prefix and suffix products
        var length = nums.Length;
        var result = new int[length];
        // A prefix product at index i is the product of all elements before i in the array.
        // Given [a, b, c, d] the prefix products is [1, a*b, a*b*c, a*b*c*d]
        //
        // A suffix product at index i is the product of all elements after i.
        // Given [a, b, c, d] the suffix products is [a*b*c*d, b*c*d, c*d, 1]
        //
        // They let you compute products excluding the current index efficiently.
        // result[i] = prefix[i] * suffix[i];

        // Prefix array first
        var prefixArray = new int[length];
        prefixArray[0] = 1; // The product of no elements is 1
        for (int i = 1; i < length; i++)
        {
            prefixArray[i] = prefixArray[i - 1] * nums[i - 1];
        }

        // Suffix array next
        var suffixArray = new int[length];
        suffixArray[length - 1] = 1; // The product of no elements is 1
        for (int i = length - 2; i >= 0; i--)
        {
            suffixArray[i] = suffixArray[i + 1] * nums[i + 1];
        }

        for (int i = 0; i < length; i++)
        {
            result[i] = prefixArray[i] * suffixArray[i];
        }

        return result;
    }
}
