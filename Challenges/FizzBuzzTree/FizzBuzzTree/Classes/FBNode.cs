using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class FBNode
    {
        public FBObjectForNode Value { get; set; }
        public FBNode LeftChild { get; set; }
        public FBNode RightChild { get; set; }

        public FBNode(FBObjectForNode objectInfo)
        {
            Value = objectInfo;
            LeftChild = null;
            RightChild = null;
        }
    }

}
