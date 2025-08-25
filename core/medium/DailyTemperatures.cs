namespace core.medium;

public class DailyTemperatures
{
    public int[] Solve(int[] temperatures)
    {
        // Initialize result array with default values 0
        var result = new int[temperatures.Length];

        // Input: [30, 38, 30, 36, 35, 40, 28]
        // The trick is to use monotonic stack in decreasing order
        var stack = new Stack<Tuple<int, int>>(); // <temperature, index>
        for (int i = 0; i < temperatures.Length; i++)
        {
            var currentTemp = temperatures[i];
            // By using monotonic stack, we can pop all the temperatures that
            // are less than current temperature and add the popped index difference
            // to the result.
            while (stack.Count > 0 && stack.Peek().Item1 < currentTemp)
            {
                var (_, index) = stack.Pop();
                result[index] = i - index;
            }

            stack.Push(new Tuple<int, int>(currentTemp, i));
        }

        return result;
    }

    public int[] Solve_BruteForce(int[] temperatures)
    {
        int n = temperatures.Length;
        var result = new int[n];
        for (int i = 0; i < n; i++)
        {
            int count = 1;
            int j = i + 1;

            while (j < n)
            {
                if (temperatures[j] > temperatures[i])
                {
                    break;
                }

                count++;
                j++;
            }

            count = (j == n) ? 0 : count;
            result[i] = count;
        }

        return result;
    }
}
