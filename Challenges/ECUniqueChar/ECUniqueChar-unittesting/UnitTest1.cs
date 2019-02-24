using ECUniqueChar;
using System;
using Xunit;

namespace ECUniqueChar_unittesting
{
    public class UnitTest1
    {
        //test happy case unique
        [Fact]
        public void TestHappyPass()
        {
            string testString1 = "abc";
            bool testAnswer1 = Program.UniqueChara(testString1);
            Assert.True(testAnswer1);
        }

        //test happy fail that there is duplicate
        [Fact]
        public void TestHappyFail()
        {
            string testString2 = "abcabc";
            bool testAnswer2 = Program.UniqueChara(testString2);
            Assert.False(testAnswer2);
        }

        //test caps
        [Fact]
        public void TestCaps()
        {
            string testString3 = "Aa";
            bool testAnswer3 = Program.UniqueChara(testString3);
            Assert.False(testAnswer3);
        }

        //test empty string
        [Fact]
        public void TestEmptyString()
        {
            string testString4 = "";
            bool testAnswer4 = Program.UniqueChara(testString4);
            Assert.False(testAnswer4);
        }

    }
}



