using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    class CharNode
    {
        public char Value { get; set; }
        public CharNode Next { get; set; }

        public CharNode(char value)
        {
            Value = value;
            Next = null;
        }
    }
}
