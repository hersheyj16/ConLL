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

        public static void AppendNode(ref Node tail, String val)
        {
            Console.WriteLine("Appending a new node with val {0} to existing node {1}", val, tail.Value);
            tail.Next = new Node(val);
            tail = tail.Next;
        }

        internal static Node findTail(Node head)
        {
            while (head.Next != null)
            {
                head = head.Next;
            }

            return head;
        }

        internal static void AppendNodeHelper(Node tail, int n)
        {
            String val = tail.Value;
            for (int i = 0; i < n; i++)
            {
                Utils.AppendNode(ref tail, val + "-" + i);
            }
        }
    }
}