namespace Challenge_Lab_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1 };
            int result = SingleNumber(nums);
            Console.WriteLine("The single number is: " + result);
        }

        static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            // Count each number
            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            // Find the single number
            foreach (var kvp in counts)
            {
                if (kvp.Value == 1)
                    return kvp.Key;
            }

            return -1; // This should not happen if input is valid
        }
    }
}


