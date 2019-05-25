using System;

namespace ConLL
{
    public class Utils
    {
        public static void TraverseNode(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        public static void AppendNode(Node tail, String val)
        {
            Console.WriteLine("Appending a new node with val {0} to existing node {1}", val, tail.Value);
            tail.Next = new Node(val);
        }

        internal static Node findTail(Node head)
        {
            while (head.Next != null)
            {
                head = head.Next;
            }

            return head;
        }
    }
}