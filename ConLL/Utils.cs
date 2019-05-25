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
                node = node.nextNode;
            }
        }
    }
}