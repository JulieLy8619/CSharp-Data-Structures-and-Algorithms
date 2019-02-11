using System;
using Xunit;
using ECFib;

namespace ECFib_unittesting
{
    //reminder, I assumed it started at 0:  0, 1, 1, 2, 3, 5, 8, 13, 21, ...etc
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(3, Program.FibNum(5));
        }

        [Fact]
        public void Test2()
        {
            Assert.NotEqual(2, Program.FibNum(5));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(21, Program.FibNum(9));
        }
    }
}
