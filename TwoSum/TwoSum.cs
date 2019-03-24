using System;

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
    }
}
