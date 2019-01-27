using MultiBracketValidation;
using System;
using Xunit;

namespace CC13MultBrackValid_unittesting
{
    public class UnitTest1
    {
        //pass
        [Fact]
        public void Test1()
        {
            string test1String = "(){}[]({[wordsandletters]})";
            bool answer1 = Program.MultiBracketValidation(test1String);
            Assert.True(answer1);
        }

        //fail
        [Fact]
        public void Test2()
        {
            string test2String = "([)]";
            bool answer2 = Program.MultiBracketValidation(test2String);
            Assert.False(answer2);
        }

        //null?
        [Fact]
        public void Test3()
        {
            string test3String = "";
            bool answer3 = Program.MultiBracketValidation(test3String);
            Assert.False(answer3);
        }
    }
}
