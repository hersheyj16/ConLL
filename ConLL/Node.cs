using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLL
{

    public class Node
    {
        public String Value { get; set; }
        public Node Next { get; set; }
        public Node(string value, Node next)
        {
            Value = value;
            this.Next = next;
        }

        public Node(string value)
        {
            Value = value;
        }
    }
}
