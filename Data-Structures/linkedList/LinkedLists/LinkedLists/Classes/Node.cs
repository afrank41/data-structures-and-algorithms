using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Classes
{
    public class Node
    {
        public object Key { get; set; }
        public object Value { get; set; }
        public Node Next { get; set; }

        public Node(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
