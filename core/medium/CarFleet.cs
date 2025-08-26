namespace core.medium;

public class CarFleet
{
    public int Solve(int target, int[] position, int[] speed)
    {
        // The key to understand the problem is that
        // 1. Computer each car's time to reach the target
        // 2. Sort cars by position in descending order (closest to target first)
        // 3. Traverse from closest to target to farthest and create a new fleet
        // only when time to target is greater than the previous car's time to target
        // otherwise the car joins the fleet of the previous car.

        // O(n log n) to sort the array on position closest to target first
        // int[] position = [1, 4];
        // int[] speed = [3, 2];
        // Output: (4, 2), (1, 3)
        var pairs = position
            .Zip(speed, (pos, spd) => (pos, spd))
            .OrderByDescending(ps => ps.pos)
            .ToArray();

        Console.WriteLine(string.Join(", ", pairs));
        // The stack will keep track of the time to reach the target
        // Actually the stack is not necessary, we can just keep a counter fleet
        // and the previous time to target prevTime
        var stack = new Stack<double>();
        // From closest to target to farthest
        for (var i = 0; i < pairs.Length; i++)
        {
            // What time does the car reaches the target?
            var timeToTarget = (double)(target - pairs[i].pos) / pairs[i].spd;

            if (stack.Count == 0 || timeToTarget > stack.Peek())
            {
                // Will not form a fleet, push to the stack
                stack.Push(timeToTarget);
            }
        }

        return stack.Count;
    }

    public int Solve_NoStack(int target, int[] position, int[] speed)
    {
        var pairs = position
            .Zip(speed, (pos, spd) => (pos, spd))
            .OrderByDescending(ps => ps.pos) // closest first
            .ToArray();

        int fleets = 0;
        double lastFleetTime = 0; // time of the fleet ahead

        for (int i = 0; i < pairs.Length; i++)
        {
            var timeToTarget = (double)(target - pairs[i].pos) / pairs[i].spd;

            if (timeToTarget > lastFleetTime)
            {
                // new fleet
                fleets++;
                lastFleetTime = timeToTarget;
            }
            // else: this car merges into the fleet in front
        }

        return fleets;
    }
}
