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
        public Node nextNode { get; set; }
        public Node(string value, Node nextNode)
        {
            Value = value;
            this.nextNode = nextNode;
        }

        public Node(string value)
        {
            Value = value;
        }
    }
}
