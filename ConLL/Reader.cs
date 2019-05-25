using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace ConLL
{
    public class Reader
    {
        public Node Head { get; set; }

        public Reader(Node head)
        {
            Head = head;
        }

        public void Read()
        {          
            Utils.TraverseNode(Head);
        }
    }
}