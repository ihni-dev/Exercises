using System;
using Xunit;

namespace TwoSumTests
{
    public class TwoSumTests
    {
        [Fact]
        public void TryFindIndices_ShouldReturnTrue_IfGivenValidAndCorrectInput()
        {
            //Arrange
            var validArray = new int[] {1234, 5678, 9012};
            var targetSum = 14690;
            
            //Act
            var indicesFound = TwoSum.TwoSum.TryFindIndices(validArray, targetSum, out int[] indices);
            
            //Assert
            Assert.True(indicesFound);
        }
        
        [Fact]
        public void TryFindIndices_ShouldReturnValidIndices_IfGivenValidAndCorrectInput()
        {
            //Arrange
            var validArray = new int[] { 3, 5, 2, -4, 8, 11 };
            var targetSum = 7;
            
            //Act
            var indicesFound = TwoSum.TwoSum.TryFindIndices(validArray, targetSum, out int[] indices);
            
            //Assert
            Assert.Equal(targetSum, validArray[indices[0]] + validArray[indices[1]]);
        }
        
        [Fact]
        public void TryFindIndices_ShouldReturnFalse_IfGivenValidAndIncorrectInput()
        {
            //Arrange
            var validArray = new int[] { 4, 5, 1, 8 };
            var targetSum = 999;
            
            //Act
            var indicesFound = TwoSum.TwoSum.TryFindIndices(validArray, targetSum, out int[] indices);
            
            //Assert
            Assert.False(indicesFound);
        }
        
        [Fact]
        public void TryFindIndices_ShouldReturnEmptyArray_IfGivenValidAndIncorrectInput()
        {
            //Arrange
            var validArray = new int[] { 4, 5, 1, 8 };
            var targetSum = 999;
            
            //Act
            var indicesFound = TwoSum.TwoSum.TryFindIndices(validArray, targetSum, out int[] indices);
            
            //Assert
            Assert.True(indices[0] == 0 && indices[1] == 0);
        }
        
        [Fact]
        public void TryFindIndices_ShouldThrowArgumentException_IfGivenInvalidValidInput()
        {
            //Arrange
            var invalidArray = new int[] { 4 };
            var targetSum = 15;
            
            //Act && Assert
            Assert.Throws<ArgumentException>(() => TwoSum.TwoSum.TryFindIndices(invalidArray, targetSum, out int[] indices));
        }
        
        [Fact]
        public void TryFindIndices_ShouldThrowArgumentException_IfGivenNullInput()
        {
            //Arrange
            var targetSum = 15;
            
            //Act && Assert
            Assert.Throws<ArgumentException>(() => TwoSum.TwoSum.TryFindIndices(null, targetSum, out int[] indices));
        }
    }
}