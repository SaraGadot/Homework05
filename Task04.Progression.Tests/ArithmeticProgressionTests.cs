using System;
using Xunit;

namespace Task04.Progression.Tests
{
    public class ArithmeticProgressionTests
    {
        [Fact]
        public void Test_1_2_3_()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var result = Program.IsArithmeticProgression(numbers);
            Assert.True(result);
        }
        [Fact]
        public void Test_1_2_4_()
        {
            var numbers = new[] { 1, 2, 4, 5 };
            var result = Program.IsArithmeticProgression(numbers);
            Assert.False(result);
        }
        [Fact]
        public void Test_1_1_1_()
        {
            var numbers = new[] { 1, 1, 1 };
            var result = Program.IsArithmeticProgression(numbers);
            Assert.True(result);
        }
        [Fact]
        public void Test_1__1_1_()
        {
            var numbers = new[] { 1, -1, 1 };
            var result = Program.IsArithmeticProgression(numbers);
            Assert.False(result);
        }
        [Fact]
        public void Test_1()
        {
            var numbers = new[] { 1};
            var result = Program.IsArithmeticProgression(numbers);
            Assert.False(result);
        }
        [Fact]
        public void Test_Empty()
        {
            var numbers = new int[] { };
            var result = Program.IsArithmeticProgression(numbers);
            Assert.False(result);
        }
    }
}
