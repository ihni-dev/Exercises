using System;
using System.Collections.Generic;

namespace TwoSum
{
    public class TwoSum
    {
        public static bool TryFindIndices(int[] numbers, int target, out int[] result)
        {
            if (numbers == null || numbers.Length < 2)
                throw new ArgumentException("Invalid numbers array passed. At least 2 elements required");
            
            Array.Sort(numbers);

            result = new int[2];
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;

            while (leftIndex < rightIndex)
            {
                var sum = numbers[leftIndex] + numbers[rightIndex];
                if (sum == target)
                {
                    result[0] = rightIndex;
                    result[1] = leftIndex;
                    return true;
                }
                else if (sum < target) 
                    leftIndex++;
                else 
                    rightIndex--;

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
