using System;
using System.Collections.Generic;

namespace TwoSum
{
    public static class TwoSum
    {
        public static bool TryFindIndices(int[] numbers, int target, out int[] result)
        {
            if (numbers == null || numbers.Length < 2)
                throw new ArgumentException("Invalid numbers array passed. At least 2 elements required");

            result = new int[2];
            var lookup = new HashSet<int>();

            for (int i = 0; i < numbers.Length; i++)
            {  
                if (lookup.Contains(target - numbers[i]))
                {
                    result[0] = i;
                    result[1] = Array.IndexOf(numbers, target - numbers[i]);

                    return true;
                }
                
                lookup.Add(numbers[i]);
            }
            
            return false;
        }

        public static bool ExistsTwoSum(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length < 2)
                throw new ArgumentException("Invalid numbers array passed. At least 2 elements required");

            var lookup = new HashSet<int>();

            foreach (var number in numbers)
            {
                if (lookup.Contains(target - number))
                    return true;
                
                lookup.Add(number);
            }

            return false;
        }
    }
}
