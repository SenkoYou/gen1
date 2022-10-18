using System;

namespace gen1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];
            for (int i = 0; i < nums.Length; i++) {
                Random rnd = new Random();
                nums[i] = rnd.Next(100);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное: " + max);
            Console.WriteLine("Минимальное: " + min);
        }
    }
}
