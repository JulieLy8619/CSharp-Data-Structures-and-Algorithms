using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class FBObjectForNode
    {
        public int IntValue { get; set; } = 0;
        public string StringValue { get; set; }

        public FBObjectForNode(int value)
        {
            IntValue = value;
            StringValue = "";
        }
    }
}
