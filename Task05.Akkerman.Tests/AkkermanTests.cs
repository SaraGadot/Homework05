using System;
using Xunit;

namespace Task05.Akkerman.Tests
{
    public class AkkermanTests
    {
        [Fact]
        public void Test_0_0()
        {
            Assert.Equal(1, Program.Akkerman(0, 0));

        }
        [Fact]
        public void Test_4_1() 
        {
            Assert.Equal(65533, Program.Akkerman(4, 1));

        }
        [Fact]
        public void Test_3_5()
        {
            Assert.Equal(253, Program.Akkerman(3, 5));

        }
    }
}
