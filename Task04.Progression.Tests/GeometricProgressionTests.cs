using System;
using Xunit;

namespace Task04.Progression.Tests
{
    public class GeometricProgressionTests
    {
        [Fact]
        public void Test_2_4_8_()
        {
            var numbers = new[] { 2, 4, 8 };
            var result = Program.IsGeometricProgression(numbers);
            Assert.True(result);
        }
        [Fact]
        public void Test_1_2_4_()
        {
            var numbers = new[] { 1, 2, 4, 5 };
            var result = Program.IsGeometricProgression(numbers);
            Assert.False(result);
        }
        [Fact]
        public void Test_8_4_2_()
        {
            var numbers = new[] { 8, 4, 2 };
            var result = Program.IsGeometricProgression(numbers);
            Assert.True(result);
        }
        [Fact]
        public void Test_8_4_1_()
        {
            var numbers = new[] { 8, 4, 1 };
            var result = Program.IsGeometricProgression(numbers);
            Assert.False(result);
        }
        [Fact]
        public void Test_1_1_1_()
        {
            var numbers = new[] { 1, 1, 1 };
            var result = Program.IsGeometricProgression(numbers);
            Assert.True(result);
        }
        [Fact]
        public void Test_1_2_0_4_()
        {
            var numbers = new[] { 1, 2, 0, 4, 5 };
            var result = Program.IsGeometricProgression(numbers);
            Assert.False(result);
        }
        [Fact]
        public void Test_0_1_2_0_4_()
        {
            var numbers = new[] { 0, 1, 2, 0, 4, 5 };
            var result = Program.IsGeometricProgression(numbers);
            Assert.False(result);
        }
        [Fact]
        public void Test_0_0_0_()
        {
            var numbers = new[] { 0, 0, 0, 0, 0 };
            var result = Program.IsGeometricProgression(numbers);
            Assert.True(result);
        }
        [Fact]
        public void Test_1()
        {
            var numbers = new[] { 1};
            var result = Program.IsGeometricProgression(numbers);
            Assert.False(result);
        }
        [Fact]
        public void Test_Empty()
        {
            var numbers = new int[] { };
            var result = Program.IsGeometricProgression(numbers);
            Assert.False(result);
        }
    }
}
