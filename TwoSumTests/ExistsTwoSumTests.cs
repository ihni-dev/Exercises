using System;
using Xunit;

namespace TwoSumTests
{
    public class ExistsTwoSumTests
    {
        [Fact]
        public void ExistsTwoSum_ShouldReturnTrue_IfGivenValidAndCorrectInput()
        {
            //Arrange
            var validArray = new int[] {1234, 5678, 9012};
            var targetSum = 14690;
            
            //Act
            var indicesFound = TwoSum.TwoSum.ExistsTwoSum(validArray, targetSum);
            
            //Assert
            Assert.True(indicesFound);
        }
        
        [Fact]
        public void ExistsTwoSum_ShouldReturnFalse_IfGivenValidAndIncorrectInput()
        {
            //Arrange
            var validArray = new int[] {1234, 5678, 9012};
            var targetSum = 0;
            
            //Act
            var indicesFound = TwoSum.TwoSum.ExistsTwoSum(validArray, targetSum);
            
            //Assert
            Assert.False(indicesFound);
        }
        
        [Fact]
        public void ExistsTwoSum_ShouldThrowArgumentException_IfGivenInvalidValidInput()
        {
            //Arrange
            var invalidArray = new int[] { 4 };
            var targetSum = 15;
            
            //Act && Assert
            Assert.Throws<ArgumentException>(() => TwoSum.TwoSum.ExistsTwoSum(invalidArray, targetSum));
        }
        
        [Fact]
        public void ExistsTwoSum_ShouldThrowArgumentException_IfGivenNullInput()
        {
            //Arrange
            var targetSum = 15;
            
            //Act && Assert
            Assert.Throws<ArgumentException>(() => TwoSum.TwoSum.ExistsTwoSum(null, targetSum));
        }
    }
}