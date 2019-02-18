using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class KVNode
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public KVNode Next { get; set; }

        public KVNode(string key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
