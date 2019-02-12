using System;
using Xunit;
using AreCharaUnique;

namespace AreCharaUnique_unittesting
{
    public class UnitTest1
    {
        //happy path, no dups
        [Fact]
        public void TestHappyPassCase()
        {
            bool testAnswer1 = Program.AreCharactersUnique("something");
            Assert.True(testAnswer1);
        }

        //happy path, there are dups
        [Fact]
        public void TestHappyFailCase()
        {
            bool testAnswer1 = Program.AreCharactersUnique("Doesn't pass");
            Assert.False(testAnswer1);
        }

        //null string
        [Fact]
        public void TestNullCase()
        {
            bool testAnswer1 = Program.AreCharactersUnique("");
            Assert.True(testAnswer1);
        }
    }
}
